using Microsoft.AspNetCore.Mvc;
using MiniETrade.DTO;
using MiniETrade.Entities.Concrete;
using MiniETrade.Uow;

namespace MiniETrade.Service.Controllers
{
    public class CategoryController : BaseController
    {
        IUow _uow;
        public CategoryController(IUow uow)
        {
            _uow = uow;
        }


        [HttpGet]
        public async Task<List<Category>> GetAsync()
        {
            return await _uow._CategoryRep.List();
        }
    }
}
