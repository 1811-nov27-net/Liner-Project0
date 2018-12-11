using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class OrderClass
    {

        public int location { get; set; }                //location ID of pizza shop
        public int user { get; set; }                    //user ID of person ordering
        public int pizzas = 0;                              //number of pizzas in the order; initialized to 0
        DateTime orderTime { get; set; }                    //time of order               



        public double price { get; set; }                   //total price of the order
        List<PizzaClass> PizzaList = new List<PizzaClass>();          //list of pizzas in the order

        //add a pizza to the order
        public void AddToOrder(PizzaClass pizza)
        {
            if (PizzaList.Count < 12 && this.price+pizza.price < 500.00)
            {
                this.price += pizza.price;
                PizzaList.Add(pizza);
                this.pizzas += 1;
            }

            else
            {
                Console.WriteLine("Your order is full");
            }

        }

    }
}
