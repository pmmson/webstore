using System;
using System.Collections.Generic;
using System.Linq;
using WebStore.Models.Order;
using WebStore.Models.Product;

namespace WebStore.Models.Cart
{
    public class DetailsViewModel
    {
        public CartViewModel CartViewModel { get; set; }

        public OrderViewModel OrderViewModel { get; set; }

        public Dictionary<ProductViewModel, int> Items { get; set; }

        public int ItemsCount => Items?.Sum(x => x.Value) ?? 0;

    }

}
