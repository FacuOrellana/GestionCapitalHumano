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
                return context.Sindicatos.Where(e => e.Is_Deleted == false).ToList();
            }
        }

        public Sindicato crearSindicato(Sindicato sindicato)
        {
            var contexto = new CapitalHumanoContext();
            contexto.Sindicatos.Add(sindicato);
            contexto.SaveChanges();
            return sindicato;
        }

        public Sindicato editarSindicato(int id, Sindicato sindicato)
        {
            var context = new CapitalHumanoContext();
            var sindicatoExistente = context.Sindicatos.FirstOrDefault(e=>e.IdSindicato == id);
            if(sindicatoExistente != null)
            {
                sindicatoExistente.Aporte = sindicato.Aporte;
                sindicatoExistente.Descripcion = sindicato.Descripcion;
                context.SaveChanges();
                return sindicatoExistente;
            }
            else
            {
                return null;
            }

        }

        public bool deleteSindicato(int id)
        {
            var context = new CapitalHumanoContext();
            var sindicatoExistente = context.Sindicatos.FirstOrDefault(e=>e.IdSindicato==id);
            if(sindicatoExistente != null)
            {
                sindicatoExistente.Is_Deleted = true;
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
