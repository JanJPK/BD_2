using System.ComponentModel.DataAnnotations;

namespace BD2.Models
{
    internal class Customer
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public int? Phone { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Country { get; set; }

        public Customer(int id, string name, int? phone, string address, string postalCode, string city,
            string country)
        {
            ID = id;
            Name = name;
            Phone = phone;
            Address = address;
            PostalCode = postalCode;
            City = city;
            Country = country;
        }
    }
}