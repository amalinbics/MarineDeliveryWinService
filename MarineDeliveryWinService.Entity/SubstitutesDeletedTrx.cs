using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarineDeliveryWinService.Entity
{
    public class SubstitutesDeletedTrx
    {
        public int ProdContID { get; set; }
        public int SubProdContID { get; set; }
        public string TableName { get; set; }
    }
}
