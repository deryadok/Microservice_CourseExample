namespace Course.Services.Basket.Dtos
{
    public class BasketItemDto
    {
        public int Quantity { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public decimal Price { get; set; }
    }
}
