﻿using System;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entities.Base.Interfaces;

namespace WebStore.Models.Product
{
    public class ProductViewModel : INamedEntity, IOrderedEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Order { get; set; }

        public string ImageUrl { get; set; }
        public decimal Price { get; set; }

    }
}
