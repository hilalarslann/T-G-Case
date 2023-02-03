using MiniETrade.Core;
using MiniETrade.Dal;
using MiniETrade.DTO;
using MiniETrade.Entities.Concrete;
using MiniETrade.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MiniETrade.Repository.Concrete
{
    public class ProductRep<T> : BaseRepository<Product>, IProductRep where T : class
    {
        public ProductRep(Context db) : base(db)
        {

        }

        public async Task<List<ProductDTO>> ListProduct()
        {
            var product = await Set().Select(x => new ProductDTO
            {
                Id = x.Id,
                Name = x.Name,
                Img = x.Img,
                Price = x.UnitPrice,
            }).ToListAsync();

            return product;
        }
    }
}
