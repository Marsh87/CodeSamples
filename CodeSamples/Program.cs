using System;
using System.Collections.Generic;
using CodeSamples.Helpers;
using CodeSamples.Models;
using CodeSamples.Services;

namespace CodeSamples
{
    // TODO things I couldn't find code or notes or diagrams for:
    //      - Set theory

    class Program
    {
        public delegate void CalculateAmount(decimal value);
        static void Main(string[] args)
        {
            Bootstrap.Start();
            var hospital = CreateHospital();
            var buildingService = Bootstrap.Container.GetInstance<IBuldingService>();

            foreach (var building in buildingService.GetAllBuildings())
            {
                Console.WriteLine(building.GetDescription());
            }

            Console.WriteLine(hospital.GetDescription());
            UpdateClaim<TddClaim> updateClaim = new UpdateClaim<TddClaim>(new TddClaim());
            Console.WriteLine(updateClaim.genericMethod());

            CalculateAmount calculatePremium = CalculatePremium;
            calculatePremium(200);

            CalculateAmount calculateRefund = CalculateRefund;
            calculateRefund(new decimal(190.02));

            DoSomethingWithDelegate(calculateRefund, 1500);

            var buildings = buildingService.GetAllBuildings();
            DisplayBuildingName(buildings.GetEnumerator());

            var doctor = CreateDoctor();
            var nurse = CreateNurse();
            var doctorEnumerable = new DoctorEnumerable(new List<Doctor>() { doctor });
            DisplayNames(doctorEnumerable.GetEnumerator());

            var employees = CreateEmployees(doctor, nurse);
            var employeeEnumerable = new EmployeeEnumerable(employees);
            DisplayNames(employeeEnumerable.GetEnumerator());
            Console.ReadLine();
        }

        private static List<Employee> CreateEmployees(Doctor doctor, Nurse nurse) => new List<Employee>() {doctor,nurse};

        private static Nurse CreateNurse()
        {
            var nurse = new Nurse()
            {
                FirstName = "Mary",
                Surname = "Elize"
            };
            return nurse;
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
        public static void DisplayNames(IEnumerator<string> nameEnumerator)
        {
            while (nameEnumerator.MoveNext())
            {
                var name = nameEnumerator.Current;
                Console.WriteLine(name);
            }

        }

        public static void DoSomethingWithDelegate(CalculateAmount calculateAmount, decimal interest)
        {
            calculateAmount(interest);
        }

        public static void CalculatePremium(decimal premium)
        {
            Console.WriteLine("Number:{0,-12:N0}", premium);
        }
        public static void CalculateRefund(decimal refund)
        {
            Console.WriteLine("Number:{0,-12:N0}", refund);
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
