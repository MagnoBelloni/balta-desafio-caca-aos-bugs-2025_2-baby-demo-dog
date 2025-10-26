using BugStore.Application.Customers.Requests;
using BugStore.Application.Customers.Responses;
using BugStore.Domain.Interfaces.Repositories;
using MediatR;

namespace BugStore.Application.Customers.Handlers
{
    public class GetCustomerByIdRequestHandler(ICustomerRepository customerRepository) : IRequestHandler<GetCustomerByIdRequest, GetCustomerByIdResponse>
    {
        public async Task<GetCustomerByIdResponse> Handle(GetCustomerByIdRequest request, CancellationToken cancellationToken)
        {
            var customer = await customerRepository.GetByIdAsNotrackingAsync(request.Id) 
                ?? throw new Exception("Usuário não encontrado");

            return GetCustomerByIdResponse.FromCustomer(customer);
        }
    }
}
