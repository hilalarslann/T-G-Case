using MiniETrade.Core;
using MiniETrade.Dal;
using MiniETrade.Entities.Concrete;
using MiniETrade.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniETrade.Repository.Concrete
{
    public class SubCategoryRep<T> : BaseRepository<SubCategory>, ISubCategoryRep where T : class
    {
        public SubCategoryRep(Context db) : base(db)
        {

        }
    }
}
