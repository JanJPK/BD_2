using System;
using System.ComponentModel.DataAnnotations;

namespace BD2.Models
{
    internal class Vehicle
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public DateTime DateOfManufacture { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public string Filename { get; set; }

        public string Condition { get; set; }

        [Required]
        [StringLength(30)]
        public string Color { get; set; }

        public Order Order { get; set; }

        [Required]
        public VehicleModel VehicleModel { get; set; }

        public Vehicle(int iD, DateTime dateOfManufacture, float price, string filename, string condition, string color,
            Order order, VehicleModel vehicleModel)
        {
            ID = iD;
            DateOfManufacture = dateOfManufacture;
            Price = price;
            Filename = filename;
            Condition = condition;
            Color = color;
            Order = order;
            VehicleModel = vehicleModel;
        }
    }
}