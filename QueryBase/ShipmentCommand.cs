using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility;

namespace QueryBase
{
    class ShipmentCommand : IQueryFetch
    {
        string Query = string.Empty;
        public string GetQuery(object command)
        {
            if (command.ToString() == QueryCommands.Shipment.GetShipDoc.ToString())
            {
                Query = "MN_GetShipDoc";
            }
            else if (command.ToString() == QueryCommands.Shipment.GetShipDocItem.ToString())
            {
                Query = "MN_GetShipDocItem";
            }
            else if (command.ToString() == QueryCommands.Shipment.GetShipDocItemComp.ToString())
            {
                Query = "MN_GetShipDocItemComp";
            }
            else if (command.ToString() == QueryCommands.Shipment.GetShipDocItemReading.ToString())
            {
                Query = "MN_GetShipDocItemReading";
            }
            else if (command.ToString() == QueryCommands.Shipment.GetShipDocItemReadingDetail.ToString())
            {
                Query = "MN_GetShipDocItemReadingDtl";
            }
            else if (command.ToString() == QueryCommands.Shipment.GetShipmentDetails.ToString())
            {
                Query = "MN_GetShipmentLoad";
            }
            else if (command.ToString() == QueryCommands.Shipment.GetShipmentLoadDetails.ToString())
            {
                Query = "MN_GetShipmentLoadDetail";
            }
            else if (command.ToString() == QueryCommands.Shipment.UpdateShipmentDetails.ToString())
            {
                Query = "MN_UpdateShipmentDetails";
            }
            else if (command.ToString() == QueryCommands.Shipment.UpdateShipmentDetailsReview.ToString())
            {
                Query = "MN_UpdateShipmentDetailsReview";
            }
            else if (command.ToString() == QueryCommands.Shipment.UpdateShipmentReadingDetailsNeedUpdateFlag.ToString())
            {
                Query = "MN_UpdateShipmentReadingDetailsNeedUpdateFlag";
            }
            else if (command.ToString() == QueryCommands.Shipment.UpdateShipmentDetailsNeedUpdateFlag.ToString())
            {
                Query = "MN_UpdateShipmentDetailsNeedUpdateFlag";
            }
            else if (command.ToString() == QueryCommands.Shipment.GetShipDocItemVessel.ToString())
            {
                Query = "MN_GetShipDocItemVessel";
            }
            else if (command.ToString() == QueryCommands.Shipment.UpdateDeliveryDetails.ToString())
            {
                Query = "MN_UpdateDeliveryDetails";
            }
            else if (command.ToString() == QueryCommands.Shipment.UpdateDeliveryDetailsNeedUpdateFlag.ToString())
            {
                Query = "MN_UpdateDeliveryDetailsNeedUpdateFlag";
            }
            else if (command.ToString() == QueryCommands.Shipment.UpdateDeliveryDetailsLineUpdateFlag.ToString())
            {
                Query = "MN_UpdateShipDocItemLine"; 
            }
            else if (command.ToString() == QueryCommands.Shipment.UpdateDeliveryReadingDetailsNeedUpdateFlag.ToString())
            {
                Query = "MN_UpdateDeliveryReadingDetailsNeedUpdateFlag"; 
            }
            else if (command.ToString() == QueryCommands.Shipment.UpdateDeliveryDetailsReview.ToString())
            {
                Query = "MN_UpdateDeliveryDetailsReview"; 
            }
            else if (command.ToString() == QueryCommands.Shipment.GetMeterTicket.ToString())
            {
                Query = "MN_GetMeterTicket";
            }
            else if (command.ToString() == QueryCommands.Shipment.UpdateMeterTicker.ToString())
            {
                Query = "MN_UpdateMeterTicket";
            }
            else if (command.ToString() == QueryCommands.Shipment.UpdateNeedUpdateMeterTicket.ToString())
            {
                Query = "MN_NeedUpdateFlagMeterTicket";
            }

            else if (command.ToString() == QueryCommands.Shipment.GetDOI.ToString())
            {
                Query = "MN_GetDOIUpdate";
            }
            else if (command.ToString() == QueryCommands.Shipment.UpdateDOI.ToString())
            {
                Query = "MN_UpdateDOI";
            }
            else if (command.ToString() == QueryCommands.Shipment.UpdateDOINeedUpdate.ToString())
            {
                Query = "MN_NeedUpdateFlagDOI";
            }
            else if (command.ToString() == QueryCommands.Shipment.GetDeliveryTicket.ToString())
            {
                Query = "MN_GetDeliveryTicketUpdate";
            }
            else if (command.ToString() == QueryCommands.Shipment.UpdateDeliveryTicket.ToString())
            {
                Query = "MN_UpdateDeliveryTicket";
            }
            else if (command.ToString() == QueryCommands.Shipment.UpdateNeedUpdateDeliveryTicket.ToString())
            {
                Query = "MN_NeedUpdateFlagDeliveryTicket";
            }

            else if (command.ToString() == QueryCommands.Shipment.GetAttachment.ToString())
            {
                Query = "MN_GetAttachment";
            }
            else if (command.ToString() == QueryCommands.Shipment.UpdateAttachment.ToString())
            {
                Query = "MN_UpdateAttachment";
            }
            else if (command.ToString() == QueryCommands.Shipment.UpdateNeedUpdateAttachment.ToString())
            {
                Query = "MN_NeedUpdateFlagAttachment";
            }

            else if (command.ToString() == QueryCommands.Shipment.GetDcoMessage.ToString())
            {
                Query = "MN_GetDocMessage";
            }
            else if (command.ToString() == QueryCommands.Shipment.UpdateDcoMessage.ToString())
            {
                Query = "MN_UpdateDocMessage";
            }


            else if (command.ToString() == QueryCommands.Shipment.GetDeliveryShipDoc.ToString())
            {
                Query = "MN_GetDeliveryDoc";
            }           
            else if (command.ToString() == QueryCommands.Shipment.GetDeliveryDocItem.ToString())
            {
                Query = "MN_GetDeliveryDocItem";
            }
            else if (command.ToString() == QueryCommands.Shipment.GetDeliveryDocItemComp.ToString())
            {
                Query = "MN_GetDeliveryDocItemComp";
            }
            else if (command.ToString() == QueryCommands.Shipment.GetDeliveryDocItemReading.ToString())
            {
                Query = "MN_GetDeliveryDocItemReading";
            }
            else if (command.ToString() == QueryCommands.Shipment.GetDeliveryDocItemReadingDtl.ToString())
            {
                Query = "MN_GetDeliveryDocItemReadingDtl";
            }
            else if (command.ToString() == QueryCommands.Shipment.GetDelivery.ToString())
            {
                Query = "MN_GetDelivery";
            }
            else if (command.ToString() == QueryCommands.Shipment.GetDeliveryDetail.ToString())
            {
                Query = "MN_GetDeliveryDetail";
            }
            
            return Query;
        }
    }
}
