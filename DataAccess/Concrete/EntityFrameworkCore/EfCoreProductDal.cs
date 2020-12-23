using Core.DataAccess.EntityFrameworkCore;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameworkCore.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFrameworkCore
{
    public class EfCoreProductDal : EfCoreEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {

    }
}