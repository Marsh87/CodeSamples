using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.Models
{
    public class Hospital:Building
    {
        public List<Nurse> Nurses { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Departments> Department { get; set; }

        public override string GetDescription()
        {
            return base.GetDescription() + ":1234";
        }
    }
}
