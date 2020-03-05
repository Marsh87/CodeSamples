using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeSamples.Models;

namespace CodeSamples.Helpers
{
    // TODO this is good, however, let's do something that alters the
    //      enumerator behaviour, right now it just does what the
    //      underlying List's enumerator does.
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
