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
                return context.ObraSociales.Where(e => e.Is_Deleted == false).ToList();
            }
        }

        public ObraSocial crearObraSocial(ObraSocial obraSocial)
        {
            using (var context = new CapitalHumanoContext())
            {
                context.ObraSociales.Add(obraSocial);
                context.SaveChanges();
                return obraSocial;
            }
        }

        public ObraSocial editObraSocial(int id, ObraSocial obraSocial)
        {
            var context = new CapitalHumanoContext();
            var obraSocialExistente = context.ObraSociales.FirstOrDefault(e => e.IdObraSocial == id);
            if(obraSocialExistente != null)
            {
                obraSocialExistente.Aporte = obraSocial.Aporte;
                obraSocialExistente.Descripcion = obraSocial.Descripcion;
                obraSocialExistente.Is_Deleted = obraSocial.Is_Deleted;
                context.SaveChanges();
                return obraSocialExistente;
            }
            return obraSocialExistente;
        }

        public bool deleteObraSocial(int id)
        {
            var context = new CapitalHumanoContext();
            var obraSocialExistente = context.ObraSociales.FirstOrDefault(e=>e.IdObraSocial==id);
            if(obraSocialExistente != null)
            {
                obraSocialExistente.Is_Deleted = true;
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
