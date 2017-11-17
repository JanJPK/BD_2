using System.ComponentModel.DataAnnotations;

namespace BD2.Models
{
    internal class Manufacturer
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string ShortName { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [Required]
        [StringLength(20)]
        public string Country { get; set; }

        public Manufacturer(int id, string shortName, string fullName, string country)
        {
            ID = id;
            ShortName = shortName;
            FullName = fullName;
            Country = country;
        }
    }
}