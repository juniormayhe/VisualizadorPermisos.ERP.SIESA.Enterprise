using System.Collections.Generic;
using Model;

namespace Data.Oracle.Repositories
{
    public interface IMiembroRepository
    {
        IEnumerable<Miembro> List(int idEmpresa, int idArea);
    }
}