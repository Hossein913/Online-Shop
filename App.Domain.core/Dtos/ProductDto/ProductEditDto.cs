namespace App.Domain.core.Dtos.ProductDto
{
    public class ProductEditDto
    {
        public int Id { get; set; }

        public int? CategoryId { get; set; }

        public string? Title { get; set; }

        public int CalculatedQty { get; set; }
    }
}