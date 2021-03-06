﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Diagnostics;
using System.Xml;

namespace RssReader.Parsers
{
    class HtmlParser
    {
        public HtmlDocument GetUrlAsDocument(string url)
        {
            var webGet = new HtmlWeb();
            return webGet.Load(url);
        }

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
            string node;
            if(document.DocumentNode.SelectSingleNode("//div[@id='wpCenter']")!=null)
            {
                node = document.DocumentNode.SelectSingleNode("//div[@id='wpCenter']").InnerHtml.ToString(); 
            }
            else
                node=" ";
            return node;
        }
    }
}
