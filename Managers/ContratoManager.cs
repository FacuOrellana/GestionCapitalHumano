using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Managers
{
    public class ContratoManager : IContratoManager
    {
        public List<Contrato> GetAllContratos()
        {
            using (var context = new CapitalHumanoContext())
            {
                return context.Contratos.ToList();
            }
        }
        public List<Contrato> GetContratosById(int id)
        {
            using (var context = new CapitalHumanoContext())
            {
                return context.Contratos.
                    Where(c=>c.IdEmpleado== id).ToList();
            }
        }
    }
}
