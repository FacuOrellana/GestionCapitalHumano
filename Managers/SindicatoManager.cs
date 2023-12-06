using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.DTOs;
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

        public Sindicato crearSindicato(SindicatoDTO sindicato)
        public Sindicato crearSindicato(SindicatoDTO sindicato)
        {
            var contexto = new CapitalHumanoContext();
            try
            {
                Sindicato sindicatoNew = new Sindicato
                {
                    Descripcion = sindicato.Descripcion,
                    Aporte = sindicato.Aporte,
                    Is_Deleted = false
                };
                contexto.Sindicatos.Add(sindicatoNew);
                contexto.SaveChanges();
                return sindicatoNew;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear Sindicato: "+ex.Message);
                throw;
            }            
        }

        public Sindicato editarSindicato(int id, SindicatoDTO sindicato)
        public Sindicato editarSindicato(int id, SindicatoDTO sindicato)
        {
            var context = new CapitalHumanoContext();
            try
            {
                var sindicatoExistente = context.Sindicatos.FirstOrDefault(e => e.IdSindicato == id);
                if (sindicatoExistente != null)
                {
                    sindicatoExistente.Aporte = sindicato.Aporte;
                    sindicatoExistente.Descripcion = sindicato.Descripcion;
                    context.SaveChanges();
                    return sindicatoExistente;
                }
                else
                {
                    Console.WriteLine($"No se encontro el sindicato con id: " + id);
                    return null;
                }
            try
            {
                var sindicatoExistente = context.Sindicatos.FirstOrDefault(e => e.IdSindicato == id);
                if (sindicatoExistente != null)
                {
                    sindicatoExistente.Aporte = sindicato.Aporte;
                    sindicatoExistente.Descripcion = sindicato.Descripcion;
                    context.SaveChanges();
                    return sindicatoExistente;
                }
                else
                {
                    Console.WriteLine($"No se encontro el sindicato con id: " + id);
                    return null;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error al editar el empleado" + ex.Message);
                throw;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error al editar el empleado" + ex.Message);
                throw;
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
