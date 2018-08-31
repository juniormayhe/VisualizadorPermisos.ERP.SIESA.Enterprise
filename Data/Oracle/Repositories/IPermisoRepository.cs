using System.Collections.Generic;
using Model;

namespace Data.Oracle.Repositories
{
    public interface IPermisoRepository : IRepository<Permiso>
    {
        IEnumerable<Permiso> ListByArea(int idEmpresa, int idArea);
        HashSet<int> ListHijos(int idEmpresa, int idArea, int idMetodo);
    }
}