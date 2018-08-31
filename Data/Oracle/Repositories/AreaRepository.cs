using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data.Oracle.Repositories
{
    
    public class AreaRepository : IAreaRepository
    {
        private readonly IOracleDbConnectionFactory _dbConnectionFactory;

        public AreaRepository(IOracleDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }

        public IEnumerable<Area> List(int idEmpresa)
        {
            var list = new List<Area>();
            using (var dbConnection = (OracleConnection)_dbConnectionFactory.CreateConnection())
            {
                OracleCommand cmd = dbConnection.CreateCommand();
                cmd.CommandText = $@"
SELECT
    F550_ID ID_AREA,
	LPAD(F550_ID, 2, '0') || ') ' || UPPER(F550_NOMBRE) AREA,
	F550_ID_CIA ID_EMPRESA 
FROM
	T550_SS_PERFILES 
WHERE F550_ID_CIA = {idEmpresa}
ORDER BY UPPER(F550_NOMBRE)";
                using (OracleDataReader dr = cmd.ExecuteReader()) {
                    while (dr.Read()) {
                        var item = new Area
                        {
                            IdArea = dr.GetInt32(0),
                            NombreArea = dr.GetString(1),
                            IdEmpresa = dr.GetInt32(2),
                        };
                        list.Add(item);
                    }
                }
            }
            return list;
        }
    }
}
