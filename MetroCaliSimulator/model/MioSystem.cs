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
        public List<Stop> stopStations { get; set; }
        public List<Stop> stopStreets { get; set; }
        public Hashtable theStop { get; set; }

        public MioSystem() {
            this.theStop = new Hashtable();
            this.stopStations = new List<Stop>();
            this.stopStreets = new List<Stop>();
        }

    }
}
