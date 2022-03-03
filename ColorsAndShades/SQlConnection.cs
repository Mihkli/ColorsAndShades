using System;
using System.Data.SqlClient;

namespace ColorsAndShades
{
    internal class SqlConnection
    {
        public SqlConnection(string connectionString)
        {
        }

        public static implicit operator SqlConnection(System.Data.SqlClient.SqlConnection v)
        {
            throw new NotImplementedException();
        }
    }
}