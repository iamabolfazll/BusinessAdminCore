using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceContract;
using DTO;

namespace Service
{
    public class ProductService : IProductService
    {
        private readonly List<ProductDTO> _product;
        public ProductService()
        {
            _product = new List<ProductDTO>();
            _product.Add(new ProductDTO { Id = 221, Name = "کتاب", Description = "کتاب زن روز", Price = 220000 });
            _product.Add(new ProductDTO { Id = 221, Name = "کتاب", Description = "کتاب عشق", Price = 330000 });
            _product.Add(new ProductDTO { Id = 221, Name = "کتاب", Description = "کتاب حافظ", Price = 550000 });
            _product.Add(new ProductDTO { Id = 221, Name = "کتاب", Description = "کتاب مولانا", Price = 666000 });

        }
        public List<ProductDTO> GetAll()
        {
            return _product;
        }

        public List<ProductDTO> GetByFilter(string SearchType, string? SearchText)
        {
            var result = _product;
            if (string.IsNullOrEmpty(SearchText) || string.IsNullOrEmpty(SearchType))
            {
                return result;
            }
            if (SearchType.Equals("Name"))
            {
                result = result.Where(x => x.Name.Contains(SearchText)).ToList();
            }
            if (SearchType.Equals("Description"))
            {
                result = result.Where(x => x.Description.Contains(SearchText)).ToList();
            }

            return result;

        }
    }
}
