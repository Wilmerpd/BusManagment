
using BusManagment.Entities;
using BusManagment.Interfaces;

namespace BusManagment.Repository
{
    public class AsientoRepository : IAsientoRepository
    {
        private readonly List<Asiento> _asientos = new List<Asiento>();

        public void Agregar(Asiento asiento)
        {
            _asientos.Add(asiento);
            Console.WriteLine("Asiento agregado.");
        }

        public void Actualizar(Asiento asiento)
        {
            var existingAsiento = ObtenerPorId(asiento.AsientoId);
            if (existingAsiento != null)
            {
                // Actualizar propiedades del asiento
                existingAsiento.BusId = asiento.BusId;
                existingAsiento.NumeroPiso = asiento.NumeroPiso;
                existingAsiento.NumeroAsiento = asiento.NumeroAsiento;
                existingAsiento.FechaCreacion = asiento.FechaCreacion;
                Console.WriteLine("Asiento actualizado.");
            }
        }

        public void Remover(Asiento asiento)
        {
            _asientos.Remove(asiento);
            Console.WriteLine("Asiento removido.");
        }

        public List<Asiento> TraerTodos()
        {
            return _asientos;
        }
        public Asiento ObtenerPorId(int asientoId)
        {
            return _asientos.FirstOrDefault(a => a.AsientoId == asientoId);
        }
    }
}
