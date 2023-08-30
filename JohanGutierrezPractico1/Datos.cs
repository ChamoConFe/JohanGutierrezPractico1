using JohanGutierrezPractico1.Modelos;
using System.Collections.Generic;

namespace JohanGutierrezPractico1
{
    public class Datos
    {
        public List<Cliente> Clientes { get; set; }
        public List<Tarjeta> Tarjetas { get; set; }

        public Datos()
        {
            Clientes = new List<Cliente>();
            Tarjetas = new List<Tarjeta>();
        }
    }
}