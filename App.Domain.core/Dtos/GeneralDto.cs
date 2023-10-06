namespace App.Domain.core.Dtos
{
    public class GeneralDto<T>
    {
        public string Message { get; set; }
        public T Data { get; set; }
    }

    public class GeneralDto
    {
        public int Id { get; set; }
        public string Message { get; set; }
    }
}
