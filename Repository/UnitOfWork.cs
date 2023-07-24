using DaPe.DataAccess.Data;
using DaPe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DaPe.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }
        public IKindOfProductRepository TypeOfProduct { get; private set; }
        //public IApplicationUserRepository ApplicationUser{ get; private set; }
        public ICompanyRepository Company { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
            TypeOfProduct = new KindOfProductRepository(_db);
            Company = new CompanyRepository(_db);
        }
        
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
