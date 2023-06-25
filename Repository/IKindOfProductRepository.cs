using DaPe.Models;

namespace DaPe.DataAccess.Repository;

public interface IKindOfProductRepository : IRepository<KindOfProduct>
{
    void Update(KindOfProduct obj);
}