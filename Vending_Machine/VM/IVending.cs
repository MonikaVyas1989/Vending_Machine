using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Product;

namespace Vending_Machine.VM
{
   public  interface IVending
    {
        bool InsertMoney(int moneyToAdd);
        int InsertMoney();
        string ShowAll();
        void Purchase();
        public bool Purchase(Product.Product product);
        int EndTransaction();
    }
}
