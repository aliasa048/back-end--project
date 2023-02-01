﻿using Juan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.ViewModels
{
    public class ProductDetailVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string MainImage { get; set; }
        public string CategoryName { get; set; }
        public string ProductSize { get; set; }
        public string ProductColor { get; set; }
        public IEnumerable<ProductImage> ProductImages { get; set; }
        public int ProductDiscount { get; set; }
        public IEnumerable<Social> socials { get; set; }
        public IEnumerable<Products> ProductsSlid { get; set; }

    }
}
