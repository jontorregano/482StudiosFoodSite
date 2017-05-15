using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodSiteMVC.Models
{
    public class Orders
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Item { get; set; }
        public decimal Price { get; set; }
        public DateTime Time { get; set; }
    }
}