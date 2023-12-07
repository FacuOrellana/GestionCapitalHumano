using GestionCapitalHumano.DTOs;
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

        public ObraSocial crearObraSocial(ObraSocialDTO obraSocial)
        {
            using (var context = new CapitalHumanoContext())
            {
                try
                {
                    ObraSocial obra = new ObraSocial
                    {
                        Descripcion = obraSocial.Descripcion,
                        Aporte = obraSocial.Aporte,
                        Is_Deleted = false
                    };
                    context.ObraSociales.Add(obra);
                    context.SaveChanges();
                    return obra;
                }catch (Exception ex)
                {
                    Console.WriteLine($"Error al crear ObraSocial");
                    throw;
                }                
            }
        }

        public ObraSocial editObraSocial(int id, ObraSocialDTO obraSocial)
        {
            var context = new CapitalHumanoContext();
            try
            {
                var obraSocialExistente = context.ObraSociales.FirstOrDefault(e => e.IdObraSocial == id);
                if (obraSocialExistente != null)
                {
                    obraSocialExistente.Aporte = obraSocial.Aporte;
                    obraSocialExistente.Descripcion = obraSocial.Descripcion;
                    context.SaveChanges();
                    return obraSocialExistente;
                }
                else
                {
                    Console.WriteLine($"No se encontro Obra Social: " + id);
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al editar una obra social" +  ex.Message);
                throw;
            }
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
