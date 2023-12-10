using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Interfaces
{
    public interface IDepartamentoManager
    {
        List<Departamento> GetAllDepartamentos();
        Departamento GetDepartamento(int id);

        Departamento editDepartamento(int id, DepartamentoDTO departamentoDTO);
        Departamento crearDepartamento(DepartamentoDTO departamentoDTO);

        bool deleteDepartamento(int id);
    }
}
