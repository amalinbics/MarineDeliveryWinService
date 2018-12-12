using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility;
namespace QueryBase
{
    public class MasterCommand : IQueryFetch
    {

        string Query = string.Empty;
        public string GetQuery(object command)
        {
            if (command.ToString() == QueryCommands.Master.GetCompany.ToString())
            {
                Query = "MN_GetCompany";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateCompany.ToString())
            {
                Query = "MN_UpdateCompany";
            }
            else if (command.ToString() == QueryCommands.Master.GetLoginUser.ToString())
            {
                Query = "MN_GetLoginUser";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateLoginUser.ToString())
            {
                Query = "MN_UpdateLoginUser";
            }
            else if (command.ToString() == QueryCommands.Master.GetInSite.ToString())
            {
                Query = "MN_GetINSite";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateInSite.ToString())
            {
                Query = "MN_UpdateINSite";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagInSite.ToString())
            {
                Query = "MN_UpdateSyncFlagInSite";
            }
            else if (command.ToString() == QueryCommands.Master.GetTankType.ToString())
            {
                Query = "MN_GetTankType";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateTankType.ToString())
            {
                Query = "MN_UpdateTankType";
            }
            else if (command.ToString() == QueryCommands.Master.GetInSiteTank.ToString())
            {
                Query = "MN_GetINSiteTank";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateInSiteTank.ToString())
            {
                Query = "MN_UpdateINSiteTank";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagInSiteTank.ToString())
            {
                Query = "MN_UpdateSyncFlagINSiteTank";
            }
            else if (command.ToString() == QueryCommands.Master.GetInSiteTankProducts.ToString())
            {
                Query = "MN_GetINSiteTankProducts";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateInSiteTankProducts.ToString())
            {
                Query = "MN_UpdateINSiteTankProducts";
            }
            else if (command.ToString() == QueryCommands.Master.GetInSiteTankSubCompartments.ToString())
            {
                Query = "MN_GetInSiteTankSubCompartments";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateInSiteTankSubCompartments.ToString())
            {
                Query = "MN_UpdateInSiteTankSubCompartments";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagInSiteTankSubCompartments.ToString())
            {
                Query = "MN_UpdateSyncFlagInSiteTankSubCompartments";
            }
            else if (command.ToString() == QueryCommands.Master.GetInSiteBillingItem.ToString())
            {
                Query = "MN_GetINSiteBillingItem";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateInSiteBillingItem.ToString())
            {
                Query = "MN_UpdateINSiteBillingItem";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagINSiteBillingItem.ToString())
            {
                Query = "MN_UpdateSyncFlagINSiteBillingItem";
            }
            else if (command.ToString() == QueryCommands.Master.GetProdCont.ToString())
            {
                Query = "MN_GetProdCont";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateProdCont.ToString())
            {
                Query = "MN_UpdateProdCont";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagProdCont.ToString())
            {
                Query = "MN_UpdateSyncFlagProdCont";
            }
            else if (command.ToString() == QueryCommands.Master.GetInSiteProdCont.ToString())
            {
                Query = "MN_GetInSiteProdCont";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateInSiteProdCont.ToString())
            {
                Query = "MN_UpdateINSiteProdCont";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagINSiteProdCont.ToString())
            {
                Query = "MN_UpdateSyncFlagINSiteProdCont";
            }
            else if (command.ToString() == QueryCommands.Master.GetSubProdCont.ToString())
            {
                Query = "MN_GetSubProdCont";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSubProdCont.ToString())
            {
                Query = "MN_UpdateSubProdCont";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagSubProdCont.ToString())
            {
                Query = "MN_UpdateSyncFlagSubProdCont";
            }
            else if (command.ToString() == QueryCommands.Master.GetInSiteTankProductsAPI.ToString())
            {
                Query = "MN_GetINSiteTankProductsAPI";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateInSiteTankProductAPI.ToString())
            {
                Query = "MN_UpdateINSiteTankProductAPI";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagInSiteTankProductAPI.ToString())
            {
                Query = "MN_UpdateSyncFlagINSiteTankProductAPI";
            }
            else if (command.ToString() == QueryCommands.Master.GetUOM.ToString())
            {
                Query = "MN_GetUOM";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateUOM.ToString())
            {
                Query = "MN_UpdateUOM";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagUOM.ToString())
            {
                Query = "MN_UpdateSyncFlagUOM";
            }
            else if (command.ToString() == QueryCommands.Master.GetUOMType.ToString())
            {
                Query = "MN_GetUOMType";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateUMOType.ToString())
            {
                Query = "MN_UpdateUOMType";
            }
            else if (command.ToString() == QueryCommands.Master.GetProducts.ToString())
            {
                Query = "MN_GetProducts";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateProducts.ToString())
            {
                Query = "MN_UpdateProducts";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagProduct.ToString())
            {
                Query = "MN_UpdateSyncFlagProduct";
            }
            else if (command.ToString() == QueryCommands.Master.GetVessel.ToString())
            {
                Query = "MN_GetShipToVessel";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateVessel.ToString())
            {
                Query = "MN_UpdateVessel";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagVessel.ToString())
            {
                Query = "MN_UpdateSyncFlagShipToVessel";
            }
            else if (command.ToString() == QueryCommands.Master.GetAdHocVessel.ToString())
            {
                Query = "MN_GetAdHocVessel";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateAdHocVessel.ToString())
            {
                Query = "MN_UpdateAdHocVessel";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncVesselFlag.ToString())
            {
                Query = "MN_UpdateSyncVesselFlag";
            }
            else if (command.ToString() == QueryCommands.Master.GetCarriers.ToString())
            {
                Query = "MN_GetCarriers";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateCarriers.ToString())
            {
                Query = "MN_UpdateCarrier";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagCarrier.ToString())
            {
                Query = "MN_UpdateSyncFlagCarrier";
            }
            else if (command.ToString() == QueryCommands.Master.GetDrivers.ToString())
            {
                Query = "MN_GetDrivers";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateDrivers.ToString())
            {
                Query = "MN_UpdateDrivers";
            }
            else if (command.ToString() == QueryCommands.Master.GetVehicle.ToString())
            {
                Query = "MN_GetVehicles";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateVehicle.ToString())
            {
                Query = "MN_UpdateVehicle";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagVehicle.ToString())
            {
                Query = "MN_UpdateSyncFlagVehicle";
            }
            else if (command.ToString() == QueryCommands.Master.GetVehicleCompartments.ToString())
            {
                Query = "MN_GetVehicleCompartments";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateVehicleCompartment.ToString())
            {
                Query = "MN_UpdateVehicleCompartment";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagVehicleCompartments.ToString())
            {
                Query = "MN_UpdateSyncFlagVehicleCompartments";
            }
            else if (command.ToString() == QueryCommands.Master.GetTankChart.ToString())
            {
                Query = "MN_GetTankChart";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateTankChart.ToString())
            {
                Query = "MN_UpdateTankChart";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagTankChart.ToString())
            {
                Query = "MN_UpdateSyncFlagTankChart";
            }
            else if (command.ToString() == QueryCommands.Master.GetVehicleSubCompartments.ToString())
            {
                Query = "MN_GetVehicleSubCompartments";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateVehicleSubCompartments.ToString())
            {
                Query = "MN_UpdateVehicleSubCompartment";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagVehicleSubCompartments.ToString())
            {
                Query = "MN_UpdateSyncFlagVehicleSubCompartments";
            }
            else if (command.ToString() == QueryCommands.Master.GetMarineLocType.ToString())
            {
                Query = "MN_GetMarineLocType";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateMarineLocType.ToString())
            {
                Query = "MN_UpdateMarineLocType";
            }
            else if (command.ToString() == QueryCommands.Master.GetMarineRegion.ToString())
            {
                Query = "MN_GetMarineRegion";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateMarineRegion.ToString())
            {
                Query = "MN_UpdateMarineRegion";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagMarineRegion.ToString())
            {
                Query = "MN_UpdateSyncFlagMarineRegion";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagMarineRegion.ToString())
            {
                Query = "MN_GetMarineLoc";
            }
            else if (command.ToString() == QueryCommands.Master.GetMarineLocation.ToString())
            {
                Query = "MN_GetMarineLoc";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateMarineLocation.ToString())
            {
                Query = "MN_UpdateMarineLoc";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagMarineLocation.ToString())
            {
                Query = "MN_UpdateSyncFlagMarineLoc";
            }
            else if (command.ToString() == QueryCommands.Master.GetMarineAppSalesPLUButtons.ToString())
            {
                Query = "MN_GetSalesPLUButtons";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateMarineAppSalesPLUButtons.ToString())
            {
                Query = "MN_UpdateMarineAppSalesPLUButtons";
            }
            else if (command.ToString() == QueryCommands.Master.GetARShipTo.ToString())
            {
                Query = "MN_GetARShipTo";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateARShipTo.ToString())
            {
                Query = "MN_UpdateARShipTo";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagARShipTo.ToString())
            {
                Query = "MN_UpdateSyncFlagARShipTo "; 
            }
            else if (command.ToString() == QueryCommands.Master.GetPerson.ToString())
            {
                Query = "MN_GetPerson";
            }
            else if (command.ToString() == QueryCommands.Master.UpdatePerson.ToString())
            {
                Query = "MN_UpdatePerson";
            }
            else if (command.ToString() == QueryCommands.Master.GetPersonPhone.ToString())
            {
                Query = "MN_GetPersonPhone ";
            }
            else if (command.ToString() == QueryCommands.Master.UpdatePersonPhone.ToString())
            {
                Query = "MN_UpdatePersonPhone";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagPersonPhone.ToString())
            {
                Query = "MN_UpdateSyncFlagPersonPhone";
            }
            else if (command.ToString() == QueryCommands.Master.GetTankChartDetails.ToString())
            {
                Query = "MN_GetTankChartDetails ";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateTankChartDetails.ToString())
            {
                Query = "MN_UpdateTankChartDetail";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagTankChartDetail.ToString())
            {
                Query = "MN_UpdateSyncFlagTankChartDetail";
            }
            else if (command.ToString() == QueryCommands.Master.GetTankChartKeel.ToString())
            {
                Query = "MN_GetTankChartKeel ";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateTankChartKeel.ToString())
            {
                Query = "MN_UpdateTankChartKeel";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagTankChartKeel.ToString())
            {
                Query = "MN_UpdateSyncFlagTankChartKeel";
            }
            else if (command.ToString() == QueryCommands.Master.GetTankChartTrim.ToString())
            {
                Query = "MN_GetTankChartTrim ";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateTankChartTrim.ToString())
            {
                Query = "MN_UpdateTankChartTrim";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncFlagTankChartTrim.ToString())
            {
                Query = "MN_UpdateSyncFlagTankChartTrim";
            }
            else if (command.ToString() == QueryCommands.Master.GetInSiteTankVolume.ToString())
            {
                Query = "MN_GetINSiteTankVolume";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateInSiteTankVolume.ToString())
            {
                Query = "MN_UpdateINSiteTankVolume";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateInSiteTankVolumeIsUpdatedFlag.ToString())
            {
                Query = "MN_UpdateINSiteTankVolumeIsUpdatedFlag";
            }
            else if (command.ToString() == QueryCommands.Master.GetSyncDeletedTrx.ToString())
            {
                Query = "MN_GetSyncDeletedTrx";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncDeletedTrx.ToString())
            {
                Query = "MN_UpdateSyncDeleted";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateSyncDeletedTrxIsUpdatedFlag.ToString())
            {
                Query = "MN_UpdateSyncDeletedIsUpdatedFlag";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateTankChartDetailsNew.ToString())
            {
                Query = "MN_UpdateTankChartNew";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateInSiteProdContNew.ToString())
            {
                Query = "MN_UpdateINSiteProdContNew";
            }           
            else if (command.ToString() == QueryCommands.Master.GetOrderAttachment.ToString())
            {
                Query = "MN_GetOrderAttachement";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateOrderAttachment.ToString())
            {
                Query = "MN_UpdateOrderNotesAttachment";
            }
            else if (command.ToString() == QueryCommands.Master.DeleteINSiteTankProducts.ToString())
            {
                Query = "MN_DeleteINSiteTankProducts";
            }
            else if (command.ToString() == QueryCommands.Master.DeleteOrderAttachment.ToString())
            {
                Query = "MN_DeleteOrderAttachment";
            }
            else if (command.ToString() == QueryCommands.Master.UpdateDocLogo.ToString())
            {
                Query = "MN_UpdateDocLogo";
            }

            return Query;
        }
    }
}
