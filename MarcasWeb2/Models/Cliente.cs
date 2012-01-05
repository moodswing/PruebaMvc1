using System;

namespace MarcasWeb2.Models
{
    public partial class Cliente : IEquatable<Cliente>
    {
        #region Implementation of IEquatable<Cliente>

        bool IEquatable<Cliente>.Equals(Cliente other)
        {
            return IdCliente.Equals(other.IdCliente);
        }

        #endregion
    }
}