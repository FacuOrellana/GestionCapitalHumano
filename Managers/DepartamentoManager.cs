using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Managers
{
    public class DepartamentoManager: IDepartamentoManager
    {
        public List<Departamento> GetAllDepartamentos()
        {
            using (var context = new CapitalHumanoContext())
            {
                return context.Departamentos.Where(e => e.Is_Deleted == false).ToList();
            }
        }
    }
}
