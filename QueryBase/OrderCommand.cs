using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility;

namespace QueryBase
{
    public class OrderCommand : IQueryFetch
    {
        string Query = string.Empty;
        public string GetQuery(object command)
        {
            if (command.ToString() == QueryCommands.Order.GetOrderHdr.ToString())
            {
                Query = "MN_GetOrderHdr";
            }
            else if (command.ToString() == QueryCommands.Order.GetOrderItem.ToString())
            {
                Query = "MN_GetOrderItem";
            }
            else if (command.ToString() == QueryCommands.Order.GetOrderItemComponent.ToString())
            {
                Query = "MN_GetOrderItemComponent";
            }
            else if (command.ToString() == QueryCommands.Order.GetOrderNotes.ToString())
            {
                Query = "MN_GetOrderNotesUpdate";
            }
            else if (command.ToString() == QueryCommands.Order.UpdateOrderDetails.ToString())
            {
                Query = "MN_UpdateOrderDetails";
            }
            else if (command.ToString() == QueryCommands.Order.UpdateOrderDetailsNeedUpdateFlag.ToString())
            {
                Query = "MN_UpdateOrderDetailsNeedUpdateFlag";
            }

            else if (command.ToString() == QueryCommands.Order.UpdateOrderDetailsNeedUpdateFlag.ToString())
            {
                Query = "MN_UpdateOrderDetailsNeedUpdateFlag";
            }

            else if (command.ToString() == QueryCommands.Order.GetClientOrderHdr.ToString())
            {
                Query = "MN_GetClientOrderHdr";
            }
            else if (command.ToString() == QueryCommands.Order.GetClientOrderItem.ToString())
            {
                Query = "MN_GetClientOrderItem";
            }
            else if (command.ToString() == QueryCommands.Order.GetClientOrderItemComponent.ToString())
            {
                Query = "MN_GetClientOrderItemComponent";
            }
            else if (command.ToString() == QueryCommands.Order.GetClientOrderNote.ToString())
            {
                Query = "MN_GetClientOrderNote";
            }
            else if (command.ToString() == QueryCommands.Order.UpdateClientOrderDetails.ToString())
            {
                Query = "MN_UpdateClientOrderDetails";
            }
            else if (command.ToString() == QueryCommands.Order.UpdateLoadStatus.ToString())
            {
                Query = "MN_UpdateLoadStatus";
            }
            else if (command.ToString() == QueryCommands.Order.GetOrderStatusHistory.ToString())
            {
                Query = "MN_GetOrderStatusToUpdate";  
            }
             else if (command.ToString() == QueryCommands.Order.UpdateOrderStatusHistoryNeedUpdateFlag.ToString())
            {
                Query = "MN_UpdateOrderStatusNeedUpdateFlag";  
            }
            return Query;
        }
    }
}
