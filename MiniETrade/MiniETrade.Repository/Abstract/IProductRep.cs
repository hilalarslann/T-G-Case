using MiniETrade.Core;
using MiniETrade.DTO;
using MiniETrade.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniETrade.Repository.Abstract
{
    public interface IProductRep : IBaseRepository<Product>
    {
        Task<List<ProductDTO>> ListProduct();
    }
}
