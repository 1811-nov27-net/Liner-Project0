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
        public double price { get; set; }   //total price of this pizza

                           
        public string size (string size)    //sets the size of the pizza
        {
            if (size == "small")            //small size pizza
            {
                this.price = 5.00;
                return "small";                
            }

            else if (size == "medium")      //medium size pizza
            {
                this.price = 10.00;
                return "medium";
            }

            else if (size == "large")       //large size pizza
            {
                this.price = 15.00;
                return "large";
            }

            else                            //default to small size

            {                          
                this.price = 5.00;
                return "small";
            }
            
        }

        public void AddPepperoni(bool pepperoni)        //add pepperoni, increment price
        {
            this.pepperoni = pepperoni;
            this.price += 0.50;
        }

        public void AddPineapples(bool pineapples)      //add pineapples, increment price
        {
            this.pineapples = pineapples;
            this.price += 0.50;
        }

        public void AddMushrooms(bool mushrooms)        //add mushrooms, increment price
        {
            this.mushrooms = mushrooms;
            this.price += 0.50;
        }
    }
}
