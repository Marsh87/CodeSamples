using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.Models
{
    public class Employee
    {
        public int TitleId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth  { get; set; }
        public  int GenderId { get; set; }
    }
}
