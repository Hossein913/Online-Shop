namespace App.Domain.core.Dtos.CategoryDto
{
    public class CategoryAddDto
    {
        public string Title { get; set; }

        public int? ParentId { get; set; }

        public bool? HasProducts { get; set; }

    }
}
