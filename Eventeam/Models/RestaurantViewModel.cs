using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eventeam.Models
{
    public class RestaurantViewModel
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string ClassificationName { get; set; }
        public string KitchenName { get; set; }
        public int Banquet { get; set; }
        public int Buffet { get; set; }
        public int TotalSquare { get; set; }
        public int Seating { get; set; }
    }
}