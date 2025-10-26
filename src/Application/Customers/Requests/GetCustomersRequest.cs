using BugStore.Application.Customers.Responses;
using MediatR;

namespace BugStore.Application.Customers.Requests;

public class GetCustomersRequest : IRequest<GetCustomersResponse>;