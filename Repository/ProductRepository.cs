using DaPe.DataAccess.Data;
using DaPe.Models;

namespace DaPe.DataAccess.Repository;

public class ProductRepository : Repository<Product>, IProductRepository
{
    private ApplicationDbContext _db;
    public ProductRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }
    public void Update(Product obj)
    {
        //_db.Products.Update(obj); // aktualizuje vše
        var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
        if (objFromDb != null)
        {
            objFromDb.NameOfProduct = obj.NameOfProduct;
            objFromDb.Category = obj.Category;
            objFromDb.CategoryId = obj.CategoryId;
            objFromDb.DisplayProductNr = obj.DisplayProductNr;
            objFromDb.KindOfProduct = obj.KindOfProduct;
            objFromDb.KindOfProductId = obj.KindOfProductId;
            objFromDb.Description = obj.Description;
            if (obj.ImageUrl != null)
            {
                objFromDb.ImageUrl = obj.ImageUrl;
            }
        }

    }
}