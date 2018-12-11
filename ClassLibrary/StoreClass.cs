using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class StoreClass
    {
        public int locationID { get; set; }                    //store location ID
        public int stock { get; set; }                         //inventory stock

        //history of orders placed to the location
        List<OrderClass> history = new List<OrderClass>();

        //return a suggested order based on user's history
        public OrderClass SuggestedOrder(UserClass user)
        {
            int i = (user.OrderHistory.Count) - 1;
            return user.OrderHistory[i];                //return the latest order the user has made
        }

        //add order to history
        public void PlaceOrder(OrderClass order)
        {
            if (this.stock >= order.pizzas)             //check if there's enough inventory to complete the order
            {
                reduceStock(order.pizzas);
                history.Add(order);
                order.orderTime = DateTime.Now;
            }

            else
            {
                Console.WriteLine("Not enough inventory to complete order");
            }
        }

        //subtract from inventory

        public void reduceStock(int x)                       //reduce stock by an amount dependent on order size
        {
            stock -= x;
        }


    }
}
