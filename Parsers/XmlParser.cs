using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;

namespace RssReader.Parsers
{
    class XmlParser
    {
        public string GetRssItems(string url)
        {
            //TODO: when Item class will be added then change "select new" to "select new Item"
            // and change return type to list of Items - List<Item>
            var xDocument = XDocument.Load(url);
            var items = from item in xDocument.Descendants("item")
            select new
            {
                title = item.Descendants("title").First().Value,
                link = item.Descendants("link").First().Value,
                description = item.Descendants("description").First().Value,
                category = item.Descendants("category").First().Value,
                pubDate = item.Descendants("pubDate").First().Value,
                guid = item.Descendants("guid").First().Value,
                html = "",
            };
            return "";
        }
    }
}
