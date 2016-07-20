using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendingMachine.Models
{
    public enum MetalContent { Bronze, Silver, Gold }
    public class Coin    {
        
        public MetalContent metalContent { get; set; }
    }
}