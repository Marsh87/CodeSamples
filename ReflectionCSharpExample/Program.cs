using System;
using System.Reflection;
using ReflectionCSharpExample.Models;

namespace ReflectionCSharpExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var type1 = car.GetType();
            Console.WriteLine(type1.FullName);

            Type type2 = Type.GetType("Reflection.Car", false, true);
            if (type2 is not null) Console.WriteLine(type2.FullName);

            Type type3 = typeof(Car);
            Console.WriteLine(type3.FullName);
            Console.WriteLine(type3.Name);
            Console.WriteLine(type3.Namespace);

            Type baseType = type3.BaseType;
            if (baseType is not null) Console.WriteLine(baseType.Name);

            Console.WriteLine(type3.IsAbstract);
            Console.WriteLine(type3.IsArray);
            Console.WriteLine(type3.IsClass);
            Console.WriteLine(type3.IsCOMObject);

            var memberInfo = type3.GetMembers();

            foreach (MemberInfo member in memberInfo)
            {
                Console.WriteLine(member.DeclaringType + " " +
                                  member.MemberType + "  " + member.Name);
            }

            Console.ReadLine();
        }
    }
}