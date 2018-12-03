using System;

namespace PizzaStoreApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pizza testpizza = new Pizza(true, false, false, "small");
            Console.WriteLine(testpizza.price);
        }
    }
}
