using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Managers
{
    public class CapacitacionManager : ICapacitacionManager
    {
        public Capacitacion crearCapacitacion(CapacitacionDTO capacitacion)
        {
            using(var context = new CapitalHumanoContext())
            {
                try
                {
                    Capacitacion capacitacionNew = new Capacitacion
                    {
                        Descripcion = capacitacion.Descripcion,
                        DuracionHoras = capacitacion.DuracionHoras,
                        Fecha = capacitacion.Fecha,
                        Is_Deleted = false
                    };
                    if(capacitacionNew!=null )
                    {
                        context.Capacitaciones.Add(capacitacionNew);
                        context.SaveChanges();
                        return capacitacionNew;
                    }
                    else
                    {
                        return null;
                    }
                    
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Fallo la creacion de una capacitación"+ex.ToString());
                    throw;
                }                
            }
        }

        public bool deleteCapacitacion(int id)
        {
            var context = new CapitalHumanoContext();
            var capacitacionABorrar = context.Capacitaciones.FirstOrDefault(e=>e.IdCapacitacion == id);
            if(capacitacionABorrar !=null)
            {
                capacitacionABorrar.Is_Deleted = true;
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Capacitacion editCapacitacion(int id, CapacitacionDTO capacitacion)
        {
            using(var context = new CapitalHumanoContext())
            {
                try
                {
                    var capacitacionAEditar = context.Capacitaciones.FirstOrDefault(e => e.IdCapacitacion == id);
                    if(capacitacionAEditar != null)
                    {
                        capacitacionAEditar.Descripcion = capacitacion.Descripcion;
                        capacitacionAEditar.DuracionHoras = capacitacion.DuracionHoras;
                        capacitacionAEditar.Fecha = capacitacion.Fecha;
                        context.SaveChanges();
                        return capacitacionAEditar;
                    }
                    else
                    {
                        Console.WriteLine("No se encontro la capacitacion con id: " + id);
                        return null;
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine($"{ex.Message}", ex);
                    throw;
                }
            }
        }

        public Capacitacion GetCapacitacion(int id)
        {
            using(var context = new CapitalHumanoContext())
            {
                try
                {
                    var capacitacion = context.Capacitaciones.FirstOrDefault(e => e.IdCapacitacion == id);
                    if(capacitacion != null)
                    {
                        return capacitacion;
                    }
                    else
                    {
                        Console.WriteLine("No se encontro la capacitacion: " + id);
                        return null;
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine("Error al buscar una capacitacion");
                    throw;
                }
            }
        }

        public List<Capacitacion> GetCapacitaciones()
        {
            using(var context = new CapitalHumanoContext())
            {
                try
                {
                    var ListaCapacitacion = context.Capacitaciones.Where(e=>e.Is_Deleted==false).ToList();
                    if(ListaCapacitacion.Count > 0)
                    {
                        return ListaCapacitacion;
                    }
                    else
                    {
                        Console.WriteLine("No hay capacitaciones disponibles");
                        return null;
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine("Error al mostrar las capacitaciones");
                    throw;
                }
            }
        }
    }
}
