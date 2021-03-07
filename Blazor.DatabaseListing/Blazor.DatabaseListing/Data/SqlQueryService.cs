using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.DatabaseListing.Data
{
    public class SqlQueryService
    {
        private readonly IConfiguration _configuration;

        public SqlQueryService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ICollection<T> ExecuteQuery<T>(string query, object parameters = null)
        {
            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                return db.Query<T>(query, parameters).ToList();
            }
        }
    }
}
