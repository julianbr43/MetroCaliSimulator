using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MetroCaliSimulator.model
{
    [Serializable]
    public class MioSystem
    {
        public List<Zona> zonas { get; set; }
        public Queue<List<Bus>> theBusTime { get; set; }
        public List<Stop> stopStations { get; set; }
        public List<Stop> stopStreets { get; set; }
        public Hashtable theStop { get; set; }

        public MioSystem()
        {
            this.theStop = new Hashtable();
            this.stopStations = new List<Stop>();
            this.stopStreets = new List<Stop>();
            this.theBusTime = new Queue<List<Bus>>();
            this.zonas = new List<Zona>();
            loadZones();
        }

        public void loadZones()
        {
            Zona z0 = new Zona(3.457664, 3.441622, -76.598407, -76.524088); //Zona centro(0)
            zonas.Add(z0);

            Zona z1 = new Zona(3.380145, 3.287627, -76.598407, -76.449366); //Zona sur(1)
            zonas.Add(z1);

            Zona z2 = new Zona(3.516009, 3.457664, -76.598407, -76.505034); //Zona menga(2)
            zonas.Add(z2);

            Zona z3 = new Zona(3.516009, 3.449274, -76.505034, 76.449366); //Zona chiminangos
            zonas.Add(z3);

            Zona z4 = new Zona(3.449274, 3.414548, -76.524088, -76.460200); //Zona Andres sanin(4)
            zonas.Add(z4);

            Zona z5 = new Zona(3.414548, 3.380145, -76.524088, -76.460200); //Zona Aguablanca(5)
            zonas.Add(z5);

            Zona z7 = new Zona(3.441622, 3.380145, -76.598407, -76.524088); //Zona caniaveralejo(7)
            zonas.Add(z7);
        }

        public int isZone(double altitud, double longitud)
        {
            Console.WriteLine("f" + zonas.Count);
            int pos = -1;
            for (int i = 0; i < zonas.Count; i++)
            {
                Zona z = zonas[i];
                if (altitud <= z.getMaxAltitud() && altitud >= z.getMinAltitud())
                {
                    if (longitud >= z.getMaxLongitud() && longitud <= z.getMinLongitud())
                    {
                        pos = i;
                    }
                }
            }
            return pos;
        }

    }
}
