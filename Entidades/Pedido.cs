using Enumerables.Entidades.Enums;
using System;


namespace Enumerables.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime HoraPedido { get; set; }
        public StatusPedido statusPedido { get; set; }

        public override string ToString()
        {
            return Id + " -- " + HoraPedido + " -- " + statusPedido;
        }
    }
}
