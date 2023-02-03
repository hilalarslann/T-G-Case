using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniETrade.Entities.Concrete
{
    public class Product : BaseEntity
    {
        public decimal UnitPrice { get; set; }
        public int Amount { get; set; }
        public int SubCatId { get; set; }
        public string Img { get; set; }

        [ForeignKey("SubCatId")]
        public SubCategory SubCategory { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category SubCategoryCategory { get; set; }
        
    }
}
