using System;
using System.Collections;

namespace HashTreeDataStructure
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
         
            ht.Add("001", "Mahesh Moodley");
            ht.Add("002", "Max Verstappen");
            ht.Add("003", "Christian Horner");
            ht.Add("004", "Toto Wolf");
            ht.Add("005", "Sergio Perez");
            ht.Add("006", "Lewis Hamilton");
            ht.Add("007", "Valtteri Bottas");
         
            if (ht.ContainsValue("Carlos Sainz")) {
                Console.WriteLine("This student name is already in the list");
            } else {
                ht.Add("008", "Carlos Sainz");
            }
            
            if (ht.ContainsValue("Christian Horner")) {
                Console.WriteLine("This student name is already in the list");
            } else {
                ht.Add("009", "Christian Horner");
            }
         
            // Get a collection of the keys.
            ICollection key = ht.Keys;
         
            foreach (string k in key) {
                Console.WriteLine(k + ": " + ht[k]);
            }
            Console.ReadKey();
        }
    }
}