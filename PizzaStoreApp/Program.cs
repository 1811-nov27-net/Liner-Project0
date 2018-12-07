using System;

namespace PizzaStoreApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pizza testpizza = new Pizza(true, false, false, "small");

            Pizza test2 = new Pizza(false, false, false, "large");

            Order testorder = new Order();

            testorder.AddToOrder(testpizza);
            testorder.AddToOrder(test2);

            Console.WriteLine(testorder.price);
        }
    }
}
