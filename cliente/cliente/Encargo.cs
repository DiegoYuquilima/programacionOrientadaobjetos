using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cliente
{
   public class Encargo
    {
        private int encargoID;
        private string fecha;
        private double valor;

        public int EncargoID
        {
            get
            {
                return encargoID;
            }

            set
            {
                encargoID = value;
            }
        }

        public string Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public double Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }
    }
}
