﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeAPI.Domain.Common;

namespace TradeAPI.Domain.Entities
{
    public class Product:EntityBase
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required int BrandId { get; set; }
        public required decimal Discount { get; set; }
        public Brand Brand { get; set; } 
        public  ICollection<Category> Categories { get; set; }
        public decimal Price { get; set; }
    }
}
