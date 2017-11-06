namespace BD2.Models
{
    internal class VehicleModel
    {
        public int VehicleModelID { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string MainArmament { get; set; }
        public string SecondaryArmament { get; set; }
        public int Crew { get; set; }
        public float Weight { get; set; }
        public string Engine { get; set; }
        public int EnginePower { get; set; }
        public Manufacturer ManufacturerID { get; set; }

        public VehicleModel(int vehicleModelID, string name, string imagePath, string mainArmament,
            string secondaryArmament, int crew, float weight, string engine, int enginePower,
            Manufacturer manufacturerID)
        {
            VehicleModelID = vehicleModelID;
            Name = name;
            ImagePath = imagePath;
            MainArmament = mainArmament;
            SecondaryArmament = secondaryArmament;
            Crew = crew;
            Weight = weight;
            Engine = engine;
            EnginePower = enginePower;
            ManufacturerID = manufacturerID;
        }
    }
}