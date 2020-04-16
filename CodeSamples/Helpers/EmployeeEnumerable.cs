using CodeSamples.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.Helpers
{
    public class EmployeeEnumerable : IEnumerable
    {
        private readonly List<Employee> _employees;

        public EmployeeEnumerable(List<Employee> employees)
        {
            _employees = employees;
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var employee in _employees)
            {
                yield return employee.FirstName;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
