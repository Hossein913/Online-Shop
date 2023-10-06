using App.Domain.core.Dtos.ProductDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.core.IAppService
{
    public interface IProductAppService
    {
        Task<string> CreateProduct(ProductAddDto product);
        Task<string> DeleteProduct(int productId);
        Task<string> EditProduct(ProductEditDto product);
        Task<List<ProductOutPutDto>> GetAllProducts();
        Task<ProductOutPutDto> GetById(int productId);
        //Task<ProductOutPutDto> GetProductsByCategoryId(int categoryId);
        //Task<ProductOutPutDto> SeachInProduct(string name);
    }
}
