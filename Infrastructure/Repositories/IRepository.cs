using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNFarm.Infrastructure.Repositories
{
    public interface IRepository<T> where T : class
    {
        T Find(int id);
        
    }
}
