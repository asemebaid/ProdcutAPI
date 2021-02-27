
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CourseProduct_DAL.ProductDBContext;
using Product_DAL.Dtos;
using Product_DAL.Models;

namespace Product_BAL.Repositories.ProductRep
{
    public class ProductLogic : IProductLogic
    {
      

        private readonly ProductContext _context;

        public ProductLogic(ProductContext context)
        {
            _context = context;
        }


        public List<ProductDTO> GetProducts()
        {


            var ProductList = (from stu in _context.Products
                  
             select new ProductDTO
             {
                 Id = stu.Id,
                 ProductCode = stu.ProductCode,
                 ProductTitle = stu.ProductTitle,
                 ProductQuantity = stu.ProductQuantity,
                
                 
             }).OrderBy(x => x.ProductTitle).ToList();

            return ProductList;

        }


        public List<ProductDTO> GetProductsByCourseId(long Id)
        {
            var ProductList = (from stu in _context.Products
                              
                               select new ProductDTO
                               {
                                   Id = stu.Id,
                                   ProductCode = stu.ProductCode,
                                   ProductTitle = stu.ProductTitle,
                                 
                               }).OrderBy(x => x.ProductTitle).ToList();


            return ProductList;

        }


        public ProductDTO GetProductByProductId(long Id)
        {
            var Product = (from stu in _context.Products
                               
                               select new ProductDTO
                               {
                                   Id = stu.Id,
                                   ProductCode = stu.ProductCode,
                                   ProductTitle = stu.ProductTitle,
                                   ProductQuantity = stu.ProductQuantity,
                                   

                               }).SingleOrDefault();

            return Product;
        }


        public ProductDTO AddProduct(ProductDTO stuObj)
        {
            var Product = new Product()
            {
                ProductCode = stuObj.ProductCode,
                ProductTitle = stuObj.ProductTitle,
                ProductQuantity = stuObj.ProductQuantity, 
            };

            _context.Products.Add(Product);
            _context.SaveChanges();

            return stuObj;
        }


        public ProductDTO EditProduct(ProductDTO stuObj)
        {
            Product stu = _context.Products.Find(stuObj.Id);

            if (stu != null)
            {
                stu.ProductCode = stuObj.ProductCode;
               
                stu.ProductTitle = stuObj.ProductTitle;              
               
            };

            _context.Products.Update(stu);
            _context.SaveChanges();

            return stuObj;
        }


        public bool DeleteProduct(long Id)
        {
            var stu = _context.Products.Find(Id);
            _context.Products.Remove(stu);
            _context.SaveChanges();
            return true;


        }

      
    }
}
