using System.Data;
using System.Data.SqlClient;

namespace GoodsFinder.DataAccess
{
    public abstract class SqlRepository
    {
        private string _connectionString;
        
        public SqlRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}