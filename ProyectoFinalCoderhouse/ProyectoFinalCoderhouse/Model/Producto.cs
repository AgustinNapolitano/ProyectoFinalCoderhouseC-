using System;

namespace Api_AgustinNapolitano.Model
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripciones { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }

        internal void Add(Producto producto)
        {
            throw new NotImplementedException();
        }
    }
}
