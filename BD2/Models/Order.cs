using System;
using System.Collections.Generic;

namespace BD2.Models
{
    internal class Order
    {
        public int OrderID { get; set; }
        public DateTime Date { get; set; }
        public bool Completed { get; set; }
        public float TotalPrice { get; set; }
        public Customer CustomerID { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }

        public Order(int orderID, DateTime date, bool completed, float totalPrice, Customer customerID,
            ICollection<Vehicle> vehicles)
        {
            OrderID = orderID;
            Date = date;
            Completed = completed;
            TotalPrice = totalPrice;
            CustomerID = customerID;
            Vehicles = vehicles;
        }
    }
}