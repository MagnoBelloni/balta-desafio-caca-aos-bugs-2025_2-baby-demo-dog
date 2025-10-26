using BugStore.Application.Customers.Responses;
using BugStore.Domain.Models;
using MediatR;

namespace BugStore.Application.Customers.Requests;

public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime BirthDate { get; set; }

    public Customer ToCustomer()
    {
        return new Customer
        {
            Name = Name,
            Email = Email,
            Phone = Phone,
            BirthDate = BirthDate
        };
    }
}