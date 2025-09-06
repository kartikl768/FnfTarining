using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace contactapp.Models
{
    [Table("Contacts")]
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string PhoneNo { get; set; }
        public string Photo { get; set; }
    }
}
