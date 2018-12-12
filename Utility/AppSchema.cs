using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility
{
    public class AppSchema
    {


        private dsMarineDeliveryApp _MarineAppSchema = null;
        public dsMarineDeliveryApp MarineAppSchema
        {
            get
            {
                if (_MarineAppSchema == null)
                {
                    _MarineAppSchema = new dsMarineDeliveryApp();
                }
                return _MarineAppSchema;
            }
        }

        private dsMarineDeliveryApp.dtParameterDataTable _Parameter = null;
        public dsMarineDeliveryApp.dtParameterDataTable Parameter
        {
            get
            {
                if (_Parameter == null)
                {
                    _Parameter = new dsMarineDeliveryApp.dtParameterDataTable();
                }
                return _Parameter;
            }
        }

        private dsMarineDeliveryApp.dtStatusDataTable _Status = null;
        public dsMarineDeliveryApp.dtStatusDataTable Status
        {
            get
            {
                if (_Status == null)
                {
                    _Status = new dsMarineDeliveryApp.dtStatusDataTable();
                }
                return _Status;
            }
        }


        private dsMarineDeliveryApp.dtMarineLocationDataTable _MarineLocation = null;
        public dsMarineDeliveryApp.dtMarineLocationDataTable MarineLocation
        {
            get
            {
                if (_MarineLocation == null)
                {
                    _MarineLocation = new dsMarineDeliveryApp.dtMarineLocationDataTable();
                }
                return _MarineLocation;
            }
        }

        private dsMarineDeliveryApp.dtMarineAppSalesPLUButtonDataTable _MarineAppSalesPLUButton = null;
        public dsMarineDeliveryApp.dtMarineAppSalesPLUButtonDataTable MarineAppSalesPLUButton
        {
            get
            {
                if (_MarineAppSalesPLUButton == null)
                {
                    _MarineAppSalesPLUButton = new dsMarineDeliveryApp.dtMarineAppSalesPLUButtonDataTable();
                }
                return _MarineAppSalesPLUButton;
            }
        }

        private dsMarineDeliveryApp.dtARShipToDataTable _ARShipTo = null;
        public dsMarineDeliveryApp.dtARShipToDataTable ARShipTo
        {
            get
            {
                if (_ARShipTo == null)
                {
                    _ARShipTo = new dsMarineDeliveryApp.dtARShipToDataTable();
                }
                return _ARShipTo;
            }
        }

        private dsMarineDeliveryApp.dtPersonDataTable _Person = null;
        public dsMarineDeliveryApp.dtPersonDataTable Person
        {
            get
            {
                if (_Person == null)
                {
                    _Person = new dsMarineDeliveryApp.dtPersonDataTable();
                }
                return _Person;
            }
        }

        private dsMarineDeliveryApp.dtPersonPhoneDataTable _PersonPhone = null;
        public dsMarineDeliveryApp.dtPersonPhoneDataTable PersonPhone
        {
            get
            {
                if (_PersonPhone == null)
                {
                    _PersonPhone = new dsMarineDeliveryApp.dtPersonPhoneDataTable();
                }
                return _PersonPhone;
            }
        }


        private dsMarineDeliveryApp.dtTankChartDetailDataTable _TankChartDetail = null;
        public dsMarineDeliveryApp.dtTankChartDetailDataTable TankChartDetail
        {
            get
            {
                if (_TankChartDetail == null)
                {
                    _TankChartDetail = new dsMarineDeliveryApp.dtTankChartDetailDataTable();
                }
                return _TankChartDetail;
            }
        }

        private dsMarineDeliveryApp.dtTankChartKeelDataTable _TankChartKeel = null;
        public dsMarineDeliveryApp.dtTankChartKeelDataTable TankChartKeel
        {
            get
            {
                if (_TankChartKeel == null)
                {
                    _TankChartKeel = new dsMarineDeliveryApp.dtTankChartKeelDataTable();
                }
                return _TankChartKeel;
            }
        }

        private dsMarineDeliveryApp.dtTankChartTrimDataTable _TankChartTrim = null;
        public dsMarineDeliveryApp.dtTankChartTrimDataTable TankChartTrim
        {
            get
            {
                if (_TankChartTrim == null)
                {
                    _TankChartTrim = new dsMarineDeliveryApp.dtTankChartTrimDataTable();
                }
                return _TankChartTrim;
            }
        }

        private dsMarineDeliveryApp.dtOrderHdrDataTable _OrderHdr = null;
        public dsMarineDeliveryApp.dtOrderHdrDataTable OrderHdr
        {
            get
            {
                if (_OrderHdr == null)
                {
                    _OrderHdr = new dsMarineDeliveryApp.dtOrderHdrDataTable();
                }
                return _OrderHdr;
            }
        }

        private dsMarineDeliveryApp.dtOrderItemDataTable _OrderItem = null;
        public dsMarineDeliveryApp.dtOrderItemDataTable OrderItem
        {
            get
            {
                if (_OrderItem == null)
                {
                    _OrderItem = new dsMarineDeliveryApp.dtOrderItemDataTable();
                }
                return _OrderItem;
            }
        }

        private dsMarineDeliveryApp.dtOrderItemComponentDataTable _OrderItemComponent = null;
        public dsMarineDeliveryApp.dtOrderItemComponentDataTable OrderItemComponent
        {
            get
            {
                if (_OrderItemComponent == null)
                {
                    _OrderItemComponent = new dsMarineDeliveryApp.dtOrderItemComponentDataTable();
                }
                return _OrderItemComponent;
            }
        }

        private dsMarineDeliveryApp.dtOrderNotesDataTable _OrderNotes = null;
        public dsMarineDeliveryApp.dtOrderNotesDataTable OrderNotes
        {
            get
            {
                if (_OrderNotes == null)
                {
                    _OrderNotes = new dsMarineDeliveryApp.dtOrderNotesDataTable();
                }
                return _OrderNotes;
            }
        }

        private dsMarineDeliveryApp.dtOrderStatusHistoryDataTable _OrderStatusHistory = null;
        public dsMarineDeliveryApp.dtOrderStatusHistoryDataTable OrderStatusHistory
        {
            get
            {
                if (_OrderStatusHistory == null)
                {
                    _OrderStatusHistory = new dsMarineDeliveryApp.dtOrderStatusHistoryDataTable();
                }
                return _OrderStatusHistory;
            }
        }

        private dsMarineDeliveryApp.dtMarineShipmentDataTable _MarineShipment = null;
        public dsMarineDeliveryApp.dtMarineShipmentDataTable MarineShipment
        {
            get
            {
                if (_MarineShipment == null)
                {
                    _MarineShipment = new dsMarineDeliveryApp.dtMarineShipmentDataTable();
                }
                return _MarineShipment;
            }
        }

        private dsMarineDeliveryApp.dtMarineShipmentDetailDataTable _MarineShipmentDetail = null;
        public dsMarineDeliveryApp.dtMarineShipmentDetailDataTable MarineShipmentDetail
        {
            get
            {
                if (_MarineShipmentDetail == null)
                {
                    _MarineShipmentDetail = new dsMarineDeliveryApp.dtMarineShipmentDetailDataTable();
                }
                return _MarineShipmentDetail;
            }
        }

        private dsMarineDeliveryApp.dtShipDocDataTable _ShipDoc = null;
        public dsMarineDeliveryApp.dtShipDocDataTable ShipDoc
        {
            get
            {
                if (_ShipDoc == null)
                {
                    _ShipDoc = new dsMarineDeliveryApp.dtShipDocDataTable();
                }
                return _ShipDoc;
            }
        }

        private dsMarineDeliveryApp.dtShipDocItemDataTable _ShipDocItem = null;
        public dsMarineDeliveryApp.dtShipDocItemDataTable ShipDocItem
        {
            get
            {
                if (_ShipDocItem == null)
                {
                    _ShipDocItem = new dsMarineDeliveryApp.dtShipDocItemDataTable();
                }
                return _ShipDocItem;
            }
        }

        private dsMarineDeliveryApp.dtShipDocItemCompDataTable _ShipDocItemComp = null;
        public dsMarineDeliveryApp.dtShipDocItemCompDataTable ShipDocItemComp
        {
            get
            {
                if (_ShipDocItemComp == null)
                {
                    _ShipDocItemComp = new dsMarineDeliveryApp.dtShipDocItemCompDataTable();
                }
                return _ShipDocItemComp;
            }
        }

        private dsMarineDeliveryApp.dtShipDocItemReadingDataTable _ShipDocItemReading = null;
        public dsMarineDeliveryApp.dtShipDocItemReadingDataTable ShipDocItemReading
        {
            get
            {
                if (_ShipDocItemReading == null)
                {
                    _ShipDocItemReading = new dsMarineDeliveryApp.dtShipDocItemReadingDataTable();
                }
                return _ShipDocItemReading;
            }
        }

        private dsMarineDeliveryApp.dtShipDocItemReadingDetailDataTable _ShipDocItemReadingDetail = null;
        public dsMarineDeliveryApp.dtShipDocItemReadingDetailDataTable ShipDocItemReadingDetail
        {
            get
            {
                if (_ShipDocItemReadingDetail == null)
                {
                    _ShipDocItemReadingDetail = new dsMarineDeliveryApp.dtShipDocItemReadingDetailDataTable();
                }
                return _ShipDocItemReadingDetail;
            }
        }

        private dsMarineDeliveryApp.dtShipItemVesselDataTable _ShipItemVessel = null;
        public dsMarineDeliveryApp.dtShipItemVesselDataTable ShipItemVessel
        {
            get
            {
                if (_ShipItemVessel == null)
                {
                    _ShipItemVessel = new dsMarineDeliveryApp.dtShipItemVesselDataTable();
                }
                return _ShipItemVessel;
            }
        }

        private dsMarineDeliveryApp.dtShipDocItemVesselDataTable _ShipDocItemVessel = null;
        public dsMarineDeliveryApp.dtShipDocItemVesselDataTable ShipDocItemVessel
        {
            get
            {
                if (_ShipDocItemVessel == null)
                {
                    _ShipDocItemVessel = new dsMarineDeliveryApp.dtShipDocItemVesselDataTable();
                }
                return _ShipDocItemVessel;
            }
        }

        private dsMarineDeliveryApp.dtMeterTicketDataTable _MeterTicket = null;
        public dsMarineDeliveryApp.dtMeterTicketDataTable MeterTicket
        {
            get
            {
                if (_MeterTicket == null)
                {
                    _MeterTicket = new dsMarineDeliveryApp.dtMeterTicketDataTable();
                }
                return _MeterTicket;
            }
        }

        private dsMarineDeliveryApp.dtDOIDataTable _DOI = null;
        public dsMarineDeliveryApp.dtDOIDataTable DOI
        {
            get
            {
                if (_DOI == null)
                {
                    _DOI = new dsMarineDeliveryApp.dtDOIDataTable();
                }
                return _DOI;

            }
        }

        private dsMarineDeliveryApp.dtDeliveryTicketDataTable _DeliveryTicket = null;
        public dsMarineDeliveryApp.dtDeliveryTicketDataTable DeliveryTicket
        {
            get
            {
                if (_DeliveryTicket == null)
                {
                    _DeliveryTicket = new dsMarineDeliveryApp.dtDeliveryTicketDataTable();
                }
                return _DeliveryTicket;

            }
        }

        private dsMarineDeliveryApp.dtAttachmentDataTable _Attachment = null;
        public dsMarineDeliveryApp.dtAttachmentDataTable Attachment
        {
            get
            {
                if (_Attachment == null)
                {
                    _Attachment = new dsMarineDeliveryApp.dtAttachmentDataTable();
                }
                return _Attachment;

            }
        }

        private dsMarineDeliveryApp.dtDocMessageDataTable _DocMessage = null;
        public dsMarineDeliveryApp.dtDocMessageDataTable DocMessage
        {
            get
            {
                if (_DocMessage == null)
                {
                    _DocMessage = new dsMarineDeliveryApp.dtDocMessageDataTable();
                }
                return _DocMessage;

            }
        }

        private dsMarineDeliveryApp.dtCompanyDataTable _Company = null;
        public dsMarineDeliveryApp.dtCompanyDataTable Company
        {
            get
            {
                if (_Company == null)
                {
                    _Company = new dsMarineDeliveryApp.dtCompanyDataTable();
                }
                return _Company;

            }
        }

        private dsMarineDeliveryApp.dtLoginUserDataTable _LoginUser = null;
        public dsMarineDeliveryApp.dtLoginUserDataTable LoginUser
        {
            get
            {
                if (_LoginUser == null)
                {
                    _LoginUser = new dsMarineDeliveryApp.dtLoginUserDataTable();
                }
                return _LoginUser;

            }
        }

        private dsMarineDeliveryApp.dtInSiteDataTable _InSite = null;
        public dsMarineDeliveryApp.dtInSiteDataTable InSite
        {
            get
            {
                if (_InSite == null)
                {
                    _InSite = new dsMarineDeliveryApp.dtInSiteDataTable();
                }
                return _InSite;

            }
        }

        private dsMarineDeliveryApp.dtTankTypeDataTable _TankType = null;
        public dsMarineDeliveryApp.dtTankTypeDataTable TankType
        {
            get
            {
                if (_TankType == null)
                {
                    _TankType = new dsMarineDeliveryApp.dtTankTypeDataTable();
                }
                return _TankType;

            }
        }

        private dsMarineDeliveryApp.dtInSiteTankDataTable _InSiteTank = null;
        public dsMarineDeliveryApp.dtInSiteTankDataTable InSiteTank
        {
            get
            {
                if (_InSiteTank == null)
                {
                    _InSiteTank = new dsMarineDeliveryApp.dtInSiteTankDataTable();
                }
                return _InSiteTank;

            }
        }

        private dsMarineDeliveryApp.dtInSiteTankProductDataTable _InSiteTankProduct = null;
        public dsMarineDeliveryApp.dtInSiteTankProductDataTable InSiteTankProduct
        {
            get
            {
                if (_InSiteTankProduct == null)
                {
                    _InSiteTankProduct = new dsMarineDeliveryApp.dtInSiteTankProductDataTable();
                }
                return _InSiteTankProduct;

            }
        }

        private dsMarineDeliveryApp.dtInSiteTankSubCompartmentDataTable _InSiteTankSubCompartment = null;
        public dsMarineDeliveryApp.dtInSiteTankSubCompartmentDataTable InSiteTankSubCompartment
        {
            get
            {
                if (_InSiteTankSubCompartment == null)
                {
                    _InSiteTankSubCompartment = new dsMarineDeliveryApp.dtInSiteTankSubCompartmentDataTable();
                }
                return _InSiteTankSubCompartment;

            }
        }

        private dsMarineDeliveryApp.dtInSiteBillingItemDataTable _InSiteBillingItem = null;
        public dsMarineDeliveryApp.dtInSiteBillingItemDataTable InSiteBillingItem
        {
            get
            {
                if (_InSiteBillingItem == null)
                {
                    _InSiteBillingItem = new dsMarineDeliveryApp.dtInSiteBillingItemDataTable();
                }
                return _InSiteBillingItem;

            }
        }

        private dsMarineDeliveryApp.dtProdContDataTable _ProdCont = null;
        public dsMarineDeliveryApp.dtProdContDataTable ProdCont
        {
            get
            {
                if (_ProdCont == null)
                {
                    _ProdCont = new dsMarineDeliveryApp.dtProdContDataTable();
                }
                return _ProdCont;

            }
        }

        private dsMarineDeliveryApp.dtInSiteProdContDataTable _InSiteProdCont = null;
        public dsMarineDeliveryApp.dtInSiteProdContDataTable InSiteProdCont
        {
            get
            {
                if (_InSiteProdCont == null)
                {
                    _InSiteProdCont = new dsMarineDeliveryApp.dtInSiteProdContDataTable();
                }
                return _InSiteProdCont;

            }
        }

        private dsMarineDeliveryApp.dtSubProdContDataTable _SubProdCont = null;
        public dsMarineDeliveryApp.dtSubProdContDataTable SubProdCont
        {
            get
            {
                if (_SubProdCont == null)
                {
                    _SubProdCont = new dsMarineDeliveryApp.dtSubProdContDataTable();
                }
                return _SubProdCont;
            }
        }

        private dsMarineDeliveryApp.dtInSiteTankProductAPIDataTable _InSiteTankProductAPI = null;
        public dsMarineDeliveryApp.dtInSiteTankProductAPIDataTable InSiteTankProductAPI
        {
            get
            {
                if (_InSiteTankProductAPI == null)
                {
                    _InSiteTankProductAPI = new dsMarineDeliveryApp.dtInSiteTankProductAPIDataTable();
                }
                return _InSiteTankProductAPI;
            }
        }

        private dsMarineDeliveryApp.dtUOMDataTable _UOM = null;
        public dsMarineDeliveryApp.dtUOMDataTable UOM
        {
            get
            {
                if (_UOM == null)
                {
                    _UOM = new dsMarineDeliveryApp.dtUOMDataTable();
                }
                return _UOM;
            }
        }

        private dsMarineDeliveryApp.dtUOMTypeDataTable _UOMType = null;
        public dsMarineDeliveryApp.dtUOMTypeDataTable UOMType
        {
            get
            {
                if (_UOMType == null)
                {
                    _UOMType = new dsMarineDeliveryApp.dtUOMTypeDataTable();
                }
                return _UOMType;
            }
        }


        private dsMarineDeliveryApp.dtProductDataTable _Product = null;
        public dsMarineDeliveryApp.dtProductDataTable Product
        {
            get
            {
                if (_Product == null)
                {
                    _Product = new dsMarineDeliveryApp.dtProductDataTable();
                }
                return _Product;
            }
        }

        private dsMarineDeliveryApp.dtVesselDataTable _Vessel = null;
        public dsMarineDeliveryApp.dtVesselDataTable Vessel
        {
            get
            {
                if (_Vessel == null)
                {
                    _Vessel = new dsMarineDeliveryApp.dtVesselDataTable();
                }
                return _Vessel;
            }
        }

        private dsMarineDeliveryApp.dtCarrierDataTable _Carrier = null;
        public dsMarineDeliveryApp.dtCarrierDataTable Carrier
        {
            get
            {
                if (_Carrier == null)
                {
                    _Carrier = new dsMarineDeliveryApp.dtCarrierDataTable();
                }
                return _Carrier;
            }
        }

        private dsMarineDeliveryApp.dtDriverDataTable _Driver = null;
        public dsMarineDeliveryApp.dtDriverDataTable Driver
        {
            get
            {
                if (_Driver == null)
                {
                    _Driver = new dsMarineDeliveryApp.dtDriverDataTable();
                }
                return _Driver;
            }
        }

        private dsMarineDeliveryApp.dtVehicleDataTable _Vehicle = null;
        public dsMarineDeliveryApp.dtVehicleDataTable Vehicle
        {
            get
            {
                if (_Vehicle == null)
                {
                    _Vehicle = new dsMarineDeliveryApp.dtVehicleDataTable();
                }
                return _Vehicle;
            }
        }

        private dsMarineDeliveryApp.dtVehicleCompartmentDataTable _VehicleCompartment = null;
        public dsMarineDeliveryApp.dtVehicleCompartmentDataTable VehicleCompartment
        {
            get
            {
                if (_VehicleCompartment == null)
                {
                    _VehicleCompartment = new dsMarineDeliveryApp.dtVehicleCompartmentDataTable();
                }
                return _VehicleCompartment;
            }
        }

        private dsMarineDeliveryApp.dtTankChartDataTable _TankChart = null;
        public dsMarineDeliveryApp.dtTankChartDataTable TankChart
        {
            get
            {
                if (_TankChart == null)
                {
                    _TankChart = new dsMarineDeliveryApp.dtTankChartDataTable();
                }
                return _TankChart;
            }
        }

        private dsMarineDeliveryApp.dtVehicleSubCompartmentDataTable _VehicleSubCompartment = null;
        public dsMarineDeliveryApp.dtVehicleSubCompartmentDataTable VehicleSubCompartment
        {
            get
            {
                if (_VehicleSubCompartment == null)
                {
                    _VehicleSubCompartment = new dsMarineDeliveryApp.dtVehicleSubCompartmentDataTable();
                }
                return _VehicleSubCompartment;
            }
        }

        private dsMarineDeliveryApp.dtMarineLocTypeDataTable _MarineLocType = null;
        public dsMarineDeliveryApp.dtMarineLocTypeDataTable MarineLocType
        {
            get
            {
                if (_MarineLocType == null)
                {
                    _MarineLocType = new dsMarineDeliveryApp.dtMarineLocTypeDataTable();
                }
                return _MarineLocType;
            }
        }

        private dsMarineDeliveryApp.dtMarineRegionDataTable _MarineRegion = null;
        public dsMarineDeliveryApp.dtMarineRegionDataTable MarineRegion
        {
            get
            {
                if (_MarineRegion == null)
                {
                    _MarineRegion = new dsMarineDeliveryApp.dtMarineRegionDataTable();
                }
                return _MarineRegion;
            }
        }

        private dsMarineDeliveryApp.dtInSiteTankVolumeDataTable _InSiteTankVolume = null;
        public dsMarineDeliveryApp.dtInSiteTankVolumeDataTable InSiteTankVolume
        {
            get
            {
                if (_InSiteTankVolume == null)
                {
                    _InSiteTankVolume = new dsMarineDeliveryApp.dtInSiteTankVolumeDataTable();
                }
                return _InSiteTankVolume;
            }
        }

    }
}
