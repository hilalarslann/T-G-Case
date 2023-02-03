using MiniETrade.Repository.Abstract;

namespace MiniETrade.Uow
{
    public interface IUow
    {
        IProductRep _ProductRep { get; }
        ICategoryRep _CategoryRep { get; }
        ISubCategoryRep _SubCategoryRep { get; }
        bool Commit();
    }
}