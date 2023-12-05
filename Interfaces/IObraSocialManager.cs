using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Interfaces
{
    public interface IObraSocialManager
    {
        List<ObraSocial> GetAllObraSocial();
        ObraSocial crearObraSocial(ObraSocial obraSocial);

        ObraSocial editObraSocial(int id, ObraSocial obraSocial);

        bool deleteObraSocial(int id);
    }
}
