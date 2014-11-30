using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;
using RssReader.Model;

namespace RssReader.Parsers
{
    class XmlParser
    {
        public string GetElementValueIfExists(XElement item, string name)
        {
            if (item.Descendants(name).Count() != 0)
            {
                return item.Descendants(name).First().Value;
            }
            else return "";
        }

        public string GetUrlWithoutXml(string url)
        {
            return url.Replace("rss.xml", "");
        }

        public string GetCorrectLink(XElement item, string url)
        {
            string baseUrl = GetUrlWithoutXml(url);
            string link = GetElementValueIfExists(item, "link");
            return link.Replace("///", baseUrl);
        }

        public List<Item> GetRssItems(string url)
        {
            var xDocument = XDocument.Load(url);
            var items = from item in xDocument.Descendants("item")
                        select new Item
                        {
                            id = Guid.NewGuid().ToString(),
                            title = GetElementValueIfExists(item, "title"),
                            link = GetCorrectLink(item, url),
                            description = GetElementValueIfExists(item, "description"),
                            category = GetElementValueIfExists(item, "category"),
                            pubDate = GetElementValueIfExists(item, "pubDate"),
                            guid = GetElementValueIfExists(item, "guid"),
                            html = "",
                        };
            return items.ToList();
        }
    }
}
