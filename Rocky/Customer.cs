using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocky
{
    public class Customer
    {
        public string GreetMessage { get; set; }
        public Double Discount { get; set; } = 15.0;

        public void GreetAndCombineNames(string firstName, string lastName)
        {
            GreetMessage = $"Hi {firstName} {lastName}";
            Discount = 20.0;
        }
    }
}
