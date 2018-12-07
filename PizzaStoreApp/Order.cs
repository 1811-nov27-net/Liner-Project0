using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStoreApp
{
    public class Order
    {

        public string location { get; set; }                //location ID of pizza shop
        public string user { get; set; }                    //name of customer/user
        DateTime orderTime { get; set; }                    //time of order               



        public double price { get; set; }                   //total price of the order
        List<Pizza> PizzaList = new List<Pizza>();          //list of pizzas in the order

        //add a pizza to the order
        public void AddToOrder(Pizza pizza)
        {
            if (PizzaList.Count < 12 && this.price+pizza.price < 500.00)
            {
                this.price += pizza.price;
                PizzaList.Add(pizza);
            }

            else
            {
                Console.WriteLine("Your order is full");
            }

        }

    }
}
