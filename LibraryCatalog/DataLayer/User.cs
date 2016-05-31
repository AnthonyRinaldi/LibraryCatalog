using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryCatalog.DataLayer
{
    public class User : UserIF
    {
        public string Address { get; set; }

        public string City { get; set;}

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string PostalCode { get; set; }

        public string State {get;set;}

        public int Id { get; }
        
        public IEnumerable CheckedOutItems { get; set; }

    }
}