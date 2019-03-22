using System.Collections.Generic;
using System.Linq;
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
                var sql = "SELECT TOP(@Quantity) Id, ProductId, ReviewTime, Title, Manufacturer, Rate, Text FROM ProductReview";
                var parameters = new DynamicParameters();
                parameters.Add("@Quantity", quantity, System.Data.DbType.Int64);
                return await conn.QueryAsync<ProductReview>(sql);
            }
        }
    }
}