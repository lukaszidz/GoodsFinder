using System;

namespace GoodsFinder.Core.Queries
{
    public class ProductsQuery
    {
        public Nullable<long> Id { get; set; }
        public string Name { get; set; }
        public Nullable<long> ProductId { get; set; }
        public Nullable<DateTime> ReviewTime { get; set; }
        public string Title { get; set; }
        public string Manufacturer { get; set; }
        public Nullable<float> Rate { get; set; }
        public string Text { get; set; }
        public Nullable<long> CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}