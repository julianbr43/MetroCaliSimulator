using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroCaliSimulator.model
{
     [Serializable]
     class Bus
    {
       
        public DateTime dataGramDate { get; set; }
        public int stopId { get; set; }
        public int odometer { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int taskId { get; set; }
        public int lineId { get; set; }
        public int tripId { get; set; }
        public int dataGramId { get; set; }
        public int busId { get; set; }

        public Bus(DateTime dataGramDate, int stopId, int odometer, double latitude, double longitude, int taskId, int lineId, int tripId, int dataGramId, int busId)
        {
            this.dataGramDate = dataGramDate;
            this.stopId = stopId;
            this.odometer = odometer;
            this.latitude = latitude;
            this.longitude = longitude;
            this.taskId = taskId;
            this.lineId = lineId;
            this.tripId = tripId;
            this.dataGramId = dataGramId;
            this.busId = busId;
        }


    }
}
