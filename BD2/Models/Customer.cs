namespace BD2.Models
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public int? Phone { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Customer(int customerID, string name, int? phone, string address, string postalCode, string city,
            string country)
        {
            CustomerID = customerID;
            Name = name;
            Phone = phone;
            Address = address;
            PostalCode = postalCode;
            City = city;
            Country = country;
        }
    }
}