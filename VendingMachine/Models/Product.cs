using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendingMachine.Models
{

    public enum Types { Cola = 100, Chips = 50, Candy = 65 };
    public class Product
    {
        public Types type { get; set; }
    }
}