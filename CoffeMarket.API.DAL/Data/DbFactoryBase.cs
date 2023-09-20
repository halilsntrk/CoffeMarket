using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMarket.API.DAL.Data
{
	public abstract class DbFactoryBase
	{
		private readonly IConfiguration _configuration;
		internal string DbConnectionString => _configuration.GetConnectionString("SQLDBConnectionString");
		protected DbFactoryBase(IConfiguration configuration)
		{
			_configuration = configuration;
		}
		internal IDbConnection DbConnection => new SqlConnection(DbConnectionString);

		  public virtual async Task<IEnumerable<T>> DbQueryAsync<T>(string sql, object parameters = null)
        {
            using IDbConnection dbCon = DbConnection;
            return parameters == null ? await dbCon.QueryAsync<T>(sql) : await dbCon.QueryAsync<T>(sql, parameters);
        }
	}
}
