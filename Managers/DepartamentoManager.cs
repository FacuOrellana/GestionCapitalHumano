using GestionCapitalHumano.DTOs;
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

        public bool deleteDepartamento(int id)
        {
            var context = new CapitalHumanoContext();
            try
            {
                var departamenteExistente = context.Departamentos.FirstOrDefault(e => e.IdDepartamento == id);
                if (departamenteExistente != null)
                {
                    departamenteExistente.Is_Deleted = true;
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    Console.WriteLine("No se encontro el departamento " + id);
                    return false;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }            
        }

        public Departamento GetDepartamento(int id)
        {
            var context = new CapitalHumanoContext();
            try
            {
                var departamentoExistente = context.Departamentos.FirstOrDefault(e => e.IdDepartamento == id);
                if(departamentoExistente != null)
                {
                    return departamentoExistente;
                }
                else
                {
                    return null;
                }
            }catch (Exception ex)
            {
                Console.WriteLine("Error al buscar un departamento: "+ex.ToString());
                throw;
            }
        }

        public Departamento crearDepartamento(DepartamentoDTO departamento)
        {
            var context = new CapitalHumanoContext();
            try
            {
                Departamento departamentoNew = new Departamento()
                {
                    IdArea = departamento.IdArea,
                    Descripcion = departamento.Descripcion,
                    Is_Deleted = false
                };
                context.Departamentos.Add(departamentoNew);
                context.SaveChanges();
                return departamentoNew;
            }catch (Exception ex)
            {
                Console.WriteLine("Error al cargar un nuevo departamento");
                throw;
            }
        }

        public Departamento editDepartamento(int id,DepartamentoDTO departamento)
        {
            var context = new CapitalHumanoContext();
            try
            {
                var departamentoExistente = context.Departamentos.FirstOrDefault(e => e.IdDepartamento == id);
                if(departamentoExistente != null)
                {
                    departamentoExistente.IdArea = departamento.IdArea;
                    departamentoExistente.Descripcion = departamento.Descripcion;
                    context.SaveChanges();
                    return departamentoExistente;
                }
                else
                {
                    Console.WriteLine("no se encontro el departamento a editar");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al editar un nuevo departamento");
                throw;
            }
        }
    }
}
