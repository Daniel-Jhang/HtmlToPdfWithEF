using System;
using System.Data;
using System.Data.SqlClient;

namespace HtmlToPdfWithEF.DataAccess
{
    public class CustomConnectionFactory : ICustomConnectionFactory
    {
        private readonly Func<string> _getConnectionString;
        public IDbConnection sqlConnection { get; }
        public CustomConnectionFactory(Func<string> getConnectionString)
        {
            this._getConnectionString = getConnectionString;
            sqlConnection = CreateConnection();
        }
        public IDbConnection CreateConnection() => new SqlConnection(_getConnectionString());
    }
}
