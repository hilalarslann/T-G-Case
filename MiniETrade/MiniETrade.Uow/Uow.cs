using MiniETrade.Dal;
using MiniETrade.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniETrade.Uow
{
    public class Uow : IUow
    {
        Context _db;
        public Uow(Context db, IProductRep productRep, ICategoryRep categoryRep, ISubCategoryRep subCategoryRep)
        {
            _db = db;
            _ProductRep = productRep;
            _CategoryRep = categoryRep;
            _SubCategoryRep = subCategoryRep;
        }
        public IProductRep _ProductRep { get; private set; }
        public ICategoryRep _CategoryRep { get; private set; }
        public ISubCategoryRep _SubCategoryRep { get; private set; }

        public bool Commit()
        {
            return _db.SaveChanges() > 0;
        }
    }
}
