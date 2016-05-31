using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog.DataLayer
{
    interface ItemIF
    {
        [Key]
        int Id { get; set; }
        string Title { get; set; }
    }
}
