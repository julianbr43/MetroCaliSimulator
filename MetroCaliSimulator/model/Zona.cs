using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroCaliSimulator.model
{
    [Serializable]
    public class Zona
    {
        private double maxAltitud; //AlturaMax
        private double minAltitud; //AlturaMin
        private double maxLongitud; //Ancho izquierdo
        private double minLongitud; //Ancho derecho

        public Zona(double maxAltitud, double minAltitud, double maxLongitud, double minLongitud)
        {
            this.maxAltitud = maxAltitud;
            this.minAltitud = minAltitud;
            this.maxLongitud = maxLongitud;
            this.minLongitud = minLongitud;
        }

        public double getMinAltitud()
        {
            return minAltitud;
        }

        public double getMaxAltitud()
        {
            return maxAltitud;
        }

        public double getMaxLongitud()
        {
            return maxLongitud;
        }

        public double getMinLongitud()
        {
            return minLongitud;
        }
    }
}
