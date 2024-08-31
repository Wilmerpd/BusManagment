

using BusManagment.Entities;

namespace BusManagment.Interfaces
{
    // Interfaz genérica para repositorios
    public interface IRepository<T>
    {
        void Agregar(T entity);
        void Actualizar(T entity);
        void Remover(T entity);
        List<T> TraerTodos();
        T ObtenerPorId(int id);
    }

    // Interfaz específica para el repositorio de Asiento que hereda de la interfaz genérica
    public interface IAsientoRepository : IRepository<Asiento>
    {
        // Métodos adicionales específicos para Asiento (si los hay)
    }
}
