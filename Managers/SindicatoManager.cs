using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Managers
{
    public class SindicatoManager: ISindicatoManager
    {
        public List<Sindicato> GetAllSindicatos()
        {
            using (var context = new CapitalHumanoContext())
            {
                return context.Sindicatos.ToList();
            }
        }
    }
}
