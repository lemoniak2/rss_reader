﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader.Model
{
    public class Item
    {
        public string id { get; set; }
        public string title { get; set; }
        public string link { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string pubDate { get; set; }
        public string guid { get; set; }
        public string url { get; set; }
        public string html { get; set; }
    }
}
