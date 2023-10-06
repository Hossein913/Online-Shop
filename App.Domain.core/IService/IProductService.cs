using App.Domain.core.Dtos.ProductDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.core.IService
{
    public interface IProductService
    {
        Task<int> CreateProduct(ProductAddDto product);
        Task<int> DeleteProduct(int productId);
        Task<int> EditProduct(ProductEditDto product);
        Task<List<ProductOutPutDto>> GetAllProducts();
        Task<ProductOutPutDto> GetById(int productId);
        //Task<ProductOutPutDto> GetProductsByCategoryId(int categoryId);
        //Task<ProductOutPutDto> SeachInProduct(string name);
    }
}
