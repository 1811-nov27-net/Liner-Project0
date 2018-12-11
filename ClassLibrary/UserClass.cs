using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class UserClass
    {
        public int userID { get; set; }                         //customer ID number
        public int defaultLocation { get; set; }                //default location to order from
        public List<OrderClass> OrderHistory = new List<OrderClass>();    //user's order history 

        //make an order and add it to the user's history
        public void AddToHistory(OrderClass order)
        {
            OrderHistory.Add(order);
        }

        public string SuggestedOrder()
        {

            OrderClass orderSuggestion = new OrderClass();
            orderSuggestion = this.OrderHistory[this.OrderHistory.Count - 1];
            return orderSuggestion.ToString();
        }

        //check to see if an order has been made in the past 2 hours at the same location by the same user

        public bool CanOrder(StoreClass location)
        {
            for (int i = this.OrderHistory.Count - 1; i >= 0; i--)
            {
                if (this.OrderHistory[i].location == location.locationID)
                {
                    if (DateTime.Now.Subtract(this.OrderHistory[i].orderTime).TotalHours > 2)
                    {
                        return true;
                    }

                    else
                    { return false; }
                }
            }

            return false;
        }
    }
}
