using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaPe.DataAccess.Repository;


namespace DaPe.DataAccess.Repository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        IProductRepository Product { get; }
        IKindOfProductRepository TypeOfProduct { get; }
        ICompanyRepository Company { get; }
        //IApplicationUserRepository ApplicationUser { get; }
        void Save();
    }
}
