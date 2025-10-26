using BugStore.Domain.Interfaces.Repositories;
using BugStore.Domain.Models;

namespace BugStore.Data.Repositories
{
    public class ProductRepository(AppDbContext context) : BaseRepository<Product>(context), IProductRepository;
}
