using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryCatalog.DataLayer
{
    public class Item : ItemIF
    {
        public int Id { get; set; }

        public string Title { get; set; }
        
    }
}