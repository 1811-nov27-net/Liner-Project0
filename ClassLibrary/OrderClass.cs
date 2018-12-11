using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class OrderClass
    {

        public int location { get; set; }                //location ID of pizza shop
        public int user { get; set; }                    //user ID of person ordering
        public string firstName { get; set; }            //first name of user
        public string lastName { get; set; }             //last name of user
        public int pizzas = 0;                           //number of pizzas in the order; initialized to 0
        public DateTime orderTime { get; set; }          //time of order               



        public decimal price { get; set; }                   //total price of the order
        List<PizzaClass> PizzaList = new List<PizzaClass>();          //list of pizzas in the order

        //add a pizza to the order
        public void AddToOrder(PizzaClass pizza)
        {
            if (PizzaList.Count < 12 && this.price+pizza.price < 500.00m)
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

        //finalize order
        public void CompleteOrder(UserClass user, StoreClass store)
        {                        

            this.user = user.userID;
            this.location = store.locationID;
            this.orderTime = DateTime.Now;
        }

        //this string describes the order to the user


    }
}
