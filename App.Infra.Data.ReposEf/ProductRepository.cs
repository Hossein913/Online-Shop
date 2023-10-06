using App.Domain.core;
using App.Domain.core.Datas.EfRipository;
using App.Domain.core.Dtos.ProductDto;
using App.Domain.core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.ReposEf
{
    public class ProductRepository : IProductRepository
    {

        private readonly Maktab97ShopDbContext _context;

        public ProductRepository(Maktab97ShopDbContext context)
        {
            _context = context;
        }

        public async Task<int> Create(ProductAddDto productAddDto)
        {
            Product product = new Product
            {
                Title = productAddDto.Title,
                CategoryId = productAddDto.CategoryId,
                CalculatedQty = productAddDto.CalculatedQty,
                
            };

            await _context.Products.AddAsync(product);
            var result = await _context.SaveChangesAsync();
            if (result != 0)
                return product.Id;

            return 0;
        }

        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            product.IsRemoved = true;
            int result = await _context.SaveChangesAsync();
            if (result != 0)
                return product.Id;

            return 0;
        }

        public async Task<List<ProductOutPutDto>> GetAll()
        {
            var productList = await _context.Products.AsNoTracking().Select(p => new ProductOutPutDto
            {
                 Id = p.Id,
                 Title = p.Title,
                 CategoryId = p.CategoryId,
                 CalculatedQty = p.CalculatedQty

            }).ToListAsync();
            return productList;
        }

        public async Task<ProductOutPutDto> GetById(int productId)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == productId);
            var ProductDto = new ProductOutPutDto
            {
                Id = product.Id,
                Title = product.Title,
                CategoryId = product.CategoryId,
                CalculatedQty = product.CalculatedQty

            };
            return ProductDto;


        }

        public async Task<int> Update(ProductEditDto productEditDto)
        {
            var product = await _context.Products.FindAsync(productEditDto.Id);

            product.Title = productEditDto.Title;
            product.CategoryId = productEditDto.CategoryId;
            product.CalculatedQty = productEditDto.CalculatedQty;
            
            int result = await _context.SaveChangesAsync();
            if (result != 0)
                return product.Id;

            return 0;
        }

    }
}
