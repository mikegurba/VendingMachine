using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendingMachine.Models
{
    public class VendingInventory
    {
        public List<Coin> Coins { get; set; }
        public List<Product> Products { get; set;  }
    }
}