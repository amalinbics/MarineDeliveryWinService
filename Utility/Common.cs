using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility
{
    public class Common
    {
        public enum CommandType
        {
            Query,
            StroeProcedure
        }

        public enum ConnectionType
        {
            Ascend,
            MarineDelivery
        }

        public enum UpdateType
        {
            Cloud,
            Client
        }

        public enum MethodType
        {
            Delivery,
            Shipment
        }

        public enum ResultStatus
        {
            StatusNew,
            Reason

        }

        public enum Company
        {
            Company_Id,
            Company_Name,
            Federal_Id_No,
            Fiscal_Year_End,
            Date_Created,
            Date_Last_Modified,
            Last_Maintained_By,
            ClientID,
            Email,
            TimeZoneID,
            EnableMarineOperations,
            DdBrokerNo,
            FormattedAddress,
            FormattedLineAddress,
            FormattedMailAddress,
            FormattedMailLineAddress
        }

        public enum LoginUser
        {
            ClientID,
            UserID,
            Password,
            FirstName,
            MiddleName,
            LastName,
            Active,
            Email,
            AltEMail

        }

        public enum InSite
        {
            SiteID,
            Code,
            LongDescr,
            FormattedAddress,
            FormattedLineAddress,
            CompanyID,
            ClientID,
            LastModifiedDtTm,
            EnableElectronicDOI,
            EnableMarineDelivery,
            InSiteType,
            SiteType
        }

        public enum TankType
        {
            TankTypeID,
            Code,
            Descr,
            TankCapacity,
            UsableTankCapacity,
            ClientID
        }

        public enum InSiteTank
        {
            INSiteTankID,
            Code,
            Description,
            INSiteID,
            CompanyID,
            TankCapacity,
            TankChartID,
            TankTypeID,
            DefaultDelQty,
            MaxFill,
            SafetyLevel,
            MinOrderQty,
            PumpLevel,
            WaterAlarm,
            TankClass,
            AboveGround,
            PressureSensor,
            Manifold,
            ManifoldTankID,
            IsPrimary,
            TankReadingBasis,
            ClientID,
            Active,
            EnableSubCompartment
        }

        public enum InSiteTankProduct
        {
            INSiteTankID,
            ProdContID,
            EffectiveDate,
            ProductGroupID,
            ClientID,
        }

        public enum InSiteTankSubCompartment
        {
            SubCompartmentID,
            INSiteTankID,
            ReadingSide,
            TankChartID,
            ClientID,
            CompartmentCode,
        }

        public enum InSiteBillingItem
        {
            SiteID,
            BillingItemID,
            Active,
            BillingItemGLCodeID,
            ProdTermsGroupID,
            ClientID
        }

        public enum ProdCont
        {
            ProdContID,
            ProdID,
            ContID,
            Explanation,
            HzrdMaterialID,
            MaterialSafetyDataID,
            DefActiveToSell,
            DefActiveToPurch,
            DefCostMethod,
            DefCountUOMID,
            DefCountFrequencyID,
            DefMaxOnhand,
            DefMinOnhand,
            DefOnHandUOMID,
            DefConversionUOMID,
            DefConversionFactor,
            DefReportNegative,
            DefReportCommitted,
            DefGLCodeID,
            ProdFrtGroupID,
            ProdTaxGroupID,
            GLMacroSub,
            CompanyID,
            ProdTypeID,
            ActiveForPO,
            PurchGroupID,
            TargetDaysOnHandQty,
            ClientID,
            LastModifiedDtTm,
            LastModifiedUser,
            Weight,
            DefBlendRecipeID,
            CostingStyle,
            OrderQtyCalcMethod,
            Sync_MarineApp,
            ActiveMarneDelvApp

        }

        public enum InSiteProdCont
        {
            SiteID,
            ProdContID,
            ActiveToSell,
            ActiveToPurch,
            ActiveDt,
            MaxOnhand,
            MinOnhand,
            OnHand,
            OnHandUOMID,
            ConversionUOMID,
            ConversionFactor,
            StandardCost,
            WAC,
            InTransit,
            ClientID,
            lastmodifieddttm
        }

        public enum Substitutes
        {
            ProdContID,
            SubProdContID,
            ClientID,
        }

        public enum InSiteTankProductAPI
        {
            ProductAPIID,
            InSiteTankID,
            ProdContID,
            API_Rating,
            Notes,
            EffDtTm,
            CreatedDtTm,
            CreatedByUser,
            ClientID
        }

        public enum UOM
        {
            UOMID,
            Code,
            LongDescr,
            Base,
            Volume,
            ConversionFactor,
            ConversionUOMID,
            BaseUOMFactor,
            BaseUOMID,
            ClientID,
            LastModifiedDtTm,
            UOMType,
            IsPackaged
        }

        public enum UOMType
        {
            Type,
            Descr,
            ClientID
        }

        public enum Product
        {
            ClientID,
            MasterProdID,
            ProdID,
            CompanyID,
            MasterProdType,
            ParentID,
            Code,
            Descr,
            SellByUOMID,
            DefOnHandUOMID,
            DefCountUOMID,
            DefCountFrequencyID,
            DefConversionUOMID,
            DefConversionFactor,
            HzrdMaterialID,
            Explanation,
            Sync_MarineApp,
            BIUOMID,
            BIEnableTankReadings,
            SpecificGravity
        }

        public enum Vessel
        {
            ShipToVesselID,
            VesselCode,
            VesselDescr,
            VesselTypeID,
            OwnershipStdAcctID,
            GrossTonnage,
            ActualCapacity,
            UOMID,
            CompanyID,
            ClientID,
            IMONo,
            Instruction,

        }
        public enum Carrier
        {
            CarrierID,
            VendorID,
            Code,
            Descr,
            CompanyID,
            ClientID
        }

        public enum Driver
        {
            DriverID,
            FirstName,
            MiddleName,
            LastName,
            Email,
            AltEmail,
            DriverNo,
            EmployeeNo,
            DriverType,
            UserID,
            Password,
            ClientID,
            LastModifiedDtTm,
            OriginateCompanyID
        }

        public enum Vehicle
        {
            VehicleID,
            Code,
            Descr,
            CarrierID,
            VehicleType,
            CompanyID,
            ClientID,
            EnableSubCompartment,
            LastModifiedDtTm,
            EnforceShipmentMarineApp
        }

        public enum VehicleCompartment
        {
            CompartmentID,
            VehicleID,
            Code,
            Capacity,
            Load_Rate,
            Unload_Rate,
            ClientID,
            TankChartID
        }

        public enum TankChart
        {
            TankChartID,
            Code,
            Descr,
            LMeasure,
            VMeasure,
            Denominator,
            Active,
            VolumeUOM,
            LinearUOM,
            LastModifiedDtTm,
            ClientID
        }

        public enum VehicleSubCompartment
        {
            SubCompartmentID,
            CompartmentID,
            ReadingSide,
            TankChartID,
            ClientID
        }
        public enum MarineLocType
        {
            LocTypeID, 
            LocType, 
            Descr, 
            ClientID
        }

        public enum MarineRegion
        {
            MarineRegionID, 
            Code, 
            Descr, 
            ClientID  
        }

       

        public enum Status
        {
            success,
        }

        public enum Paramenter
        {
            JsonValue
        }

    }
}
