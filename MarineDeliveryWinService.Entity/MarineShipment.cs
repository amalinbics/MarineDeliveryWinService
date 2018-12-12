using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarineDeliveryWinService.Entity
{
    public class MarineShipment
    {
        public int SessionID {get; set;}
        public int? OrderSysTrxNo {get; set;}
        public string LoadNo {get; set;}
        public string ShipDtTm {get; set;}
        public int? MasterSiteID {get; set;}
        public int CarrierID {get; set;}
        public int VehicleID {get; set;}
        public string DocumentNo {get; set;}
        public char DocumentType {get; set;}
        public string CustomerID { get; set; }
        public string DeliveryDtTm { get; set; }
        public int? MarineLocID { get; set; }
        public int? PersonID { get; set; }
    }
}
