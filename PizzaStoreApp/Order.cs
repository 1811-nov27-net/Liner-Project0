using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStoreApp
{
    public class Order
    {

        public string location { get; set; }                //location of pizza shop
        public string user { get; set; }                    //name of customer/user
        DateTime orderTime;                                 //time of order
        
        List<Pizza> pizzas = new List<Pizza>();             //list of pizzas in the order

        double price;                                       //total price of the order



    }
}
