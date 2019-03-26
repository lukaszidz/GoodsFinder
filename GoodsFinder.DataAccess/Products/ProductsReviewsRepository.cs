using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;

namespace GoodsFinder.DataAccess.Products
{
    public class ProductsReviewsRepository : SqlRepository
    {
        public ProductsReviewsRepository(string connectionString) : base(connectionString) { }

        public async Task<IEnumerable<ProductReview>> GetNLastProductReviews(long productId, long quantity)
        {
            using (var conn = GetConnection())
            {
                var sql = "SELECT TOP(@Quantity) Id, ProductId, ReviewTime, Title, Manufacturer, Rate, Text FROM ProductReview WHERE ProductId = @ProductId";
                var parameters = new DynamicParameters();
                parameters.Add("@Quantity", quantity, System.Data.DbType.Int64);
                parameters.Add("@ProductId", productId, System.Data.DbType.Int64);
                return await conn.QueryAsync<ProductReview>(sql, parameters);
            }
        }
    }
}