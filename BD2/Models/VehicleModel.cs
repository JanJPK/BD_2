using System.ComponentModel.DataAnnotations;

namespace BD2.Models
{
    internal class VehicleModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        public string MainArmament { get; set; }

        [StringLength(30)]
        public string SecondaryArmament { get; set; }

        [Required]
        public int Crew { get; set; }

        [Required]
        public float Weight { get; set; }

        [Required]
        [StringLength(20)]
        public string Engine { get; set; }

        [Required]
        public int EnginePower { get; set; }

        [Required]
        public Manufacturer Manufacturer { get; set; }

        public VehicleModel(int id, string name, string mainArmament,
            string secondaryArmament, int crew, float weight, string engine, int enginePower,
            Manufacturer manufacturer)
        {
            ID = id;
            Name = name;
            MainArmament = mainArmament;
            SecondaryArmament = secondaryArmament;
            Crew = crew;
            Weight = weight;
            Engine = engine;
            EnginePower = enginePower;
            Manufacturer = manufacturer;
        }
    }
}