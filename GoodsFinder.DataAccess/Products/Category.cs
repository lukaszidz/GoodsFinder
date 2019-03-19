namespace GoodsFinder.DataAccess.Products
{
    public class Category
    {
        public long Id { get; set; }
        public long ParentCategoryId { get; set; }
        public string Name { get; set; }
    }
}