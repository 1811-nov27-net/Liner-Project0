using ClassLibrary;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;

namespace PizzaStoreApp
{
    public class Program
    {
        static DbContextOptions<PizzaStoreAppContext> options = null;


        static void Main(string[] args)
        {
            var connectionString = SecretConfiguration.ConnectionString;
            var optionsBuilder = new DbContextOptionsBuilder<PizzaStoreAppContext>();
            optionsBuilder.UseSqlServer(connectionString);
            options = optionsBuilder.Options;
            IStoreRepo repo;

            using (var db = new PizzaStoreAppContext(options))
            {
                repo = new StoreRepo(db);

                var store = new StoreClass(102);

                var kyles = new UserClass(203, 103);

                var order = new OrderClass();

                var pizza1 = new PizzaClass("large");
                order.AddToOrder(pizza1);

                var pizza2 = new PizzaClass("large");
                order.AddToOrder(pizza2);

                if (kyles.CanOrder(store))
                {
                    if (store.EnoughStock(order))
                    {
                        order.CompleteOrder(kyles, store);
                        store.PlaceOrder(order);
                        kyles.AddToHistory(order);

                        repo.MakeOrder(order);
                        Console.WriteLine(repo.OrderOverview(order));
                        repo.SaveChanges();
                    }

                    else
                    {
                        Console.WriteLine("There is not enough stock left to fill this order.");
                    }
                }

                else
                {
                    Console.WriteLine("You have ordered too recently and must wait to order again");
                }

                if (kyles.CanOrder(store))
                {
                    if (store.EnoughStock(order))
                    {
                        order.CompleteOrder(kyles, store);
                        store.PlaceOrder(order);
                        kyles.AddToHistory(order);

                        repo.MakeOrder(order);
                        Console.WriteLine(repo.OrderOverview(order));
                        repo.SaveChanges();
                    }

                    else
                    {
                        Console.WriteLine("There is not enough stock left to fill this order.");
                    }
                }

                else
                {
                    Console.WriteLine("You have ordered too recently and must wait to order again");
                }


            }

        }
    }
}
