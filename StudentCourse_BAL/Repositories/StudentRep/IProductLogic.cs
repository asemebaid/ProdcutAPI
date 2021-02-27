using Product_DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product_BAL.Repositories.ProductRep
{
    public interface IProductLogic
    {
        List<ProductDTO> GetProducts();
        List<ProductDTO> GetProductsByCourseId(long Id);
        ProductDTO GetProductByProductId(long Id);
        ProductDTO AddProduct(ProductDTO empObj);
        ProductDTO EditProduct(ProductDTO empObj);
        bool DeleteProduct(long Id);
    }
}
