using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data.Oracle.Repositories
{
    
    public class PermisoRepository : IPermisoRepository
    {
        private readonly IOracleDbConnectionFactory _dbConnectionFactory;

        public PermisoRepository(IOracleDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }
        
        /// <summary>
        /// Lista todos los metodos de UNOEE para cargar treeview http://www.c-sharpcorner.com/article/c-treeview-to-mvc-razor-view/
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Permiso> List()
        {
            var list = new List<Permiso>();
            using (var dbConnection = (OracleConnection)_dbConnectionFactory.CreateConnection())
            {
                OracleCommand cmd = dbConnection.CreateCommand();
                cmd.CommandText = $@"SELECT DISTINCT 
                  M.F561_ID, 
                  M.F561_NOMBRE, 
                  M.F561_ID_METODO_PADRE,
                    M.F561_CONSTANTE,                  
                    M.F561_NIVEL NIVEL_METODO  

                FROM T561_SS_METODOS M 
                WHERE M.F561_NIVEL > -1 and M.F561_CONSTANTE<>'NO_IMPLEMENTADO' 
                CONNECT BY NOCYCLE PRIOR M.F561_ID = M.F561_ID_METODO_PADRE
                ORDER BY M.F561_CONSTANTE,M.F561_NIVEL";
                using (OracleDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        //ruta desconocida
                        string ruta = dr.GetString(3);
                        Permiso.Metodo.TryGetValue(dr.GetInt32(0), out ruta);

                        var item = new Permiso
                        {
                            IdPermiso = dr.GetInt32(0),
                            NombrePermiso = dr.GetString(1),
                            IdPermisoPadre = dr.GetInt32(2),
                            Constante = dr.GetString(3),
                            Ruta = ruta
                        };
                        
                        list.Add(item);
                    }
                }
            }
            foreach (var item in list) {
                if (!item.IdPermisoPadre.HasValue)
                    continue;

                string ruta = item.NombrePermiso;
                item.Ruta = MontarRuta(item.IdPermisoPadre.Value, ref ruta);
                

            }
            return list;
            
        }

        private string MontarRuta(int idMetodoPadre,ref string ruta)
        {
            int idMetodo = 0;
            using (var dbConnection = (OracleConnection)_dbConnectionFactory.CreateConnection())
            {
                OracleCommand cmd = dbConnection.CreateCommand();
                cmd.CommandText = $@"SELECT M.F561_ID_METODO_PADRE, M.F561_NOMBRE METODO_PADRE
                                FROM T561_SS_METODOS M 
                                WHERE M.F561_ID = {idMetodoPadre}";
                
                using (OracleDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        idMetodo = dr.GetInt32(0);
                        ruta = $"{dr.GetString(1)} > {ruta}";
                    }
                }
            }
            if (idMetodo > 0) {
                ruta = MontarRuta(idMetodo, ref ruta);
            }
            return ruta;
        }
        
        public HashSet<int> ListHijos(int idEmpresa, int idArea, int idMetodo) {
            var list = new HashSet<int>();
            using (var dbConnection = (OracleConnection)_dbConnectionFactory.CreateConnection())
            {
                OracleCommand cmd = dbConnection.CreateCommand();

                cmd.CommandText = $@"
                    SELECT  DISTINCT  hijo.F561_ID 
                    FROM T552_SS_USUARIOS U
                      INNER JOIN T571_SS_USUARIOS_PERFIL UP ON UP.F571_ROWID_USUARIO = U.F552_ROWID 
                      INNER JOIN T570_SS_METODOS_PERFIL MP ON UP.F571_ID_PERFIL =MP.F570_ID_PERFIL and UP.F571_ID_CIA = MP.F570_ID_CIA  
                      INNER JOIN T561_SS_METODOS M ON MP.F570_ID_METODO = M.F561_ID
                      left outer join T561_SS_METODOS hijo on M.F561_ID = hijo.F561_ID_METODO_PADRE
                    WHERE UP.F571_ID_CIA = {idEmpresa} AND UP.F571_ID_PERFIL = {idArea} AND hijo.F561_ID_METODO_PADRE={idMetodo}
                    AND M.F561_NIVEL > -1 AND M.F561_CONSTANTE<>'NO_IMPLEMENTADO' ";
                if (idEmpresa == 1 && idArea == 22 && idMetodo==4407) {
                    System.Diagnostics.Trace.WriteLine("ok");
                }
                using (OracleDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(dr.GetInt32(0));                        
                    }
                }
            }
            return list;
        }

        //listar solo nodos sin hijos
        public IEnumerable<Permiso> ListByArea(int idEmpresa, int idArea)
        {
            var list = new List<Permiso>();
            using (var dbConnection = (OracleConnection)_dbConnectionFactory.CreateConnection())
            {
                OracleCommand cmd = dbConnection.CreateCommand();
                cmd.CommandText = $@"SELECT 
                                        M.F561_ID, 
                                        M.F561_NOMBRE, 
                                        M.F561_ID_METODO_PADRE,
                                        REPLACE(M.F561_CONSTANTE,'_',' > '),
                                        M.F561_NIVEL 
                                    FROM T570_SS_METODOS_PERFIL MP
                                    INNER JOIN T561_SS_METODOS M ON MP.F570_ID_METODO = M.F561_ID
                                    WHERE F570_ID_CIA ={idEmpresa}  AND F570_ID_PERFIL = {idArea} 
                                    AND M.F561_NIVEL > -1 AND M.F561_CONSTANTE<>'NO_IMPLEMENTADO'
                                    ORDER BY 4, M.F561_NIVEL";
                
                using (OracleDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        //ruta desconocida
                        string ruta = "";
                        Permiso.Metodo.TryGetValue(dr.GetInt32(0), out ruta);
                        if (ruta == null) {
                            ruta = $"{dr.GetString(3)}";
                        }

                        var item = new Permiso
                        {
                            IdPermiso = dr.GetInt32(0),
                            NombrePermiso = dr.GetString(1),
                            IdPermisoPadre = dr.GetInt32(2),
                            Constante = dr.GetString(3),
                            Ruta = ruta
                        };
                        list.Add(item);
                    }
                }
            }
            return list.OrderBy(x=> x.Ruta);
        }

        public IEnumerable<Permiso> ListBy(int idEmpresa, int idArea)
        {
            var list = new List<Permiso>();
            using (var dbConnection = (OracleConnection)_dbConnectionFactory.CreateConnection())
            {
                OracleCommand cmd = dbConnection.CreateCommand();

                cmd.CommandText = $@"
                SELECT  DISTINCT 
                        M.F561_ID, 
                        M.F561_NOMBRE,
                        M.F561_ID_METODO_PADRE,
                        REPLACE(M.F561_CONSTANTE,'_',' > ')
                FROM T552_SS_USUARIOS U
                  INNER JOIN T571_SS_USUARIOS_PERFIL UP ON UP.F571_ROWID_USUARIO = U.F552_ROWID 
                  INNER JOIN T570_SS_METODOS_PERFIL MP ON MP.F570_ID_PERFIL = UP.F571_ID_PERFIL
                  INNER JOIN T561_SS_METODOS M ON MP.F570_ID_METODO = M.F561_ID
                WHERE UP.F571_ID_CIA = {idEmpresa} AND UP.F571_ID_PERFIL = {idArea}";
                using (OracleDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        //ruta desconocida
                        string ruta = dr.GetString(3);
                        Permiso.Metodo.TryGetValue(dr.GetInt32(0), out ruta);

                        var item = new Permiso
                        {
                            IdPermiso = dr.GetInt32(0),
                            NombrePermiso = dr.GetString(1),
                            IdPermisoPadre = dr.GetInt32(2),
                            Constante = dr.GetString(3),
                            Ruta = ruta
                        };
                        list.Add(item);
                    }
                }
            }
            return list;
        }
    }
}
