using Microsoft.AspNetCore.Mvc;
using MiniETrade.Entities.Concrete;
using MiniETrade.Uow;

namespace MiniETrade.Service.Controllers
{
    public class SubCategoryController : BaseController
    {
        IUow _uow;
        public SubCategoryController(IUow uow)
        {
            _uow = uow;
        }
        
        [HttpGet("{id}")]
        public async Task<List<SubCategory>> GetAsync([FromRoute] int id)
        {
            return await _uow._SubCategoryRep.List(x=>x.CategoryId == id);
        }
    }
}
