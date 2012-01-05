using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarcasWeb2.Servicios
{
    public static class ListaServicios
    {
        private static readonly ImplementacionServicios Impl = new ImplementacionServicios();

        public static IServClientes Clientes { get { return Impl.Clientes; } }
    }

    public class ImplementacionServicios : IImplementacionServicios
    {
        private IServClientes _clientes;

        public IServClientes Clientes { get { _clientes = _clientes ?? new ServClientes(); return _clientes; } }
    }

    public interface IImplementacionServicios
    {
        IServClientes Clientes { get; }
    }
}