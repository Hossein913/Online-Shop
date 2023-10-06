using App.Domain.core.Entities;

namespace App.Domain.core.Dtos.CategoryDto
{
    public class CategoryWithProductOutputDto
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public int? ParentId { get; set; }

        public bool? HasProducts { get; set; }

        public IList<Product>? Products { get; set; }
    }
}

