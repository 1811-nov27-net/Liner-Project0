using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class UserClass
    {
        public string firstName { get; set; }                   //customer's first name 
        public string lastName { get; set; }                    //customer's last name
        public int userID { get; set; }                         //customer ID number
        public int defaultLocation { get; set; }                //default location to order from
        public List<OrderClass> OrderHistory = new List<OrderClass>();    //user's order history 

        public void AddToHistory(OrderClass order)
        {
            OrderHistory.Add(order);
        }

        //make an order and add it to the user's history
        /*public void MakeOrder(Order order, string location)
        {
            //check to see if an order has been made in the past 2 hours
            for(int i=OrderHistory.Count-1; i<0; i--)
            {
                if(OrderHistory[i].location == location)
                {

                }
            }
            OrderHistory.Add(order);
        }*/

       

    }
}
