using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroCaliSimulator.model
{
    [Serializable]
    public class Operational
    {
        public string busIdTripId { get; set; }
        public int desviationTime { get; set; }

        public Operational(string busIdTripId, int desviationTime)
        {
            this.busIdTripId = busIdTripId;
            this.desviationTime = desviationTime;
        }



    


    }
}
