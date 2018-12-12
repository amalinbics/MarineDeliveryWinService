using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility;
namespace QueryBase
{
    public class QueryFetch : IQueryFetch
    {
        public string Query { get; set; }

        public string GetQuery(object command)
        {
            try
            {
                string name = command.GetType().Name;

                if (name == QueryCommands.QueryCommandKey.Master.ToString())
                {
                    MasterCommand masterCommands = new MasterCommand();
                    Query = masterCommands.GetQuery(command);
                }
                else if (name == QueryCommands.QueryCommandKey.Order.ToString())
                {
                    OrderCommand orderCommand = new OrderCommand();
                    Query = orderCommand.GetQuery(command);
                }
                else if (name == QueryCommands.QueryCommandKey.Shipment.ToString())
                {
                    ShipmentCommand shipmentCommand = new ShipmentCommand();
                    Query = shipmentCommand.GetQuery(command);
                }

            }
            catch (Exception ex)
            {
                string exception = ex.Message;
            }
            return Query;
        }
    }
}
