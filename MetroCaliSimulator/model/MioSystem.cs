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
        public Hashtable theBusTime { get; set; }
        public List<Stop> stopStationsZone0 { get; set; }
        public List<Stop> stopStationsZone1 { get; set; }
        public List<Stop> stopStationsZone2 { get; set; }
        public List<Stop> stopStationsZone3 { get; set; }
        public List<Stop> stopStationsZone4 { get; set; }
        public List<Stop> stopStationsZone5 { get; set; }
        public List<Stop> stopStationsZone7 { get; set; }
        public List<Stop> stopStreets { get; set; }
        public Hashtable theStop { get; set; }

        public MioSystem() {
            this.theStop = new Hashtable();
            this.stopStationsZone0 = new List<Stop>();
            this.stopStationsZone1 = new List<Stop>();
            this.stopStationsZone2 = new List<Stop>();
            this.stopStationsZone3 = new List<Stop>();
            this.stopStationsZone4 = new List<Stop>();
            this.stopStationsZone5 = new List<Stop>();
            this.stopStationsZone7 = new List<Stop>();
            this.stopStreets = new List<Stop>();
            this.theBusTime = new Hashtable();
        }

    }
}
