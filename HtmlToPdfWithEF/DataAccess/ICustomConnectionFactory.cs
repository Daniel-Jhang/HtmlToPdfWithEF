using System.Data;

namespace HtmlToPdfWithEF.DataAccess
{
    public interface ICustomConnectionFactory
    {
        IDbConnection sqlConnection { get; }

        IDbConnection CreateConnection();
    }
}