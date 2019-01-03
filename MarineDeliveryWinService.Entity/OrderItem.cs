﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarineDeliveryWinService.Entity
{
    public class OrderItem
    {
        public int SysTrxNo { get; set; }
        public int SysTrxLine { get; set; }
        public int MasterProdID { get; set; }
        public int? MasterSiteID { get; set; }
        public decimal Qty { get; set; }
        public char Priority { get; set; }
        public string Status { get; set; }
        public string DtTm { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? UnitPriceKeyed { get; set; }
        public string RequestedDtTm { get; set; }
        public string PromisedDtTm { get; set; }
        public string Notes { get; set; }
        public string CustomerID { get; set; }
        public int? ShipToTankID { get; set; }
        public decimal? AdditionalCost { get; set; }
        public decimal? RackPriceKeyed { get; set; }
        public int? ARShipToTankID { get; set; }
        public string PONo { get; set; }
        public string ClientID { get; set; }
        public int? BillToShiptoID { get; set; }
        public string VendorProductxRef { get; set; }
    }
}
