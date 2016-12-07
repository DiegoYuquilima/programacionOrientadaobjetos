using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cliente
{
    public class Producto:Encargo
    {
        private double ID;
        private double coste;

      
        public double mostrar_producto()
        {
            return ID + coste;

        }

        public void ingresar_datos(double id_, double coste_)
        {
            ID = id_;
            coste = coste_;
        }
    }
}
