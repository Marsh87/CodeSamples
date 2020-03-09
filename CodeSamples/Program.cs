// TODO unused usings!
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CodeSamples.Helpers;
using CodeSamples.Models;
using CodeSamples.Services;

namespace CodeSamples
{
    // TODO things I couldn't find code or notes or diagrams for:
    //      - TCP/IP & HTTP 
    //      - Set theory
    //      - .NET basics 
    // TODO I'd like to go over with you in our next session which
    //      code is demoing inheritance & polymorphism because if it is
    //      the Employee/Doctor/Nurse it will need a bit of improvement
    class Program
    {
        public delegate void CalculateAmount(decimal value);
        static void Main(string[] args)
        {
           Bootstrap.Start();
            var hospital = CreateHospital();
            var buildingService = Bootstrap.Container.GetInstance<IBuldingService>();
            Console.WriteLine(buildingService.CreateBuilding(hospital));
            UpdateClaim<TddClaim> updateClaim = new UpdateClaim<TddClaim>(new TddClaim());
            Console.WriteLine(updateClaim.genericMethod());

            CalculateAmount calculatePremium = CalculatePremium;
            calculatePremium(200);

            CalculateAmount calculateRefund = CalculateRefund;
            calculateRefund(new decimal(190.02));

            DoSomethingWithDelegate(calculateRefund,1500);

            var buildings = buildingService.GetAllBuildings();
            DisplayBuildingName(buildings.GetEnumerator());

            var doctor = CreateDoctor();
            var doctorEnumerable = new DoctorEnumerable(new List<Doctor>() {doctor});
            DisplayDoctorName(doctorEnumerable.GetEnumerator());
            Console.ReadLine();

        }

        private static Doctor CreateDoctor()
        {
            var doctor = new Doctor()
            {
                DateOfBirth = new DateTime(1987, 7, 6),
                FirstName = "Mister",
                GenderId = 1,
                Surname = "Doctor",
                TitleId = 3
            };
            return doctor;
        }

        public static void DisplayBuildingName(IEnumerator<Building> buildingEnumerator)
        {
            while (buildingEnumerator.MoveNext())
            {
                var name = buildingEnumerator.Current?.Name;
                Console.WriteLine(name);
            }

        }
        public static void DisplayDoctorName(IEnumerator<string> buildingEnumerator)
        {
            while (buildingEnumerator.MoveNext())
            {
                var name = buildingEnumerator.Current;
                Console.WriteLine(name);
            }

        }

        public static void DoSomethingWithDelegate(CalculateAmount calculateAmount, decimal interest)
        {
            calculateAmount(interest);
        }

        public static void CalculatePremium(decimal premium)
        {
            Console.WriteLine("Number:{0,-12:N0}",premium);
        }
        public static void CalculateRefund(decimal refund)
        {
            Console.WriteLine("Number:{0,-12:N0}",refund);
        }

        private static Hospital CreateHospital()
        {
            return new Hospital()
            {
                Name = "Umhlatuzana Hospital",
                Description = "Some Hospital"
            };
        }
    }
}
