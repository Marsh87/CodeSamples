using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.Models
{
    public class UpdateClaim<T> where T : class
    {
        private T genericMemberVariable;

        public UpdateClaim(T value)
        {
            genericMemberVariable = value;
        }

        // TODO please give this a better name, perhaps Execute
        public T Execute()
        {
            Console.WriteLine("Return type:{0}, value {1}", typeof(T).ToString(),genericMemberVariable);
            return genericMemberVariable;
        }
    }
}
