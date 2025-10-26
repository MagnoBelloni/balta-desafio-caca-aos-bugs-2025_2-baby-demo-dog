using BugStore.Domain.Interfaces.Repositories;
using BugStore.Domain.Models;

namespace BugStore.Data.Repositories
{
    public class CustomerRepository(AppDbContext context) : BaseRepository<Customer>(context), ICustomerRepository;
}
