using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Managers
{
    public class ObraSocialManager: IObraSocialManager
    {
        public List<ObraSocial> GetAllObraSocial()
        {
            using (var context = new CapitalHumanoContext())
            {
                return context.ObraSociales.ToList();
            }
        }
    }
}
