using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTypeCSharpExample.Models
{
    public class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CellNumber {get;set;}

        public Customer(string firstName, string LastName, string cellNumber)
        {
            this.FirstName = firstName;
            this.LastName = LastName;
            this.CellNumber = cellNumber;
        }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
