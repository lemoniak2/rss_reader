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
    class HtmlParser : BaseParser
    {
        public List<String> GetLinks(string url)
        {
            var document = GetUrlAsDocument(url);
            var dataList = new List<string>();
            var nodes = document.DocumentNode.SelectNodes("//div[contains(@class,'adres')]/a").Select
                (
                    adres =>
                    adres.GetAttributeValue("href", "")
                ).Where(ad => ad != "").ToList();
            return nodes;
        }

        public string GetArticleContent(string url)
        {
            var document = GetUrlAsDocument(url);
            var node = document.DocumentNode.SelectSingleNode("//div[@id='wpCenter']").InnerHtml.ToString();
            return node;
        }
    }
}
