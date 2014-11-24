using RssReader.Models;
using RssReader.Parsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssReader
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadRssData_Click(object sender, EventArgs e)
        {
            var htmlParser = new HtmlParser();
            var xmlParser = new XmlParser();
            var rssLinks = htmlParser.GetLinks("http://rss.wp.pl/s,rozrywka,index.html"); //get all rss links
            foreach (var rssLink in rssLinks)
            {
                var items = xmlParser.GetRssItems(rssLink); //get all items of rss
                foreach (var item in items)
                {
                    using (var db = new ItemDataContext())
                    {
                        if (!db.Items.Any(o => o.guid == item.guid)) //check guid existance in entity DB
                        {
                            item.html = htmlParser.GetArticleContent(item.link);
                            db.Items.Add(item);
                            db.SaveChanges();
                        }
                    }
                }
            }
        }
    }
}
