using Core.DataAccess.EntityFrameworkCore;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameworkCore.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFrameworkCore
{
    public class EfCoreCategoryDal : EfCoreEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {

    }
}