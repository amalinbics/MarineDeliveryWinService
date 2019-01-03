using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarineDeliveryWinService.Entity
{
    public class SalesContractSalesAlias
    {
        
        public int SysTrxNo { get; set; }
        public int SysTrxLine { get; set; }
        public int ShiptoID { get; set; }
        public int StandardAcctID { get; set; }
        public string ContractID { get; set; }
        public string ContractDescr { get; set; }
        public int SalesAliasID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string VendorProductxRef { get; set; }
        public string CompanyID { get; set; }

    }
}
