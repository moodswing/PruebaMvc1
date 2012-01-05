using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MarcasWeb2.Models;

namespace MarcasWeb2.Servicios
{
    public interface IServClientes
    {
        IQueryable<Cliente> Todos();
    }

    public class ServClientes : IServClientes
    {
        private readonly MarcasEntities _linqContext = new MarcasEntities();

        public IQueryable<Cliente> Todos()
        {
            var resultado = from c in _linqContext.TB_CLIENTES select c;
            resultado = resultado.Take(10);

            return resultado;
        }
    }
}