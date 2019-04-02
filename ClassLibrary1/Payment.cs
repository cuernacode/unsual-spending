using System;
using System.Collections.Generic;
using System.Text;

namespace UnusualSpending.Classes
{
    public class Payment
    {
        public double Price { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
    }
}
