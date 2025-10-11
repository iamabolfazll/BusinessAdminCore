using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace ServiceContract
{
    public interface IProductService
    {
        public List<ProductDTO> GetAll();
        List<ProductDTO> GetByFilter(string SearchType, string? SearchText);
    }
}
