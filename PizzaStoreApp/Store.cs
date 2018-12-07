using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStoreApp
{
    public class Store
    {
        public string locationID;                       //store location ID
        public int pepperoni = 100;                     //inventory of pepperoni    
        public int pineapples = 100;                    //inventory of pineapples
        public int mushrooms = 100;                     //inventory of mushrooms

        //history of orders placed to the location
        List<Order> history = new List<Order>();

        //return a suggested order based on user's history
        public Order SuggestedOrder(User user)
        {
            
        }

        public void AddToHistory(Order order)
        {
            history.Add(order);
        }

        //subtract pepperoni from inventory
        public void usePepperoni()
        {
            pepperoni -= 10;
        }

        //subtract pineapples from inventory
        public void usePineapples()
        {
            pineapples -= 10;
        }

        //subtract mushrooms from inventory
        public void useMushrooms()
        {
            mushrooms -= 10;
        }

    }
}
