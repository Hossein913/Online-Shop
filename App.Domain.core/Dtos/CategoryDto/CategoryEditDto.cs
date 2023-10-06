namespace App.Domain.core.Dtos.CategoryDto
{
    public class CategoryEditDto
    {
        public int Id { get; set; }

        public string? Title { get; set; }


        public int? ParentId { get; set; }

        public bool? HasProducts { get; set; }
    }
}
