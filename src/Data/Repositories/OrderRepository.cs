using BugStore.Domain.Interfaces.Repositories;
using BugStore.Domain.Models;

namespace BugStore.Data.Repositories
{
    public class OrderRepository(AppDbContext context) : BaseRepository<Order>(context), IOrderRepository;
}
