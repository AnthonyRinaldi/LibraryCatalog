using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace LibraryCatalog.DataLayer
{
    public interface UserIF
    {
        [Key]
        int Id { get; }
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string State { get; set; }
        string PostalCode { get; set; }
        IEnumerable CheckedOutItems { get; set; }
    }
}
