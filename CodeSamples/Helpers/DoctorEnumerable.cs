using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeSamples.Models;

namespace CodeSamples.Helpers
{
    public class DoctorEnumerable:IEnumerable
    {
        private readonly List<Doctor> _doctors;

        public DoctorEnumerable(List<Doctor> doctors)
        {
            _doctors = doctors;
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var doctor in _doctors)
            {
                yield return doctor.FirstName;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
