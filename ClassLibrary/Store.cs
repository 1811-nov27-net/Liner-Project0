using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStoreApp
{
    public class Store
    {
        public int locationID;                       //store location ID
        public int stock = 20;                          //inventory stock

        //history of orders placed to the location
        List<Order> history = new List<Order>();

        //return a suggested order based on user's history
        public Order SuggestedOrder(User user)
        {
            int i = (user.OrderHistory.Count) - 1;
            return user.OrderHistory[i];                //return the latest order the user has made
        }

        //add order to history
        public void AddToHistory(Order order)
        {
            history.Add(order);
        }

        //subtract from inventory

        public void reduceStock()
        {
            stock -= 1;
        }


    }
}
