using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarineDeliveryWinService.Entity
{
    public class VehicleSubCompartmentsDeletedTrx
    {       
        public int CompartmentID { get; set; }
        public char ReadingSide { get; set; }
        public int? TankChartID { get; set; }
        public string TableName { get; set; }
    }
}
