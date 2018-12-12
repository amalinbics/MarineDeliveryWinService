using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarineDeliveryWinService.Entity
{
    public class DeliveryTicket
    {
        public int? ID { get; set; }
        public string OrderNo { get; set; }
        public string DeviceTime { get; set; }
        public string DeliveryImage { get; set; }
        public string CreatedDate { get; set; }
        public int NeedUpdate { get; set; }
        public string FileName { get; set; }
        public string CustomerID { get; set; }
        public string CompanyID { get; set; }
    }
}
