using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CodeSamples.Models;
using CodeSamples.Services;

namespace CodeSamples
{
    class Program
    {
        public delegate void CalculateAmount(decimal value);
        static void Main(string[] args)
        {
           Bootstrap.Start();
            var hospital = CreateHospital();
            var buildingService = Bootstrap.Container.GetInstance<IBuldingService>();
            buildingService.CreateBuilding(hospital);
            UpdateClaim<TddClaim> updateClaim = new UpdateClaim<TddClaim>(new TddClaim());
            updateClaim.genericMethod();

            CalculateAmount calculatePremium = CalculatePremium;
            calculatePremium(200);

            CalculateAmount calculateRefund = CalculateRefund;
            calculateRefund(new decimal(190.02));

            DoSomethingWithDelegate(calculateRefund,1500);
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
