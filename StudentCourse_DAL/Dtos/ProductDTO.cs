using System;
using System.Collections.Generic;
using System.Text;

namespace Product_DAL.Dtos
{
    public class ProductDTO
    {
        public long Id { get; set; }
        public string ProductTitle { get; set; } 
        public string ProductCode { get; set; }
        public int ProductQuantity { get; set; }

        public DateTime? CreationDate { get; set; } = DateTime.Now;

    }
}
