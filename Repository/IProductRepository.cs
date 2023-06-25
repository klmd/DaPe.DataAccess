using DaPe.Models;

namespace DaPe.DataAccess.Repository;

public interface IProductRepository : IRepository<Product>
{
    void Update(Product obj);
}