using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Product;

namespace Vending_Machine.VM
{
   public  interface IVending
    {
        
        int InsertMoney();
        string ShowAll();
        void Purchase();

        int EndTransaction();
    }
}
