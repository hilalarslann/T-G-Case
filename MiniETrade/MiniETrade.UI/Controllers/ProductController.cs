using Microsoft.AspNetCore.Mvc;

namespace MiniETrade.UI.Controllers
{
    public class ProductController : Controller
    {
        // Product/1 --> CategoryID'si 1 olan kayıtları getirir
        [HttpGet("/{categoryId}")]
        public IActionResult Index(int categoryId)
        {
            return View();
        }

        //Product/1/1 --> CategoryId=1 ve SubCat=1

        [HttpGet("/{categoryId}/{subCategoryId}")]
        public IActionResult Index(int categoryId,int subCategoryId)
        {
            return View();
        }
    }
}
