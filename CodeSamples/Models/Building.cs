using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.Models
{
    public class Building
    {
        public  int Id { get; set; }
        public string Name { get; set; }
        public  string Description { get; set; }
        public  Address Address { get; set; }
        public IEnumerable<Room> Rooms { get; set; }

        public virtual string GetDescription()
        {
            return this.Description;
        }
    }
}
