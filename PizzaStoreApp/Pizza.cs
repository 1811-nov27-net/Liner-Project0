using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStoreApp
{
    public class Pizza
    {

        bool pepperoni;                     //pepporoni topping Y/N
        bool pineapples;                    //pinapple topping Y/N
        bool mushrooms;                     //mushroom topping Y/N
        public double price { get; set; }                       //total price of this pizza
        string size;                        //pizza size

        //prices for each pizza size
        Dictionary<string, double> sizeKey = new Dictionary<string, double>()
        {
            {"small", 5.00 },
            {"medium", 10.00},
            {"large", 15.00 }
        };                               

        //pizza constructor; defines the type of pizza being ordered
        public Pizza(bool pepperoni, bool pineapples, bool mushrooms, string size)
        {
            this.pepperoni = pepperoni;
            this.pineapples = pineapples;
            this.mushrooms = mushrooms;

            this.price = sizeKey[size];

            if (pepperoni)
                price += 0.50;
            if (pineapples)
                price += 0.50;
            if (mushrooms)
                price += 0.50;
            
        }
    }
}
