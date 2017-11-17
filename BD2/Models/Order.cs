using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BD2.Models
{
    internal class Order
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public bool Completed { get; set; }

        [Required]
        public float TotalPrice { get; set; }

        [Required]
        public Customer Customer { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }

        public Order(int id, DateTime date, bool completed, float totalPrice, Customer customer,
            ICollection<Vehicle> vehicles)
        {
            ID = id;
            Date = date;
            Completed = completed;
            TotalPrice = totalPrice;
            Customer = customer;
            Vehicles = vehicles;
        }
    }
}