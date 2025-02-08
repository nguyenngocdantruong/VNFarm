using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNFarm.Core.Models;
using VNFarm.Infrastructure.Context;

namespace VNFarm.Infrastructure.Repositories
{
    internal class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(VNFarmContext context) : base(context)
        {
        }
        public async override Task<bool> Update(Product entity)
        {
            var old = await this.First(p => p.Id == entity.Id);
            if (old != null) 
            {
                old.Name = entity.Name;
                old.Price1 = entity.Price1;
                old.Price2 = entity.Price2;
                old.Quantity = entity.Quantity;
                old.Unit = entity.Unit;
                old.Description = entity.Description;
                old.ImageUrl = entity.ImageUrl;
                old.ReviewAverage = entity.ReviewAverage;
                old.ReviewCount = entity.ReviewCount;
                old.IsActive = entity.IsActive;
                old.UpdatedAt = DateTime.Now;
                await Save();
                return true;
            }
            return false;
        }
    }
}
