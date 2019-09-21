using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroCaliSimulator.model
{
    [Serializable]
    public class Stop
    {

        public string stopid { get; set; }
        public int planVersionId { get; set; }
        public String shortName { get; set; }
        public String longName { get; set; }
        public int gpsX { get; set; }
        public int gpsY { get; set; }
        public double decLong { get; set; }
        public double decLat { get; set; }

        public Stop(string stopid, int planVersionId, string shortName, string longName, int gpsX, int gpsY, double decLong, double decLat)
        {
            this.stopid = stopid;
            this.planVersionId = planVersionId;
            this.shortName = shortName;
            this.longName = longName;
            this.gpsX = gpsX;
            this.gpsY = gpsY;
            this.decLong = decLong;
            this.decLat = decLat;
        }


    }

}
