using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    interface IStoreRepo
    {
        void MakeOrder(OrderClass order);               //Making an order
        void GetSuggestion(UserClass user);             //Get a suggestion based on order history
        UserClass SearchUserByName(string name);        //Search for a user by their name
        //display order details                         //Display details for an order
        //display order history of a store location     //Display order history for store location
        //display order history for a user              //Display order history for a user

    }
}
