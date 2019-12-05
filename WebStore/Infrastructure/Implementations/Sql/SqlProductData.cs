using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebStore.DAL.Context;
using WebStore.Domain.Entities;
using WebStore.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore.Query;

namespace WebStore.Infrastructure.Implementations.Sql
{
    public class SqlProductData : IProductData
    {
        private readonly WebStoreContext _context;

        public SqlProductData(WebStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.ToList();
        }

        public Product GetProductById(int id)
        {
            return _context
                .Products
                .Include(p => p.Brand)
                .Include(p => p.Section)
                .FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProducts(ProductFilter filter)
        {
            var query = _context
                .Products
                .Include(p => p.Brand)
                .Include(p => p.Section)
                .AsQueryable();

            if (filter.BrandId != null)
                query = query
                    .Where(c => c.BrandId == filter.BrandId);

            if (filter.SectionId != null)
                query = query
                    .Where(c => c.SectionId == filter.SectionId);

            return query.ToList();
        }

        public IEnumerable<Section> GetSections()
        {
            return _context.Sections.ToList();
        }
    }
}
