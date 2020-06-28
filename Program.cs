using Enumerables.Entidades;
using Enumerables.Entidades.Enums;
using System;

namespace Enumerables
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido
            {
                Id = 555,
                HoraPedido = DateTime.Now,
                statusPedido = StatusPedido.Processando
            };

            Console.WriteLine(pedido);

            /// Conversões
            /// Para o tipo original: use casting
            /// 

            StatusPedido os1 = (StatusPedido)3;

            int n1 = (int)StatusPedido.Entregue;

            Console.WriteLine(os1);
            Console.WriteLine(n1);

            // string - enum

            string txt = StatusPedido.Enviado.ToString();

            StatusPedido os = Enum.Parse<StatusPedido>("Entregue");

            Console.WriteLine(txt);
            Console.WriteLine(os);

        }
    }
}
