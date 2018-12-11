using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class PizzaClass
    {

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

    }
}
