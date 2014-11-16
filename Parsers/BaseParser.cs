using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader.Parsers
{
    class BaseParser
    {
        public HtmlDocument GetUrlAsDocument(string url)
        {
            var webGet = new HtmlWeb();
            return webGet.Load(url);
        }
    }
}
