namespace GoodsFinder.DataAccess.Products
{
    public class ProductReview
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public DateTime ReviewTime { get; set; }
        public string Title { get; set; }
        public string Manufacturer { get; set; }
        public float Rate { get; set; }
        public string Text { get; set; }
    }
}