using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace DataAccess
{
    class StoreRepo : IStoreRepo
    {
        public PizzaStoreAppContext Db { get; }

        public StoreRepo(PizzaStoreAppContext db)
        {
            Db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public void MakeOrder(OrderClass order)
        {
            OrderDetails trackedOrder = new OrderDetails();         //create a new order to be tracked in database

            trackedOrder.UserId = Db.Users.First(u => u.UserId == order.user).UserId;   //match customer ID with customer in database
            trackedOrder.Pizzas = order.pizzas;                                         //set number of pizzas in the order
            trackedOrder.LocationId = Db.Store.First(s => s.LocationId == order.location).LocationId;   //match location ID with ID in database
            trackedOrder.Price = order.price;                                           //set the price of the order
            trackedOrder.DatePlaced = order.orderTime;                                  //time of order being placed

            Db.OrderDetails.Add(trackedOrder);                                          //add the new tracked order
        }



    }
}
