using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Oracle
{
    public class OracleConnectionFactory : IOracleDbConnectionFactory
    {
        private readonly string _connectionString;

        /// <summary>
        /// string connectionString = "user id=scott;password=tiger;data source=oracle";
        /// </summary>
        /// <param name="connectionString"></param>
        public OracleConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            var conn = new OracleConnection(_connectionString);
            conn.Open();
            return conn;
        }
    }
}
