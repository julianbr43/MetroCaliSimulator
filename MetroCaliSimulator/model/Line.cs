using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroCaliSimulator.model
{
    [Serializable]
    class Line
    {

        public int lineId { get; set; }
        public int planVersionId { get; set; }
        public string shortName { get; set; }
        public string description { get; set; }

        public Line(int lineId, int planVersionId, string shortName, string description)
        {
            this.lineId = lineId;
            this.planVersionId = planVersionId;
            this.shortName = shortName;
            this.description = description;
        }
    }
}
