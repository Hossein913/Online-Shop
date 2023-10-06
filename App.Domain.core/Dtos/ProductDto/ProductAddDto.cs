namespace App.Domain.core.Dtos.ProductDto
{
    public class ProductAddDto
    {
        public int? CategoryId { get; set; }

        public string? Title { get; set; }

        public int CalculatedQty { get; set; }

    }
}