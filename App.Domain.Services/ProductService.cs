using App.Domain.core.Datas.EfRipository;
using App.Domain.core.Dtos.ProductDto;
using App.Domain.core.Entities;
using App.Domain.core.IService;

namespace App.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<int> CreateProduct(ProductAddDto product)
        {
            int result = await productRepository.Create(product);
            return result;
        }

        public async Task<int> DeleteProduct(int productId)
        {
            int result = await productRepository.Delete(productId);
            return result;
        }

        public async Task<int> EditProduct(ProductEditDto product)
        {
            int result = await productRepository.Update(product);
            return result;
        }

        public async Task<List<ProductOutPutDto>> GetAllProducts()
        {
            var result = await productRepository.GetAll();
            return result;
        }

        public async Task<ProductOutPutDto> GetById(int productId)
        {
            var result = await productRepository.GetById(productId);
            return result;
        }
    }
}