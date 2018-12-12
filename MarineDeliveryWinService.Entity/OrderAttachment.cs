using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarineDeliveryWinService.Entity
{
    public class OrderAttachment
    {
        public string env { get; set; }
        public string OrderNo { get; set; }
        public string attachementData { get; set; }
        public string name { get; set; }
        public string type { get; set; }         
    }
}
