using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    class StoreRepo
    {
        public PizzaClass AddPizzaToOrder(string size)
        {
            PizzaClass pizza = new PizzaClass();
            pizza.size(size);
            return pizza;
        }

        public void MakeOrder(UserClass user, )
    }
}
