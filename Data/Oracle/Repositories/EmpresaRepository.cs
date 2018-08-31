using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data.Oracle.Repositories
{
    
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly IOracleDbConnectionFactory _dbConnectionFactory;

        public EmpresaRepository(IOracleDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }

        public IEnumerable<Empresa> List()
        {
            var list = new List<Empresa>();
            using (var dbConnection = (OracleConnection)_dbConnectionFactory.CreateConnection())
            {
                OracleCommand cmd = dbConnection.CreateCommand();
                cmd.CommandText = @"
SELECT
    F010_ID ID_EMPRESA,
	LPAD(F010_ID,2,'0') || ') NIT ' || LPAD(RTRIM(F010_NIT),10,'0') || ' - ' || F010_RAZON_SOCIAL RAZON_SOCIAL,
	RTRIM(F010_NIT) NIT 
FROM
	T010_MM_COMPANIAS 
ORDER BY F010_RAZON_SOCIAL";
                using (OracleDataReader dr = cmd.ExecuteReader()) {
                    while (dr.Read()) {
                        var item = new Empresa
                        {
                            IdEmpresa = dr.GetInt32(0),
                            NombreEmpresa = dr.GetString(1),
                            NIT= dr.GetString(2).TrimEnd(),
                        };
                        list.Add(item);
                    }
                }
            }
            return list;
        }
    }
}
