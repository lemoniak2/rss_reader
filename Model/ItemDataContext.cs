using RssReader.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader.Models
{
    public class ItemDataContext: DbContext
    {
            public ItemDataContext() : base("name=rss")
            {

            }

            public DbSet<Item> Items { get; set; }
        }
    }
