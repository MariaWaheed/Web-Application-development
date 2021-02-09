using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace food_item_webproject_.Models
{
    public class FoodItem
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }
        public int Price { get; set; }
    }
}