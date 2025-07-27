using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;

namespace CustomerService;

interface ICustomerService
{
    List<Customer> Customers = new List<Customer>();
     Customer CreateCustomer(string name, int customerId);
}

public class Customer : ICustomerService
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Customer(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override Customer CreateCustomer(string name, int customerId)
    {
        Id = customerId;
        Name = name;
        return
    }
}


