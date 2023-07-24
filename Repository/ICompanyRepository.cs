using DaPe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaPe.DataAccess.Repository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company obj);        
    }
}
