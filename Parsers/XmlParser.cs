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

        public List<Item> GetRssItems(string url)
        {
            var xDocument = XDocument.Load(url);
            var items = from item in xDocument.Descendants("item")
                        select new Item
                        {
                            id = Guid.NewGuid().ToString(),
                            title = GetElementValueIfExists(item, "title"),
                            link = GetElementValueIfExists(item, "link"),
                            description = GetElementValueIfExists(item, "desciption"),
                            category = GetElementValueIfExists(item, "category"),
                            pubDate = GetElementValueIfExists(item, "pubDate"),
                            guid = GetElementValueIfExists(item, "guid"),
                            html = "",
                        };
            return items.ToList();
        }
    }
}
