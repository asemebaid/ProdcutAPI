using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product_BAL.Repositories.ProductRep;
using Product_DAL.Dtos;

namespace CourseProduct_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductLogic _ProductLogic;

        public ProductController(IProductLogic _ProductLogic)
        {
            this._ProductLogic = _ProductLogic;
        }


        [HttpGet]
        [Route("GetAllProduct")]
        public ActionResult<IEnumerable<ProductDTO>> GetAllProduct()
        {
            var ProductList = _ProductLogic.GetProducts(); 
            return ProductList;
        }


        [HttpGet]
        [Route("GetProductById/{id}")]
        public ActionResult<ProductDTO> GetProductById(long id)
        {
            var Product = _ProductLogic.GetProductByProductId(id);
            if (Product == null)
            {
                return NotFound();
            }

            return Product;
        }
         

        [HttpPost]
        [Route("AddProduct")]
        public ActionResult AddProduct(ProductDTO AddProduct)
        {
            var stu = _ProductLogic.AddProduct(AddProduct);

            return Ok(stu);
        }


        [HttpPut]
        [Route("EditProduct")]
        public ActionResult<ProductDTO> EditProduct(ProductDTO Product)
        {
            var stu = _ProductLogic.EditProduct(Product);

            return Ok(stu);
        }

        [HttpDelete]
        [Route("DeleteProduct/{id}")]
        public ActionResult DeleteProduct(long id)
        {            
                _ProductLogic.DeleteProduct(id);
                return Ok();
        }

    }
}