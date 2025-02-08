using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNFarm.Core.Models;
using VNFarm.Infrastructure.Context;

namespace VNFarm.Infrastructure.Repositories
{
    internal class OrderRepository : BaseRepository<Order>
    {
        public OrderRepository(VNFarmContext context) : base(context)
        {

        }
        public override async Task<bool> Update(Order entity)
        {
            var old = await this.First(p => p.Id == entity.Id);
            if (old != null)
            {
                old.Status = entity.Status;
                await Save();
                return true;
            }
            return false;
        }
    }
}
