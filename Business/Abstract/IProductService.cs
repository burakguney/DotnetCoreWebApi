using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        IResult AddProduct(Product product);
        IResult UpdateProduct(Product product);
        IResult DeleteProduct(Product product);
        IDataResult<Product> GetProductByProductId(int productId);
        IDataResult<List<Product>> GetProductList();
        IDataResult<List<Product>> GetProductListByCategoryId(int categoryId);
    }
}