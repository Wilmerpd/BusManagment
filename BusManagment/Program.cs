using BusManagment.Entities;
using BusManagment.Interfaces;
using BusManagment.Repository;



           IAsientoRepository asientoRepository = new AsientoRepository();

            // Crear nuevos asientos
            Asiento asiento1 = new Asiento { AsientoId = 1, BusId = 101, NumeroPiso = 1, NumeroAsiento = 1, FechaCreacion = DateTime.Now };
            Asiento asiento2 = new Asiento { AsientoId = 2, BusId = 101, NumeroPiso = 1, NumeroAsiento = 2, FechaCreacion = DateTime.Now };

            // Agregar asientos
            asientoRepository.Agregar(asiento1);
            asientoRepository.Agregar(asiento2);

            // Mostrar todos los asientos
            Console.WriteLine("Lista de Asientos:");
            var asientos = asientoRepository.TraerTodos();
            foreach (var asiento in asientos)
            {
                Console.WriteLine($"ID: {asiento.AsientoId}, Bus ID: {asiento.BusId}, Piso: {asiento.NumeroPiso}, Numero: {asiento.NumeroAsiento}, Fecha: {asiento.FechaCreacion}");
            }

            // Actualizar un asiento
            Asiento asientoActualizado = new Asiento { AsientoId = 1, BusId = 102, NumeroPiso = 2, NumeroAsiento = 5, FechaCreacion = DateTime.Now };
            asientoRepository.Actualizar(asientoActualizado);

            // Obtener un asiento por ID
            var asientoObtenido = asientoRepository.ObtenerPorId(1);
            Console.WriteLine($"\nAsiento obtenido por ID: {asientoObtenido.AsientoId}, Bus ID: {asientoObtenido.BusId}, Piso: {asientoObtenido.NumeroPiso}, Numero: {asientoObtenido.NumeroAsiento}");

            // Remover un asiento
            asientoRepository.Remover(asiento2);
        
    
