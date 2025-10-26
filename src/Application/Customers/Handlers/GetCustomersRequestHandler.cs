using BugStore.Application.Customers.Requests;
using BugStore.Application.Customers.Responses;
using BugStore.Domain.Interfaces.Repositories;
using MediatR;

namespace BugStore.Application.Customers.Handlers
{
    public class GetCustomersRequestHandler(ICustomerRepository customerRepository) : IRequestHandler<GetCustomersRequest, GetCustomersResponse>
    {
        public async Task<GetCustomersResponse> Handle(GetCustomersRequest request, CancellationToken cancellationToken)
        {
            var customers = await customerRepository.GetAllAsync();
            return GetCustomersResponse.FromCustomer(customers);
        }
    }
}
