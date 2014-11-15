using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Diagnostics;
using System.Xml;
using System.Windows.Forms;

namespace RssReader.Parsers
{
    class HtmlParser
    {
        public HtmlAgilityPack.HtmlDocument GetUrlAsHtmlDocument(string url)
        {
            var webGet = new HtmlWeb();
            return webGet.Load(url);
        }

        public List<String> GetLinks(HtmlAgilityPack.HtmlDocument document)
        {
            var dataList = new List<string>();
            var nodes = document.DocumentNode.SelectNodes("//div[contains(@class,'adres')]/a").Select
                (
                    adres =>
                    adres.GetAttributeValue("href", "")
                ).Where(ad => ad != "").ToList();
            return nodes;
        }
    }
}
