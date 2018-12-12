using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace DataAccess
{
    public class StoreRepo : IStoreRepo
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

        //converts user data from database tables into a C# object
        public UserClass UserConversion(Users user)
        {
            return new UserClass(user.UserId, user.DefaultLocation);
        }

        //make a list of object UserClass using library class as a blueprint
        public List<UserClass> UserList()
        {
            List<UserClass> list = new List<UserClass>();
            foreach(var user in Db.Users.ToList())
            {
                list.Add(UserConversion(user));
            }
            return list;
        }

        //converts store location data from database tables into a C# object
        public StoreClass StoreConversion(Store store)
        {
            return new StoreClass(store.LocationId);
        }

        //makes a list of object StoreClass using library class as a blueprint
        public List<StoreClass> StoreList()
        {
            List<StoreClass> list = new List<StoreClass>();
            foreach(var store in Db.Store.ToList())
            {
                list.Add(StoreConversion(store));
            }
            return list;
        }

        //give details of the order
        public string OrderOverview(OrderClass order)
        {
            string firstName = Db.Users.First(u => u.UserId == order.user).FirstName;
            string lastName = Db.Users.First(u => u.UserId == order.user).LastName;


            return "User Name: " + firstName + " " + lastName + ".\n" + "Pizzas: " + order.pizzas + ".\n" +
                "Store ID: " + order.location + ".\n" + "Price: " + order.price + ".\n" + "Time Placed: " + order.orderTime + ".\n";
        }

        /*public UserClass SearchUserByName(string name)
        {

        }*/

        public void SaveChanges()
        {
            Db.SaveChanges();
        }


    }
}
