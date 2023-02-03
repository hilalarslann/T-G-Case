using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniETrade.DTO;
using MiniETrade.Entities.Concrete;
using MiniETrade.Uow;
using System.Net.Http;
using System.Text.Json;

namespace MiniETrade.Service.Controllers
{
    public class ProductController : BaseController
    {
        IUow _uow;
        public ProductController(IUow uow)
        {
            _uow = uow;
        }

        [HttpGet("{categoryId}")]
        public async Task<List<Product>> ListProduct(int categoryId)
        {
            //auto mapper 
            return await _uow._ProductRep.List(x=>x.CategoryId == categoryId);
        }

        [HttpGet("{categoryId}/{subCategoryId}")]
        public async Task<List<Product>> ListProduct(int categoryId,int subCategoryId)
        {
            return await _uow._ProductRep.List(x=>x.CategoryId == categoryId && x.SubCatId == subCategoryId);
        }
    }
}
