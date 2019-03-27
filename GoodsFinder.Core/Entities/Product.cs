using System;

namespace GoodsFinder.Core.Entities
{
    public class Product
    {
        public Product(string name, DateTime reviewTime, string title, string manufacturer, float rate, string reviewText,
        long categoryId, string categoryName)
        {
            Name = name;
            ReviewTime = reviewTime;
            Title = title;
            Manufacturer = manufacturer;
            Rate = rate;
            ReviewText = reviewText;
            CategoryId = categoryId;
            CategoryName = categoryName;
        }

        public string Name { get; private set; }
        public DateTime ReviewTime { get; private set; }
        public string Title { get; private set; }
        public string Manufacturer { get; private set; }
        public float Rate { get; private set; }
        public string ReviewText { get; private set; }
        public long CategoryId { get; private set; }
        public string CategoryName { get; private set; }
    }
}