using App.Domain.core.Datas.EfRipository;
using App.Domain.core.Dtos.ProductDto;
using App.Domain.core.Entities;
using App.Domain.core.IAppService;
using App.Domain.core.IService;

namespace App.Domain.AppServices
{
    public class ProductAppService : IProductAppService
    {
        private readonly IProductService productservice;
        public ProductAppService(IProductService productservice)
        {
            this.productservice = productservice;
        }

        public async Task<string> CreateProduct(ProductAddDto product)
        {
            int result = await productservice.CreateProduct(product);
            if (result == 1)
                return $"product with titleid = {product.Title} created successfuly";
            else
                return $"cant create product with titleid = {product.Title}";
        }

        public async Task<string> DeleteProduct(int productId)
        {
            int result = await productservice.DeleteProduct(productId);
            if (result == 1)
                return $"product with id = {productId} deleted successfuly";
            else
                return $"product with id = {productId} not found";
        }

        public async Task<string> EditProduct(ProductEditDto product)
        {
            int result = await productservice.EditProduct(product);
            if (result == 1)
                return $"product with id = {product.Id} edited successfuly";
            else
                return $"product with id = {product.Id} not edited";
        }

        public async Task<List<ProductOutPutDto>> GetAllProducts()
        {
            var result = await productservice.GetAllProducts();
            return result;
        }

        public async Task<ProductOutPutDto> GetById(int productId)
        {
            var result = await productservice.GetById(productId);
            return result;
        }
    }
}