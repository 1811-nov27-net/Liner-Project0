using ClassLibrary;
using System;

namespace PizzaStoreApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            OrderClass o1 = new OrderClass();
            StoreClass store = new StoreClass();
            store.locationID = 101;

            PizzaClass p1 = new PizzaClass();
            p1.size = "small";
            o1.AddToOrder(p1);


            o1.location = 01;
            o1.user = 201;
        }
    }
}
