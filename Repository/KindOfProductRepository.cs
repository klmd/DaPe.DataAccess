using DaPe.DataAccess.Data;
using DaPe.Models;

namespace DaPe.DataAccess.Repository;

public class KindOfProductRepository : Repository<KindOfProduct>, IKindOfProductRepository
{
    private ApplicationDbContext _db;
    public KindOfProductRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }
    public void Update(KindOfProduct obj)
    {
        _db.TypeOfProducts.Update(obj);
    }
}