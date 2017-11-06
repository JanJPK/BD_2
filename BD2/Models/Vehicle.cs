using System;

namespace BD2.Models
{
    internal class Vehicle
    {
        public int VehicleID { get; set; }
        public DateTime DateOfManufacture { get; set; }
        public float Price { get; set; }
        public string Condition { get; set; }
        public string Color { get; set; }
        public Order OrderID { get; set; }
        public VehicleModel VehicleModelID { get; set; }

        public Vehicle(int vehicleID, DateTime dateOfManufacture, float price, string condition, string color)
        {
            VehicleID = vehicleID;
            DateOfManufacture = dateOfManufacture;
            Price = price;
            Condition = condition;
            Color = color;
        }
    }
}