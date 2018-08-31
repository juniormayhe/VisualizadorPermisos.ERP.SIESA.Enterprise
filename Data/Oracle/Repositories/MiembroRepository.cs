using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data.Oracle.Repositories
{
    
    public class MiembroRepository : IMiembroRepository
    {
        private readonly IOracleDbConnectionFactory _dbConnectionFactory;

        public MiembroRepository(IOracleDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }

        public IEnumerable<Miembro> List(int idEmpresa, int idArea)
        {
            List<Miembro> list = new List<Miembro>();
            using (var dbConnection = (OracleConnection)_dbConnectionFactory.CreateConnection())
            {
                OracleCommand cmd = dbConnection.CreateCommand();
                cmd.CommandText = $@"SELECT 
                    U.F552_ROWID F_ID_USUARIO, 
                    LPAD(U.F552_ROWID,2,'0') || ') ' || UPPER(U.F552_NOMBRE) F_NOMBRE_USUARIO  
                FROM T571_SS_USUARIOS_PERFIL UP 
                INNER JOIN T552_SS_USUARIOS U ON UP.F571_ROWID_USUARIO = U.F552_ROWID
                WHERE UP.F571_ID_CIA = {idEmpresa} AND UP.F571_ID_PERFIL = {idArea}
                ORDER BY U.F552_NOMBRE";
                using (OracleDataReader dr = cmd.ExecuteReader()) {
                    while (dr.Read()) {
                        var miembro = new Miembro
                        {
                            IdMiembro = dr.GetInt32(0),
                            NombreMiembro = dr.GetString(1)
                        };
                        list.Add(miembro);
                    }
                }
            }
            return list;
        }
    }
}
