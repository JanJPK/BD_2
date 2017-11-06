namespace BD2.Models
{
    internal class Manufacturer
    {
        public int ManufacturerID { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }

        public Manufacturer(int manufacturerID, string shortName, string fullName, string country)
        {
            ManufacturerID = manufacturerID;
            ShortName = shortName;
            FullName = fullName;
            Country = country;
        }
    }
}