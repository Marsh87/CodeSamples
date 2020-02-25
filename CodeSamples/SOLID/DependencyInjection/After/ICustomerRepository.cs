using System.Collections.Generic;
using CodeSamples.SOLID.LiskovSubstitution.Models;

namespace CodeSamples.SOLID.DependencyInjection.After
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();
    }
}