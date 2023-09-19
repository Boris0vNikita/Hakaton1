using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakaton1.Infrastructure
{
    public class DbConn
    {
        private const string stringConnection = @"Server=176.56.14.200; Port=5432; Database=user7; UID = prb07; PWD=prb07";
        private static NpgsqlConnection _sqlConnection;

        public static NpgsqlConnection npgSqlConnection
        {
            get
            {
                if (_sqlConnection == null)
                {
                    _sqlConnection = new NpgsqlConnection(stringConnection);
                }
                if (_sqlConnection.State != System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Open();
                }
                return _sqlConnection;
            }
        }
    }
}
