using GoodsFinder.Core.Queries;
using GoodsFinder.Core.Responses;

namespace GoodsFinder.Core.Interfaces
{
    public interface IProductsService
    {
        ProductsResponse GetProductsResponse(ProductsQuery productQuery);
    }
}