using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarineDeliveryWinService.Entity
{
    public class Attachment
    {
        public int ID { get; set; }
        public string OrderNo { get; set; }
        public int SysTrxNo { get; set; }
        public string CreatedDate { get; set; }
        public string DeviceTime { get; set; }
        public string AttachmentFile { get; set; }
        public string CustomerID { get; set; }
        public string AttachmentName { get; set; }
        public int NeedUpdate { get; set; }
        public string FileName { get; set; }
        public string File { get; set; }
        public string Status { get; set; }
        public string CompanyID { get; set; }
    }
}