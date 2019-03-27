using System.Collections.Generic;
using GoodsFinder.Core.Entities;

namespace GoodsFinder.Core.Responses
{
    public class ProductsResponse
    {
        public IEnumerable<Product> Products { get; set; }
    }
}