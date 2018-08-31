using System.Collections.Generic;
using Model;

namespace Data.Oracle.Repositories
{
    public interface IAreaRepository
    {
        IEnumerable<Area> List(int idEmpresa);
    }
}