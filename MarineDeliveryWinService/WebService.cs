using DataAccess;
using MarineDeliveryWinService.Entity;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Web.Script.Serialization;
using Utility;
using Microsoft.WindowsAzure.Storage;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage.Blob; // Namespace for Blob storage types


namespace MarineDeliveryWinService
{
    /// <summary>
    /// WebServices class
    /// </summary>
    public class WebService
    {
        /// <summary>
        /// CallWebService
        /// Function to Call Web Service
        /// </summary>
        public static void CallWebService()
        {
            try
            {
                //try
                //{
                //    //UpdateOrdersToCloud();
                //    //UpdateOrders();
                //    //UpdateShipments();
                //    UpdateDeliveryDetails();
                //    //UpdateOrdersToCloud();
                //    //UpdateINSiteTankProductAPI();
                //    //UpdateInSiteTankSubCompartments();
                //    //UpdateDOI();
                //    //UpdateProducts();
                //    //UpdateSubProdCont();
                //    //UpdateMarineLoc();                   
                //}
                //catch (Exception ex)
                //{
                //    Logging.WriteToFileException(ex.Message);
                //}
                //return;

                if (ConfigurationManager.AppSettings["MasterTableUpdate"].ToString() == "Y")
                {

                    try
                    {
                        UpdateCompany();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdateLoginUser();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdateINSite();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdateTankType();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdateINSiteTank();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdateINSiteTankProducts();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdateInSiteTankSubCompartments();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdateINSiteBillingItem();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }

                    try
                    {
                        UpdateProdCont();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }

                    try
                    {
                        // UpdateINSiteProdCont();
                        UpdateINSiteProdContNew();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }

                    try
                    {
                        UpdateSubProdCont();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }

                    try
                    {
                        UpdateINSiteTankProductAPI();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }

                    try
                    {
                        UpdateUOM();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdateUOMType();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdateProducts();
                        UpdateSalesContractSalesAlias();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdateVessel();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdateAdHocVessel();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdateCarrier();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdateDrivers();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdateVehicles();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdateVehicleCompartments();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdateTankChartNew();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }

                    try
                    {
                        UpdateVehicleSubCompartments();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdateMarineLocType();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdateMarineRegion();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdateMarineLoc();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdateMarineAppSalesPLUButtons();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdateARShipTo();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdatePerson();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdatePersonPhone();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }

                    try
                    {
                        // UpdateTankChartDetail();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        //UpdateTankChartKeel();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        //  UpdateTankChartTrim();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                    try
                    {
                        UpdateINSiteTankVolume();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }

                    try
                    {
                        UpdateSyncDeletedTrx();
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteToFileException(ex.Message);
                    }
                }

                try
                {
                    UpdateOrders();
                }
                catch (Exception ex)
                {
                    Logging.WriteToFileException(ex.Message);
                }

                try
                {
                    UpdateOrdersToCloud();
                }
                catch (Exception ex)
                {
                    Logging.WriteToFileException(ex.Message);
                }

                try
                {

                    UpdateOrderNotes();
                    DeleteOrderAttachment();
                    UpdateOrderNoteAttachment();
                }
                catch (Exception ex)
                {
                    Logging.WriteToFileException(ex.Message);
                }

                try
                {
                    UpdateOrderNotesToClient();
                }
                catch (Exception ex)
                {
                    Logging.WriteToFileException(ex.Message);
                }

                try
                {
                    UpdateShipments();
                }
                catch (Exception ex)
                {
                    Logging.WriteToFileException(ex.Message);
                }
                try
                {
                    UpdateOrderStatus('T');
                }
                catch (Exception ex)
                {
                    Logging.WriteToFileException(ex.Message);
                }
                try
                {
                    UpdateDeliveryDetails();
                }
                catch (Exception ex)
                {
                    Logging.WriteToFileException(ex.Message);
                }
                try
                {
                    UpdateMeterTicket();
                }
                catch (Exception ex)
                {
                    Logging.WriteToFileException(ex.Message);
                }
                try
                {
                    UpdateDOI();
                }
                catch (Exception ex)
                {
                    Logging.WriteToFileException(ex.Message);
                }
                try
                {
                    UpdateDeliveryTicket();
                }
                catch (Exception ex)
                {
                    Logging.WriteToFileException(ex.Message);
                }
                try
                {
                    UpdateAttachment();
                }
                catch (Exception ex)
                {
                    Logging.WriteToFileException(ex.Message);
                }
                try
                {
                    UpdateDocMessage();
                }
                catch (Exception ex)
                {
                    Logging.WriteToFileException(ex.Message);
                }
                try
                {
                    UpdateDocLogo();
                }
                catch (Exception ex)
                {
                    Logging.WriteToFileException(ex.Message);
                }



            }
            catch (Exception ex)
            {
                Logging.WriteToFileException(ex.Message);
            }
        }

        /// <summary>
        /// UpdateCompany
        /// Function to update Company
        /// </summary>
        public static void UpdateCompany()
        {
            try
            {
                //Logging.WriteLog("UpdateOrders...", EventLogEntryType.Error);
                string GetCompany = new WebClient().DownloadString(ServiceURL.GetCompanyURL);
                //JArray results = JArray.Parse(json);
                List<Company> lstCompany = JsonConvert.DeserializeObject<List<Company>>(GetCompany);
                Logging.WriteLog("Function Called UpdateCompany - Count " + lstCompany.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstCompany.Count > 0)
                {
                    CompanyJSONParam JsonParamValue = new CompanyJSONParam();
                    CompanyDetails Company = new CompanyDetails();
                    for (var i = 0; i < lstCompany.Count; i++)
                    {
                        Company Comp = new Company();
                        Comp.Company_ID = lstCompany[i].Company_ID;
                        Comp.Company_Name = lstCompany[i].Company_Name.EncodeString();
                        Comp.Federal_Id_No = lstCompany[i].Federal_Id_No;
                        Comp.Fiscal_Year_End = lstCompany[i].Fiscal_Year_End;
                        Comp.Last_Maintained_By = lstCompany[i].Last_Maintained_By;
                        Comp.ClientID = lstCompany[i].ClientID;
                        Comp.Email = lstCompany[i].Email;
                        Comp.TimeZoneID = lstCompany[i].TimeZoneID == null ? 0 : lstCompany[i].TimeZoneID;
                        Comp.DdBrokerNo = lstCompany[i].DdBrokerNo == null ? 0 : lstCompany[i].DdBrokerNo;
                        Comp.EnableMarineOperations = lstCompany[i].EnableMarineOperations;
                        Comp.FormattedAddress = lstCompany[i].FormattedAddress.EncodeString();
                        Comp.FormattedLineAddress = lstCompany[i].FormattedLineAddress.EncodeString();
                        Comp.FormattedMailAddress = lstCompany[i].FormattedMailAddress.EncodeString();
                        Comp.FormattedMailLineAddress = lstCompany[i].FormattedMailLineAddress.EncodeString();
                        Comp.Date_Created = lstCompany[i].Date_Created;
                        Comp.Date_Last_Modified = lstCompany[i].Date_Last_Modified;
                        Comp.Central_Phone_Number = lstCompany[i].Central_Phone_Number;
                        Company.CompanyList.Add(Comp);
                    }
                    JsonParamValue.Companies = Company;
                    var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    ParamList paramList = new ParamList();

                    parameter paramVal = new parameter();
                    paramVal.name = "JsonValue";
                    //   paramVal.param_type = "IN";
                    paramVal.value = jsonperVal.ToString().Replace("\\\\", "");

                    paramList.Params.Add(paramVal);

                    var jsonVal = jsonSerialiser.Serialize(paramList);

                    jsonVal = jsonVal.Replace("Params", "params");

                    //string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";                     

                    string url = ServiceURL.UpdateCompanyURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateCompany - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        /// <summary>
        /// UpdateINSite
        /// Function to update INSite
        /// </summary>
        public static void UpdateINSite()
        {
            try
            {
                string GetINSite = new WebClient().DownloadString(ServiceURL.GetINSiteURL);
                //JArray results = JArray.Parse(json);
                List<INSite> lstINSite = JsonConvert.DeserializeObject<List<INSite>>(GetINSite);
                Logging.WriteLog("Function Called UpdateINSite - Count " + lstINSite.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstINSite.Count > 0)
                {
                    INSiteJSONParam JsonParamValue = new INSiteJSONParam();
                    INSites INSite = new INSites();
                    for (var i = 0; i < lstINSite.Count; i++)
                    {
                        INSite INS = new INSite();
                        INS.SiteID = lstINSite[i].SiteID;
                        INS.Code = lstINSite[i].Code.EncodeString();
                        INS.LongDescr = lstINSite[i].LongDescr.EncodeString();
                        INS.FormattedAddress = lstINSite[i].FormattedAddress.EncodeString();
                        INS.FormattedLineAddress = lstINSite[i].FormattedLineAddress.EncodeString();
                        INS.CompanyID = lstINSite[i].CompanyID;
                        INS.ClientID = lstINSite[i].ClientID;
                        INS.LastModifiedDtTm = lstINSite[i].LastModifiedDtTm;
                        INS.EnableElectronicDOI = lstINSite[i].EnableElectronicDOI;
                        INS.EnableMarineDelivery = lstINSite[i].EnableMarineDelivery;
                        INS.InSiteType = lstINSite[i].InSiteType;
                        INS.SiteType = lstINSite[i].SiteType;
                        INS.Inactive = lstINSite[i].Inactive == 'Y' ? 'Y' : 'N';

                        INSite.INSiteList.Add(INS);
                    }
                    JsonParamValue.INSites = INSite;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });


                    ParamList paramList = new ParamList();

                    parameter paramVal = new parameter();
                    paramVal.name = "JsonValue";
                    // paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");

                    paramList.Params.Add(paramVal);


                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");

                    //   string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateINSiteURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {

                                    //for (var i = 0; i < lstINSite.Count; i++)
                                    //{
                                    //    string InSiteUpdateMarineURL = ServiceURL.UpdateSyncFlagInSite + "(" + lstINSite[i].SiteID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                    //    string InSiteSyncUpdateResult = new WebClient().DownloadString(InSiteUpdateMarineURL);
                                    //}

                                    MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                    JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                    marineSyncFlagUpdate.marineSyncFlagUpdate = (from i in lstINSite
                                                                                 select new MarineSyncFlag { ID = i.SiteID }).ToList<MarineSyncFlag>();

                                    jsonMarineSyncFlagUpdate.marineSyncFlag = marineSyncFlagUpdate;
                                    Results results = UpdateSyncFlag(jsonMarineSyncFlagUpdate, string.Format("{0}?{1}&", ServiceURL.UpdateSyncFlagInSite, ConfigurationManager.AppSettings["ClientAPIKEY"].ToString()));

                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateSyncFlagInSite - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }

                                }
                                else
                                {
                                    Logging.WriteLog("Error in UpdateSyncFlagInSite - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateINSite - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        /// <summary>
        /// UpdateINSiteTank
        /// Function to update INSiteTank
        /// </summary>
        public static void UpdateINSiteTank()
        {
            try
            {
                string GetINSiteTank = new WebClient().DownloadString(ServiceURL.GetINSiteTankURL);
                //JArray results = JArray.Parse(json);
                List<INSiteTank> lstINSiteTank = JsonConvert.DeserializeObject<List<INSiteTank>>(GetINSiteTank);
                Logging.WriteLog("Function Called UpdateINSiteTank - Count " + lstINSiteTank.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstINSiteTank.Count > 0)
                {
                    INSiteTankJSONParam JsonParamValue = new INSiteTankJSONParam();
                    INSiteTankDetails INSiteTank = new INSiteTankDetails();
                    for (var i = 0; i < lstINSiteTank.Count; i++)
                    {
                        INSiteTank INST = new INSiteTank();
                        INST.INSiteTankID = lstINSiteTank[i].INSiteTankID;
                        INST.Code = lstINSiteTank[i].Code.EncodeString();
                        INST.Description = lstINSiteTank[i].Description.EncodeString();
                        INST.INSiteID = lstINSiteTank[i].INSiteID;
                        INST.CompanyID = lstINSiteTank[i].CompanyID;
                        INST.TankCapacity = lstINSiteTank[i].TankCapacity == null ? 0 : lstINSiteTank[i].TankCapacity;
                        INST.TankChartID = lstINSiteTank[i].TankChartID;
                        INST.TankTypeID = lstINSiteTank[i].TankTypeID;
                        INST.DefaultDelQty = lstINSiteTank[i].DefaultDelQty;
                        INST.MaxFill = lstINSiteTank[i].MaxFill;
                        INST.SafetyLevel = lstINSiteTank[i].SafetyLevel;
                        INST.MinOrderQty = lstINSiteTank[i].MinOrderQty;
                        INST.PumpLevel = lstINSiteTank[i].PumpLevel;
                        INST.WaterAlarm = lstINSiteTank[i].WaterAlarm;
                        INST.TankClass = lstINSiteTank[i].TankClass;
                        INST.AboveGround = lstINSiteTank[i].AboveGround;
                        INST.PressureSensor = lstINSiteTank[i].PressureSensor;
                        INST.Manifold = lstINSiteTank[i].Manifold;
                        INST.ManifoldTankID = lstINSiteTank[i].ManifoldTankID;
                        INST.IsPrimary = lstINSiteTank[i].IsPrimary;
                        INST.TankReadingBasis = lstINSiteTank[i].TankReadingBasis;
                        INST.ClientID = lstINSiteTank[i].ClientID;
                        INST.Active = lstINSiteTank[i].Active;
                        INST.EnableSubCompartment = lstINSiteTank[i].EnableSubCompartment;
                        INST.Insulated = lstINSiteTank[i].Insulated;
                        INST.LinearExpansionCoeff = lstINSiteTank[i].LinearExpansionCoeff;
                        INST.TankOperatingTemp = lstINSiteTank[i].TankOperatingTemp;

                        INSiteTank.INSiteTankList.Add(INST);
                    }

                    JsonParamValue.INSiteTank = INSiteTank;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                    ParamList paramList = new ParamList();

                    parameter paramVal = new parameter();
                    paramVal.name = "JsonValue";
                    // paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");

                    paramList.Params.Add(paramVal);

                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");

                    //  string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateINSiteTankURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {

                                    //for (var j = 0; j < lstINSiteTank.Count; j++)
                                    //{
                                    //    string INSiteTankUpdateMarineURL = ServiceURL.UpdateSyncFlagINSiteTank + "(" + lstINSiteTank[j].INSiteTankID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                    //    string INSiteTankSyncUpdateResult = new WebClient().DownloadString(INSiteTankUpdateMarineURL);
                                    //}

                                    MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                    JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                    marineSyncFlagUpdate.marineSyncFlagUpdate = (from i in lstINSiteTank
                                                                                 select new MarineSyncFlag { ID = i.INSiteTankID }).ToList<MarineSyncFlag>();

                                    jsonMarineSyncFlagUpdate.marineSyncFlag = marineSyncFlagUpdate;
                                    Results results = UpdateSyncFlag(jsonMarineSyncFlagUpdate, string.Format("{0}?{1}&", ServiceURL.UpdateSyncFlagINSiteTank, ConfigurationManager.AppSettings["ClientAPIKEY"].ToString()));

                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateSyncFlagINSiteTank - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }

                                }
                                else
                                {
                                    Logging.WriteLog("Error in UpdateSyncFlagINSiteTank - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateINSiteTank - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        public static void UpdateTankType()
        {
            try
            {
                string GetTankType = new WebClient().DownloadString(ServiceURL.GetTankType);
                List<TankType> lstTankType = JsonConvert.DeserializeObject<List<TankType>>(GetTankType);
                Logging.WriteLog("Function Called UpdateTankType - Count " + lstTankType.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };

                if (lstTankType.Count > 0)
                {
                    for (int i = 0; i < lstTankType.Count; i++)
                    {
                        TankTypeJSONParam JsonParamValue = new TankTypeJSONParam();
                        TankTypeUpdate TankType_Update = new TankTypeUpdate();
                        TankType TankTypeGet = new TankType();

                        TankTypeGet.TankTypeID = lstTankType[i].TankTypeID;
                        TankTypeGet.Code = lstTankType[i].Code.EncodeString();
                        TankTypeGet.Descr = lstTankType[i].Descr.EncodeString();
                        TankTypeGet.TankCapacity = lstTankType[i].TankCapacity;
                        TankTypeGet.UsableTankCapacity = lstTankType[i].UsableTankCapacity;
                        TankTypeGet.ClientID = lstTankType[i].ClientID;

                        TankType_Update.TankTypeUpdateList.Add(TankTypeGet);
                        JsonParamValue.TankTypeGetToUpdate = TankType_Update;


                        string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                        });


                        ParamList paramList = new ParamList();

                        parameter paramVal = new parameter();
                        paramVal.name = "JsonValue";
                        //   paramVal.param_type = "IN";
                        paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");

                        paramList.Params.Add(paramVal);

                        var jsonVal = jsonSerialiser.Serialize(paramList);

                        jsonVal = jsonVal.Replace("Params", "params");

                        //string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                        string url = ServiceURL.UpdateTankType + "&";
                        var request = (HttpWebRequest)HttpWebRequest.Create(url);
                        request.ContentType = "application/json; charset=utf-8";
                        request.Method = "POST";
                        request.Accept = "application/json; charset=utf-8";


                        using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                        {
                            streamWriter.Write(jsonVal);
                        }
                        var httpResponse = (HttpWebResponse)request.GetResponse();

                        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                        {
                            var result = streamReader.ReadToEnd();
                            List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                            if (lsResult != null)
                            {
                                if (lsResult.Count > 0)
                                {
                                    if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                    {

                                    }
                                    else
                                    {
                                        Logging.WriteLog("Error in UpdateTankType - ID - " + lstTankType[i].TankTypeID + ", Reason - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                    }
                                }
                            }
                        }
                    }

                }
            }
            catch (WebException e)
            {
                string pageContent = new StreamReader(e.Response.GetResponseStream()).ReadToEnd().ToString();

            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateTankType - " + ex.Message.ToString(), EventLogEntryType.Error);

            }

        }


        /// <summary>
        /// UpdateINSiteTankProducts
        /// Function to update INSiteTankProducts
        /// </summary>
        public static void UpdateINSiteTankProducts()
        {
            try
            {
                string GetINSiteTankProducts = new WebClient().DownloadString(ServiceURL.GetINSiteTankProductURL);
                //JArray results = JArray.Parse(json);
                List<INSiteTankProducts> lstINSiteTankProducts = JsonConvert.DeserializeObject<List<INSiteTankProducts>>(GetINSiteTankProducts);
                Logging.WriteLog("Function Called UpdateINSiteTankProducts - Count " + lstINSiteTankProducts.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstINSiteTankProducts.Count > 0)
                {
                    INSiteTankProductJSONParam JsonParamValue = new INSiteTankProductJSONParam();
                    INSiteTankProductDetails INSiteTankProducts = new INSiteTankProductDetails();
                    for (var i = 0; i < lstINSiteTankProducts.Count; i++)
                    {
                        INSiteTankProducts INSTProd = new INSiteTankProducts();
                        INSTProd.INSiteTankID = lstINSiteTankProducts[i].INSiteTankID;
                        INSTProd.ProdContID = lstINSiteTankProducts[i].ProdContID;
                        INSTProd.EffectiveDate = lstINSiteTankProducts[i].EffectiveDate;
                        INSTProd.ProductGroupID = lstINSiteTankProducts[i].ProductGroupID;
                        INSTProd.ClientID = lstINSiteTankProducts[i].ClientID;

                        INSiteTankProducts.INSiteTankProductsList.Add(INSTProd);
                    }

                    JsonParamValue.INSiteTankProducts = INSiteTankProducts;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                    ParamList paramList = new ParamList();

                    parameter paramVal = new parameter();
                    paramVal.name = "JsonValue";
                    //  paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");

                    paramList.Params.Add(paramVal);

                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");

                    // string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateINSiteTankProductsURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateINSiteTankProducts - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        /// <summary>
        /// UpdateInSiteTankSubCompartments
        /// Function to Update InSiteTankSubCompartments
        /// </summary>
        public static void UpdateInSiteTankSubCompartments()
        {
            try
            {
                string GetInSiteTankSubCompartments = new WebClient().DownloadString(ServiceURL.GetInSiteTankSubCompartments);
                //JArray results = JArray.Parse(json);
                List<InSiteTankSubCompartments> lstInSiteTankSubCompartments = JsonConvert.DeserializeObject<List<InSiteTankSubCompartments>>(GetInSiteTankSubCompartments);
                Logging.WriteLog("Function Called UpdateInSiteTankSubCompartments - Count " + lstInSiteTankSubCompartments.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstInSiteTankSubCompartments.Count > 0)
                {
                    InSiteTankSubCompartmentsJSONParam JsonParamValue = new InSiteTankSubCompartmentsJSONParam();
                    InSiteTankSubCompartmentsDetails InSiteTankSubCompartments = new InSiteTankSubCompartmentsDetails();
                    for (var i = 0; i < lstInSiteTankSubCompartments.Count; i++)
                    {
                        InSiteTankSubCompartments INSTProd = new InSiteTankSubCompartments();
                        INSTProd.SubCompartmentID = lstInSiteTankSubCompartments[i].SubCompartmentID;
                        INSTProd.INSiteTankID = lstInSiteTankSubCompartments[i].INSiteTankID;
                        INSTProd.ReadingSide = lstInSiteTankSubCompartments[i].ReadingSide;
                        INSTProd.TankChartID = lstInSiteTankSubCompartments[i].TankChartID;
                        INSTProd.CompartmentCode = lstInSiteTankSubCompartments[i].CompartmentCode.EncodeString();
                        INSTProd.ClientID = lstInSiteTankSubCompartments[i].ClientID;

                        InSiteTankSubCompartments.InSiteTankSubCompartmentsList.Add(INSTProd);
                    }

                    JsonParamValue.InSiteTankSubCompartments = InSiteTankSubCompartments;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                    ParamList paramList = new ParamList();

                    parameter paramVal = new parameter();
                    paramVal.name = "JsonValue";
                    //   paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");

                    paramList.Params.Add(paramVal);


                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");

                    //  string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateInSiteTankSubCompartmentsURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                            {

                                //for (var j = 0; j < lstInSiteTankSubCompartments.Count; j++)
                                //{
                                //    string InSiteTankSubCompartmentsURL = ServiceURL.UpdateSyncFlagInSiteTankSubCompartments + "(" + lstInSiteTankSubCompartments[j].SubCompartmentID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                //    string InSiteTankSubCompartmentsResult = new WebClient().DownloadString(InSiteTankSubCompartmentsURL);
                                //}

                                MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                marineSyncFlagUpdate.marineSyncFlagUpdate = (from i in lstInSiteTankSubCompartments
                                                                             select new MarineSyncFlag { ID = i.SubCompartmentID }).ToList<MarineSyncFlag>();

                                jsonMarineSyncFlagUpdate.marineSyncFlag = marineSyncFlagUpdate;
                                Results results = UpdateSyncFlag(jsonMarineSyncFlagUpdate, string.Format("{0}?{1}&", ServiceURL.UpdateSyncFlagInSiteTankSubCompartments, ConfigurationManager.AppSettings["ClientAPIKEY"].ToString()));

                                if (results.StatusNew.ToString().ToLower() != "success")
                                {
                                    Logging.WriteLog("Error in UpdateSyncFlagInSiteTankSubCompartments - " + results.Reason.ToString(), EventLogEntryType.Error);
                                }

                            }
                            else
                            {
                                Logging.WriteLog("Error in UpdateSyncFlagInSiteTankSubCompartments - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateInSiteTankSubCompartments - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        /// <summary>
        /// UpdateINSiteProdCont
        /// Function to update INSiteProdCont
        /// </summary>
        public static void UpdateINSiteProdCont()
        {
            try
            {
                string GetINSiteProdCont = new WebClient().DownloadString(ServiceURL.GetINSiteProdContURL);
                //JArray results = JArray.Parse(json);
                List<INSiteProdCont> lstINSiteProdCont = JsonConvert.DeserializeObject<List<INSiteProdCont>>(GetINSiteProdCont);
                Logging.WriteLog("Function Called UpdateINSiteProdCont - Count " + lstINSiteProdCont.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstINSiteProdCont.Count > 0)
                {


                    for (var i = 0; i < lstINSiteProdCont.Count; i++)
                    {
                        INSiteProdContJSONParam JsonParamValue = new INSiteProdContJSONParam();
                        INSiteProdContDetails INSiteProdContT = new INSiteProdContDetails();
                        INSiteProdCont INSTPC = new INSiteProdCont();
                        INSTPC.SiteID = lstINSiteProdCont[i].SiteID;
                        INSTPC.ProdContID = lstINSiteProdCont[i].ProdContID;
                        INSTPC.ActiveToSell = lstINSiteProdCont[i].ActiveToSell;
                        INSTPC.ActiveToPurch = lstINSiteProdCont[i].ActiveToPurch;
                        INSTPC.ActiveDt = lstINSiteProdCont[i].ActiveDt;
                        INSTPC.MaxOnhand = lstINSiteProdCont[i].MaxOnhand;
                        INSTPC.MinOnhand = lstINSiteProdCont[i].MinOnhand;
                        INSTPC.OnHand = lstINSiteProdCont[i].OnHand;
                        INSTPC.OnHandUOMID = lstINSiteProdCont[i].OnHandUOMID;
                        INSTPC.ConversionUOMID = lstINSiteProdCont[i].ConversionUOMID;
                        INSTPC.ConversionFactor = lstINSiteProdCont[i].ConversionFactor;
                        INSTPC.StandardCost = lstINSiteProdCont[i].StandardCost;
                        INSTPC.WAC = lstINSiteProdCont[i].WAC;
                        INSTPC.InTransit = lstINSiteProdCont[i].InTransit;
                        INSTPC.ClientID = lstINSiteProdCont[i].ClientID;
                        INSTPC.lastmodifieddttm = lstINSiteProdCont[i].lastmodifieddttm;
                        INSTPC.CountUOMID = lstINSiteProdCont[i].CountUOMID;
                        INSTPC.ActiveMarneDelvApp = lstINSiteProdCont[i].ActiveMarneDelvApp == 'Y' ? 'Y' : 'N';
                        INSiteProdContT.INSiteProdContList.Add(INSTPC);

                        JsonParamValue.INSiteProdCont = INSiteProdContT;
                        //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                        string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                        });

                        ParamList paramList = new ParamList();

                        parameter paramVal = new parameter();
                        paramVal.name = "JsonValue";
                        //  paramVal.param_type = "IN";
                        paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");

                        paramList.Params.Add(paramVal);

                        var jsonVal = jsonSerialiser.Serialize(paramList);
                        jsonVal = jsonVal.Replace("Params", "params");
                        //string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                        string url = ServiceURL.UpdateINSiteProdContURL + "&";
                        var request = (HttpWebRequest)HttpWebRequest.Create(url);
                        request.ContentType = "application/json; charset=utf-8";
                        request.Method = "POST";
                        request.Accept = "application/json; charset=utf-8";

                        using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                        {
                            streamWriter.Write(jsonVal);
                            //streamWriter.Close();
                        }

                        var httpResponse = (HttpWebResponse)request.GetResponse();
                        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                        {
                            var result = streamReader.ReadToEnd();
                            List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                            if (lsResult != null)
                            {
                                if (lsResult.Count > 0)
                                {
                                    if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                    {

                                        string INSiteProdContUpdateMarineURL = ServiceURL.UpdateSyncFlagINSiteProdCont + "(" + lstINSiteProdCont[i].ProdContID + "," + lstINSiteProdCont[i].SiteID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                        string INSiteProdContSyncUpdateResult = new WebClient().DownloadString(INSiteProdContUpdateMarineURL);

                                        MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                        JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                        //INSiteProdContSyncFlagUpdate inSiteProdContSyncFlagUpdate = new INSiteProdContSyncFlagUpdate();
                                        //INSiteProdContSyncFlagUpdateJSONParam json = new INSiteProdContSyncFlagUpdateJSONParam();

                                        //inSiteProdContSyncFlagUpdate.inSiteProdContSyncFlagUpdate = (from i in lstINSiteProdCont
                                        //                                                             select new INSiteProdContSyncFlag { ProdContID = i.ProdContID, SiteID = i.SiteID }).ToList<INSiteProdContSyncFlag>();

                                        //json.inSiteProdContSyncFlag = inSiteProdContSyncFlagUpdate;
                                        //Results results = UpdateSyncFlag(json, string.Format("{0}?{1}&", ServiceURL.UpdateSyncFlagINSiteProdCont, ConfigurationManager.AppSettings["ClientAPIKEY"].ToString()));

                                        //if (results.StatusNew.ToString().ToLower() != "success")
                                        //{
                                        //    Logging.WriteLog("Error in UpdateSyncFlagMarineLoc - " + results.Reason.ToString(), EventLogEntryType.Error);
                                        //}
                                    }
                                    else
                                    {
                                        Logging.WriteLog("Error in UpdateSyncFlagINSiteProdCont - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                    }
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateINSiteProdCont - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        /// <summary>
        /// UpdateSubProdCont
        /// Function to update SubProdCont
        /// </summary>
        public static void UpdateSubProdCont()
        {
            try
            {
                string GetSubProdCont = new WebClient().DownloadString(ServiceURL.GetSubProdContURL);
                //JArray results = JArray.Parse(json);
                List<Substitutes> lstSubProdCont = JsonConvert.DeserializeObject<List<Substitutes>>(GetSubProdCont);
                Logging.WriteLog("Function Called UpdateSubProdCont - Count " + lstSubProdCont.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstSubProdCont.Count > 0)
                {
                    SubProdContJSONParam JsonParamValue = new SubProdContJSONParam();
                    SubProdContDetails SubProdCont = new SubProdContDetails();
                    for (var i = 0; i < lstSubProdCont.Count; i++)
                    {

                        Substitutes Subs = new Substitutes();
                        Subs.ProdContID = lstSubProdCont[i].ProdContID;
                        Subs.SubProdContID = lstSubProdCont[i].SubProdContID;
                        Subs.ClientID = lstSubProdCont[i].ClientID;
                        SubProdCont.SubProdContList.Add(Subs);

                    }

                    JsonParamValue.SubProdConts = SubProdCont;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                    ParamList paramList = new ParamList();

                    parameter paramVal = new parameter();
                    paramVal.name = "JsonValue";
                    //  paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");

                    paramList.Params.Add(paramVal);


                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");

                    //string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateSubProdContURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {

                                    //string SubProdContUpdateMarineURL = ServiceURL.UpdateSyncFlagSubProdCont + "(" + lstSubProdCont[i].ProdContID + "," + lstSubProdCont[i].SubProdContID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                    //string SubProdContSyncUpdateResult = new WebClient().DownloadString(SubProdContUpdateMarineURL);

                                    SubstitutesSyncFlagUpdate substitutesSyncFlagUpdate = new SubstitutesSyncFlagUpdate();
                                    SubstitutesSyncFlagJSONParam json = new SubstitutesSyncFlagJSONParam();

                                    substitutesSyncFlagUpdate.substitutesSyncFlagUpdate = (from i in lstSubProdCont
                                                                                           select new SubstitutesSyncFlag { ProdContID = i.ProdContID, SubProdContID = i.SubProdContID }).ToList<SubstitutesSyncFlag>();

                                    json.substitutesSyncFlag = substitutesSyncFlagUpdate;
                                    Results results = UpdateSyncFlag(json, string.Format("{0}?{1}&", ServiceURL.UpdateSyncFlagSubProdCont, ConfigurationManager.AppSettings["ClientAPIKEY"].ToString()));

                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateSyncFlagMarineLoc - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }


                                }
                                else
                                {
                                    Logging.WriteLog("Error in UpdateSyncFlagSubProdCont - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateSubProdCont - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        public static void UpdateProdCont()
        {
            try
            {
                string GetProdCont = new WebClient().DownloadString(ServiceURL.GetProdCont);
                //JArray results = JArray.Parse(json);
                List<ProdCont> lstProdCont = JsonConvert.DeserializeObject<List<ProdCont>>(GetProdCont);
                Logging.WriteLog("Function Called UpdateProdCont - Count " + lstProdCont.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstProdCont.Count > 0)
                {
                    ProdContJSONParam JsonParamValue = new ProdContJSONParam();
                    ProdContUpdate ProdCont = new ProdContUpdate();
                    for (var i = 0; i < lstProdCont.Count; i++)
                    {
                        ProdCont PDC = new ProdCont();
                        PDC.ProdContID = lstProdCont[i].ProdContID;
                        PDC.ProdID = lstProdCont[i].ProdID;
                        PDC.ContID = lstProdCont[i].ContID;
                        PDC.Explanation = lstProdCont[i].Explanation.EncodeString();
                        PDC.HzrdMaterialID = lstProdCont[i].HzrdMaterialID;
                        PDC.MaterialSafetyDataID = lstProdCont[i].MaterialSafetyDataID;
                        PDC.DefActiveToSell = lstProdCont[i].DefActiveToSell;
                        PDC.DefActiveToPurch = lstProdCont[i].DefActiveToPurch;
                        PDC.DefCostMethod = lstProdCont[i].DefCostMethod;
                        PDC.DefCountUOMID = lstProdCont[i].DefCountUOMID;
                        PDC.DefCountFrequencyID = lstProdCont[i].DefCountFrequencyID;
                        PDC.DefMaxOnhand = lstProdCont[i].DefMaxOnhand;


                        PDC.DefMinOnhand = lstProdCont[i].DefMinOnhand;
                        PDC.DefOnHandUOMID = lstProdCont[i].DefOnHandUOMID;
                        PDC.DefConversionUOMID = lstProdCont[i].DefConversionUOMID;
                        PDC.DefConversionFactor = lstProdCont[i].DefConversionFactor;

                        PDC.DefReportNegative = lstProdCont[i].DefReportNegative;
                        PDC.DefReportCommitted = lstProdCont[i].DefReportCommitted;
                        PDC.DefGLCodeID = lstProdCont[i].DefGLCodeID;
                        PDC.ProdFrtGroupID = lstProdCont[i].ProdFrtGroupID;

                        PDC.ProdTaxGroupID = lstProdCont[i].ProdTaxGroupID;
                        PDC.GLMacroSub = lstProdCont[i].GLMacroSub;
                        PDC.CompanyID = lstProdCont[i].CompanyID;
                        PDC.ProdTypeID = lstProdCont[i].ProdTypeID;

                        PDC.ActiveForPO = lstProdCont[i].ActiveForPO;
                        PDC.PurchGroupID = lstProdCont[i].PurchGroupID;
                        PDC.TargetDaysOnHandQty = lstProdCont[i].TargetDaysOnHandQty;
                        PDC.ClientID = lstProdCont[i].ClientID;

                        PDC.LastModifiedDtTm = lstProdCont[i].LastModifiedDtTm;
                        PDC.LastModifiedUser = lstProdCont[i].LastModifiedUser;
                        PDC.Weight = lstProdCont[i].Weight;
                        PDC.DefBlendRecipeID = lstProdCont[i].DefBlendRecipeID;

                        PDC.CostingStyle = lstProdCont[i].CostingStyle;
                        PDC.OrderQtyCalcMethod = lstProdCont[i].OrderQtyCalcMethod;
                        PDC.ActiveMarneDelvApp = lstProdCont[i].ActiveMarneDelvApp;
                        PDC.EnterAsNegativeOrderedQuantity = lstProdCont[i].EnterAsNegativeOrderedQuantity;

                        ProdCont.ProdContList.Add(PDC);
                    }
                    JsonParamValue.ProdConts = ProdCont;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                    ParamList paramList = new ParamList();

                    parameter paramVal = new parameter();
                    paramVal.name = "JsonValue";
                    //  paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");

                    paramList.Params.Add(paramVal);

                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");

                    //string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";


                    string url = ServiceURL.UpdateProdCont + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {

                                    //for (var i = 0; i < lstProdCont.Count; i++)
                                    //{
                                    //  string InSiteUpdateMarineURL = ServiceURL.UpdateSyncFlagProdCont + "(" + lstProdCont[i].ProdContID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                    //    string InSiteSyncUpdateResult = new WebClient().DownloadString(InSiteUpdateMarineURL);
                                    //}

                                    MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                    JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                    marineSyncFlagUpdate.marineSyncFlagUpdate = (from i in lstProdCont
                                                                                 select new MarineSyncFlag { ID = i.ProdContID }).ToList<MarineSyncFlag>();

                                    jsonMarineSyncFlagUpdate.marineSyncFlag = marineSyncFlagUpdate;
                                    Results results = UpdateSyncFlag(jsonMarineSyncFlagUpdate, string.Format("{0}?{1}&", ServiceURL.UpdateSyncFlagProdCont, ConfigurationManager.AppSettings["ClientAPIKEY"].ToString()));

                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateProdCont - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }
                                }
                                else
                                {
                                    Logging.WriteLog("Error in UpdateProdCont - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateProdCont - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        /// <summary>
        /// UpdateINSiteBillingItem
        /// Function to update INSiteBillingItem
        /// </summary>
        public static void UpdateINSiteBillingItem()
        {
            try
            {
                string GetINSiteBillingItem = new WebClient().DownloadString(ServiceURL.GetINSiteBillingItemURL);
                //JArray results = JArray.Parse(json);
                List<INSiteBillingItem> lstINSiteBillingItem = JsonConvert.DeserializeObject<List<INSiteBillingItem>>(GetINSiteBillingItem);
                Logging.WriteLog("Function Called UpdateINSiteBillingItem - Count " + lstINSiteBillingItem.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstINSiteBillingItem.Count > 0)
                {
                    INSiteBillingItemJSONParam JsonParamValue = new INSiteBillingItemJSONParam();
                    INSiteBillingItemDetails INSiteBillingItem = new INSiteBillingItemDetails();
                    for (var i = 0; i < lstINSiteBillingItem.Count; i++)
                    {
                        INSiteBillingItem INSTBI = new INSiteBillingItem();
                        INSTBI.SiteID = lstINSiteBillingItem[i].SiteID;
                        INSTBI.BillingItemID = lstINSiteBillingItem[i].BillingItemID;
                        INSTBI.Active = lstINSiteBillingItem[i].Active;
                        INSTBI.BillingItemGLCodeID = lstINSiteBillingItem[i].BillingItemGLCodeID;
                        INSTBI.ClientID = lstINSiteBillingItem[i].ClientID;
                        INSTBI.ActiveMarneDelvApp = lstINSiteBillingItem[i].ActiveMarneDelvApp == 'Y' ? 'Y' : 'N';
                        INSiteBillingItem.INSiteBillingItemList.Add(INSTBI);
                    }

                    JsonParamValue.INSiteBillingItem = INSiteBillingItem;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                    ParamList paramList = new ParamList();
                    parameter paramVal = new parameter();
                    paramVal.name = "JsonValue";
                    //  paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");

                    paramList.Params.Add(paramVal);

                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");


                    // string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateINSiteBillingItemURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {

                                    //for (var i = 0; i < lstINSiteBillingItem.Count; i++)
                                    //{
                                    //    string INSiteBillingItemUpdateMarineURL = ServiceURL.UpdateSyncFlagINSiteBillingItem + "(" + lstINSiteBillingItem[i].BillingItemID + "," + lstINSiteBillingItem[i].SiteID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                    //    string INSiteBillingItemSyncUpdateResult = new WebClient().DownloadString(INSiteBillingItemUpdateMarineURL);
                                    //}

                                    INSiteBillingItemSyncFlagUpdate insiteBillingItemSyncFlagUpdate = new INSiteBillingItemSyncFlagUpdate();
                                    INSiteBillingItemSyncFlagUpdateJSONParam JSONParam = new INSiteBillingItemSyncFlagUpdateJSONParam();

                                    insiteBillingItemSyncFlagUpdate.billingItemSyncFlagUpdate = (from i in lstINSiteBillingItem
                                                                                                 select new INSiteBillingItemSyncFlag { BillingItemID = i.BillingItemID, SiteID = i.SiteID }).ToList<INSiteBillingItemSyncFlag>();

                                    JSONParam.billingItemSyncFlag = insiteBillingItemSyncFlagUpdate;
                                    Results results = UpdateSyncFlag(JSONParam, string.Format("{0}?{1}&", ServiceURL.UpdateSyncFlagINSiteBillingItem, ConfigurationManager.AppSettings["ClientAPIKEY"].ToString()));

                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateProdCont - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }
                                }
                                else
                                {
                                    Logging.WriteLog("Error in UpdateSyncFlagINSiteBillingItem - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateINSiteBillingItem - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        /// <summary>
        /// UpdateINSiteBillingItem
        /// Function to update INSiteTankProductAPI
        /// </summary>
        public static void UpdateINSiteTankProductAPI()
        {
            try
            {
                string GetINSiteTankProductAPI = new WebClient().DownloadString(ServiceURL.GetINSiteTankProductAPIURL);
                //JArray results = JArray.Parse(json);
                List<INSiteTankProductAPI> lstINSiteTankProductAPI = JsonConvert.DeserializeObject<List<INSiteTankProductAPI>>(GetINSiteTankProductAPI);
                Logging.WriteLog("Function Called UpdateINSiteTankProductAPI - Count " + lstINSiteTankProductAPI.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstINSiteTankProductAPI.Count > 0)
                {
                    INSiteTankProductAPIJSONParam JsonParamValue = new INSiteTankProductAPIJSONParam();
                    INSiteTankProductAPIDetails INSiteTankProductAPI = new INSiteTankProductAPIDetails();
                    for (var i = 0; i < lstINSiteTankProductAPI.Count; i++)
                    {
                        INSiteTankProductAPI INSTAPI = new INSiteTankProductAPI();
                        INSTAPI.ProductAPIID = lstINSiteTankProductAPI[i].ProductAPIID;
                        INSTAPI.InSiteTankID = lstINSiteTankProductAPI[i].InSiteTankID;
                        INSTAPI.ProdContID = lstINSiteTankProductAPI[i].ProdContID;
                        INSTAPI.API_Rating = lstINSiteTankProductAPI[i].API_Rating;
                        INSTAPI.Notes = lstINSiteTankProductAPI[i].Notes.EncodeString();
                        INSTAPI.EffDtTm = lstINSiteTankProductAPI[i].EffDtTm;
                        INSTAPI.CreatedDtTm = lstINSiteTankProductAPI[i].CreatedDtTm;
                        INSTAPI.CreatedByUser = lstINSiteTankProductAPI[i].CreatedByUser;
                        INSTAPI.ClientID = lstINSiteTankProductAPI[i].ClientID;

                        INSiteTankProductAPI.INSiteTankProductsAPIList.Add(INSTAPI);
                    }

                    JsonParamValue.INSiteTankProductsAPI = INSiteTankProductAPI;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                    ParamList paramList = new ParamList();

                    parameter paramVal = new parameter();

                    paramVal.name = "JsonValue";
                    // paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");
                    paramList.Params.Add(paramVal);

                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");
                    // string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateINSiteTankProductAPIURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {

                                    //for (var i = 0; i < lstINSiteTankProductAPI.Count; i++)
                                    //{
                                    // string INSiteTankProductAPIUpdateMarineURL = ServiceURL.UpdateSyncFlagINSiteTankProductAPI + "(" + lstINSiteTankProductAPI[i].ProductAPIID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                    //    string INSiteTankProductAPISyncUpdateResult = new WebClient().DownloadString(INSiteTankProductAPIUpdateMarineURL);
                                    //}

                                    MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                    JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                    marineSyncFlagUpdate.marineSyncFlagUpdate = (from i in lstINSiteTankProductAPI
                                                                                 select new MarineSyncFlag { ID = i.ProductAPIID }).ToList<MarineSyncFlag>();

                                    jsonMarineSyncFlagUpdate.marineSyncFlag = marineSyncFlagUpdate;
                                    Results results = UpdateSyncFlag(jsonMarineSyncFlagUpdate, string.Format("{0}?{1}&", ServiceURL.UpdateSyncFlagINSiteTankProductAPI, ConfigurationManager.AppSettings["ClientAPIKEY"].ToString()));

                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateINSiteTankProductAPI - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }

                                }
                                else
                                {
                                    Logging.WriteLog("Error in UpdateSyncFlagINSiteTankProductAPI - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateINSiteTankProductAPI - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        /// <summary>
        /// UpdateVehicles
        /// Function to Update Vehicles
        /// </summary>
        public static void UpdateVehicles()
        {
            try
            {
                string GetVehicle = new WebClient().DownloadString(ServiceURL.GetVehicleURL);
                List<Vehicle> lstVehicle = JsonConvert.DeserializeObject<List<Vehicle>>(GetVehicle);
                Logging.WriteLog("Function Called UpdateVehicles - Count " + lstVehicle.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstVehicle.Count > 0)
                {
                    VehicleJSONParam JsonParamValue = new VehicleJSONParam();
                    VehicleDetails Vehicle = new VehicleDetails();
                    for (var i = 0; i < lstVehicle.Count; i++)
                    {
                        Vehicle Veh = new Vehicle();
                        Veh.VehicleID = lstVehicle[i].VehicleID;
                        Veh.Code = lstVehicle[i].Code.EncodeString();
                        Veh.Descr = lstVehicle[i].Descr.EncodeString();
                        Veh.CarrierID = lstVehicle[i].CarrierID;
                        Veh.VehicleType = lstVehicle[i].VehicleType == null ? 0 : lstVehicle[i].VehicleType;
                        Veh.CompanyID = lstVehicle[i].CompanyID;
                        Veh.ClientID = lstVehicle[i].ClientID;
                        Veh.EnableSubCompartment = lstVehicle[i].EnableSubCompartment;
                        Veh.LastModifiedDtTm = lstVehicle[i].LastModifiedDtTm;
                        Veh.EnforceShipmentMarineApp = lstVehicle[i].EnforceShipmentMarineApp;
                        Vehicle.VehicleList.Add(Veh);
                    }
                    JsonParamValue.Vehicles = Vehicle;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                    ParamList paramList = new ParamList();

                    parameter paramVal = new parameter();
                    paramVal.name = "JsonValue";
                    //paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");
                    paramList.Params.Add(paramVal);


                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");

                    // string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateVehicleURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {

                                    //for (var i = 0; i < lstVehicle.Count; i++)
                                    //{
                                    //   string VehicleUpdateMarineURL = ServiceURL.UpdateSyncFlagVehicle + "(" + lstVehicle[i].VehicleID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                    //    string VehicleSyncUpdateResult = new WebClient().DownloadString(VehicleUpdateMarineURL);
                                    //}

                                    MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                    JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                    marineSyncFlagUpdate.marineSyncFlagUpdate = (from i in lstVehicle
                                                                                 select new MarineSyncFlag { ID = i.VehicleID }).ToList<MarineSyncFlag>();

                                    jsonMarineSyncFlagUpdate.marineSyncFlag = marineSyncFlagUpdate;
                                    Results results = UpdateSyncFlag(jsonMarineSyncFlagUpdate, string.Format("{0}?{1}&", ServiceURL.UpdateSyncFlagVehicle, ConfigurationManager.AppSettings["ClientAPIKEY"].ToString()));

                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateSyncFlagVehicle - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }

                                }
                                else
                                {
                                    Logging.WriteLog("Error in UpdateSyncFlagVehicle - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateVehicles - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        /// <summary>
        /// UpdateVehicleCompartments
        /// Function to Update VehicleCompartments
        /// </summary>
        public static void UpdateVehicleCompartments()
        {
            try
            {
                string GetVehicleCompartments = new WebClient().DownloadString(ServiceURL.GetVehicleCompartmentsURL);
                List<VehicleCompartments> lstVehicleCompartments = JsonConvert.DeserializeObject<List<VehicleCompartments>>(GetVehicleCompartments);
                Logging.WriteLog("Function Called UpdateVehicleCompartments - Count " + lstVehicleCompartments.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstVehicleCompartments.Count > 0)
                {
                    VehicleCompartmentJSONParam JsonParamValue = new VehicleCompartmentJSONParam();
                    VehicleCompartmentDetails VehicleComparmtent = new VehicleCompartmentDetails();
                    for (var i = 0; i < lstVehicleCompartments.Count; i++)
                    {
                        VehicleCompartments VehComp = new VehicleCompartments();
                        VehComp.CompartmentID = lstVehicleCompartments[i].CompartmentID;
                        VehComp.VehicleID = lstVehicleCompartments[i].VehicleID;
                        VehComp.Code = lstVehicleCompartments[i].Code.EncodeString();
                        VehComp.Capacity = lstVehicleCompartments[i].Capacity;
                        VehComp.Load_Rate = lstVehicleCompartments[i].Load_Rate;
                        VehComp.Unload_Rate = lstVehicleCompartments[i].Unload_Rate;
                        VehComp.ClientID = lstVehicleCompartments[i].ClientID;
                        VehComp.TankChartID = lstVehicleCompartments[i].TankChartID;
                        VehicleComparmtent.VehicleCompartmentList.Add(VehComp);
                    }
                    JsonParamValue.VehicleCompartments = VehicleComparmtent;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                    ParamList paramList = new ParamList();

                    parameter paramVal = new parameter();
                    paramVal.name = "JsonValue";
                    // paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");
                    paramList.Params.Add(paramVal);


                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");

                    //string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateVehicleCompartmentURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {

                                    //for (var i = 0; i < lstVehicleCompartments.Count; i++)
                                    //{
                                    //   string VehicleCompartmentsUpdateMarineURL = ServiceURL.UpdateSyncFlagVehicleCompartments + "(" + lstVehicleCompartments[i].CompartmentID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                    //    string VehicleCompartmentsSyncUpdateResult = new WebClient().DownloadString(VehicleCompartmentsUpdateMarineURL);
                                    //}

                                    MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                    JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                    marineSyncFlagUpdate.marineSyncFlagUpdate = (from i in lstVehicleCompartments
                                                                                 select new MarineSyncFlag { ID = i.CompartmentID }).ToList<MarineSyncFlag>();

                                    jsonMarineSyncFlagUpdate.marineSyncFlag = marineSyncFlagUpdate;
                                    Results results = UpdateSyncFlag(jsonMarineSyncFlagUpdate, string.Format("{0}?{1}&", ServiceURL.UpdateSyncFlagVehicleCompartments, ConfigurationManager.AppSettings["ClientAPIKEY"].ToString()));

                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateSyncFlagVehicleCompartments - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }

                                }
                                else
                                {
                                    Logging.WriteLog("Error in UpdateSyncFlagVehicleCompartments - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateVehicleCompartments - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        /// <summary>
        /// UpdateVehicleSubCompartments
        /// Function to Update VehicleSubCompartments
        /// </summary>
        public static void UpdateVehicleSubCompartments()
        {
            try
            {
                string GetVehicleSubCompartments = new WebClient().DownloadString(ServiceURL.GetVehicleSubCompartmentsURL);
                List<VehicleSubCompartments> lstVehicleSubCompartments = JsonConvert.DeserializeObject<List<VehicleSubCompartments>>(GetVehicleSubCompartments);
                Logging.WriteLog("Function Called UpdateVehicleSubCompartments - Count " + lstVehicleSubCompartments.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstVehicleSubCompartments.Count > 0)
                {
                    VehicleSubCompartmentJSONParam JsonParamValue = new VehicleSubCompartmentJSONParam();
                    VehicleSubCompartmentDetails VehicleSubComparmtent = new VehicleSubCompartmentDetails();
                    for (var i = 0; i < lstVehicleSubCompartments.Count; i++)
                    {
                        VehicleSubCompartments VehSubComp = new VehicleSubCompartments();
                        VehSubComp.SubCompartmentID = lstVehicleSubCompartments[i].SubCompartmentID;
                        VehSubComp.CompartmentID = lstVehicleSubCompartments[i].CompartmentID;
                        VehSubComp.ReadingSide = lstVehicleSubCompartments[i].ReadingSide;
                        VehSubComp.TankChartID = lstVehicleSubCompartments[i].TankChartID;
                        VehSubComp.ClientID = lstVehicleSubCompartments[i].ClientID;

                        VehicleSubComparmtent.VehicleSubCompartmentList.Add(VehSubComp);
                    }
                    JsonParamValue.VehicleSubCompartments = VehicleSubComparmtent;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                    ParamList paramList = new ParamList();

                    parameter paramVal = new parameter();

                    paramVal.name = "JsonValue";
                    // paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");
                    paramList.Params.Add(paramVal);


                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");
                    // string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateVehicleSubCompartmentURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {

                                    //for (var i = 0; i < lstVehicleSubCompartments.Count; i++)
                                    //{
                                    //   string VehicleSubCompartmentsUpdateMarineURL = ServiceURL.UpdateSyncFlagVehicleSubCompartments + "(" + lstVehicleSubCompartments[i].SubCompartmentID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                    //    string VehicleSubCompartmentsSyncUpdateResult = new WebClient().DownloadString(VehicleSubCompartmentsUpdateMarineURL);
                                    //}

                                    MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                    JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                    marineSyncFlagUpdate.marineSyncFlagUpdate = (from i in lstVehicleSubCompartments
                                                                                 select new MarineSyncFlag { ID = i.SubCompartmentID }).ToList<MarineSyncFlag>();

                                    jsonMarineSyncFlagUpdate.marineSyncFlag = marineSyncFlagUpdate;
                                    Results results = UpdateSyncFlag(jsonMarineSyncFlagUpdate, string.Format("{0}?{1}&", ServiceURL.UpdateSyncFlagVehicleSubCompartments, ConfigurationManager.AppSettings["ClientAPIKEY"].ToString()));

                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateSyncFlagVehicleSubCompartments - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }

                                }
                                else
                                {
                                    Logging.WriteLog("Error in UpdateSyncFlagVehicleSubCompartments - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateVehicleSubCompartments - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        ///// <summary>
        ///// UpdateLoginUser
        ///// Function to Update LoginUser
        ///// </summary>
        public static void UpdateLoginUser()
        {
            try
            {
                string GetLoginUser = new WebClient().DownloadString(ServiceURL.GetLoginUserURL);
                List<LoginUser> lstLoginUser = JsonConvert.DeserializeObject<List<LoginUser>>(GetLoginUser);
                Logging.WriteLog("Function Called UpdateLoginUser - Count " + lstLoginUser.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstLoginUser.Count > 0)
                {
                    LoginUserJSONParam JsonParamValue = new LoginUserJSONParam();
                    LoginUserDetails LoginUserDetail = new LoginUserDetails();
                    for (var i = 0; i < lstLoginUser.Count; i++)
                    {
                        LoginUser LoginUser = new LoginUser();
                        LoginUser.UserID = lstLoginUser[i].UserID;
                        LoginUser.Password = lstLoginUser[i].Password;
                        LoginUser.FirstName = lstLoginUser[i].FirstName.EncodeString();
                        LoginUser.MiddleName = lstLoginUser[i].MiddleName.EncodeString();
                        LoginUser.LastName = lstLoginUser[i].LastName.EncodeString();
                        LoginUser.Active = lstLoginUser[i].Active;
                        LoginUser.Email = lstLoginUser[i].Email;
                        LoginUser.AltEmail = lstLoginUser[i].AltEmail;
                        LoginUser.MarineAppAccess = lstLoginUser[i].MarineAppAccess;
                        LoginUser.ClientID = lstLoginUser[i].ClientID;

                        LoginUserDetail.LoginUserList.Add(LoginUser);
                    }
                    JsonParamValue.LoginUser = LoginUserDetail;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                    ParamList paramList = new ParamList();

                    parameter paramVal = new parameter();
                    paramVal.name = "JsonValue";
                    // paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");

                    paramList.Params.Add(paramVal);
                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");

                    //string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateLoginUserURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateLoginUser - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        /// <summary>
        /// UpdateDrivers
        /// Function to Update Drivers
        /// </summary>
        public static void UpdateDrivers()
        {
            try
            {
                string GetDrivers = new WebClient().DownloadString(ServiceURL.GetDriversURL);
                List<Drivers> lstDrivers = JsonConvert.DeserializeObject<List<Drivers>>(GetDrivers);
                Logging.WriteLog("Function Called UpdateDrivers - Count " + lstDrivers.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstDrivers.Count > 0)
                {
                    DriversJSONParam JsonParamValue = new DriversJSONParam();
                    DriversDetails Drivers = new DriversDetails();
                    for (var i = 0; i < lstDrivers.Count; i++)
                    {
                        Drivers Driv = new Drivers();
                        Driv.DriverID = lstDrivers[i].ClientID;
                        Driv.FirstName = lstDrivers[i].FirstName.EncodeString();
                        Driv.MiddleName = lstDrivers[i].MiddleName.EncodeString();
                        Driv.LastName = lstDrivers[i].LastName.EncodeString();
                        Driv.Email = lstDrivers[i].Email;
                        Driv.AltEmail = lstDrivers[i].AltEmail;
                        Driv.DriverNo = lstDrivers[i].DriverNo;
                        Driv.EmployeeNo = lstDrivers[i].EmployeeNo;
                        Driv.DriverType = lstDrivers[i].DriverType;
                        Driv.UserID = lstDrivers[i].UserID;
                        Driv.Password = lstDrivers[i].Password;
                        Driv.ClientID = lstDrivers[i].ClientID;
                        Driv.LastModifiedDtTm = lstDrivers[i].LastModifiedDtTm;
                        Driv.OriginateCompanyID = lstDrivers[i].OriginateCompanyID;

                        Drivers.DriversList.Add(Driv);
                    }
                    JsonParamValue.Drivers = Drivers;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                    ParamList paramList = new ParamList();


                    parameter paramVal = new parameter();
                    paramVal.name = "JsonValue";
                    //paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");


                    paramList.Params.Add(paramVal);


                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");

                    // string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateDriversURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateDrivers - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        /// <summary>
        /// UpdateCarrier
        /// Function to Update Carrier
        /// </summary>
        public static void UpdateCarrier()
        {
            try
            {
                string GetCarrier = new WebClient().DownloadString(ServiceURL.GetCarrierURL);
                List<Carrier> lstCarrier = JsonConvert.DeserializeObject<List<Carrier>>(GetCarrier);
                Logging.WriteLog("Function Called UpdateCarrier - Count " + lstCarrier.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstCarrier.Count > 0)
                {
                    CarrierJSONParam JsonParamValue = new CarrierJSONParam();
                    CarrierDetails Carriers = new CarrierDetails();
                    for (var i = 0; i < lstCarrier.Count; i++)
                    {
                        Carrier Car = new Carrier();
                        Car.CarrierID = lstCarrier[i].CarrierID;
                        Car.VendorID = lstCarrier[i].VendorID == null ? 0 : lstCarrier[i].VendorID;
                        Car.Code = lstCarrier[i].Code.EncodeString();
                        Car.Descr = lstCarrier[i].Descr.EncodeString();
                        Car.CompanyID = lstCarrier[i].CompanyID;
                        Car.ClientID = lstCarrier[i].ClientID;

                        Carriers.CarrierList.Add(Car);
                    }
                    JsonParamValue.Carriers = Carriers;
                    var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    ParamList paramList = new ParamList();


                    parameter paramVal = new parameter();

                    paramVal.name = "JsonValue";
                    // paramVal.param_type = "IN";
                    paramVal.value = jsonperVal.ToString().Replace("\\\\", "");

                    paramList.Params.Add(paramVal);

                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");

                    //string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateCarrierURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {

                                    //for (var i = 0; i < lstCarrier.Count; i++)
                                    //{
                                    //   string CarrierUpdateMarineURL = ServiceURL.UpdateSyncFlagCarrier + "(" + lstCarrier[i].CarrierID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                    //    string CarrierSyncUpdateResult = new WebClient().DownloadString(CarrierUpdateMarineURL);
                                    //}

                                    MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                    JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                    marineSyncFlagUpdate.marineSyncFlagUpdate = (from i in lstCarrier
                                                                                 select new MarineSyncFlag { ID = i.CarrierID }).ToList<MarineSyncFlag>();

                                    jsonMarineSyncFlagUpdate.marineSyncFlag = marineSyncFlagUpdate;
                                    Results results = UpdateSyncFlag(jsonMarineSyncFlagUpdate, string.Format("{0}?{1}&", ServiceURL.UpdateSyncFlagCarrier, ConfigurationManager.AppSettings["ClientAPIKEY"].ToString()));

                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateSyncFlagCarrier - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }
                                }
                                else
                                {
                                    Logging.WriteLog("Error in UpdateSyncFlagCarrier - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateCarrier - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        /// <summary>
        /// UpdateARShipTo
        /// Function to Update ARShipTo
        /// </summary>
        public static void UpdateARShipTo()
        {
            try
            {
                string GetARShipTo = new WebClient().DownloadString(ServiceURL.GetARShipToURL);
                List<ARShipTo> lstARShipTo = JsonConvert.DeserializeObject<List<ARShipTo>>(GetARShipTo);
                Logging.WriteLog("Function Called UpdateARShipTo - Count " + lstARShipTo.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstARShipTo.Count > 0)
                {
                    ARShipToJSONParam JsonParamValue = new ARShipToJSONParam();
                    ARShipToDetails ARShipToDetail = new ARShipToDetails();
                    for (var i = 0; i < lstARShipTo.Count; i++)
                    {
                        ARShipTo ARS = new ARShipTo();
                        ARS.ShipToId = lstARShipTo[i].ShipToId;
                        ARS.StandardAcctID = lstARShipTo[i].StandardAcctID;
                        ARS.StandardAcctNo = lstARShipTo[i].StandardAcctNo;
                        ARS.CustomerName = lstARShipTo[i].CustomerName.EncodeString();
                        ARS.DBAName = lstARShipTo[i].DBAName.EncodeString();
                        ARS.CreditHold = lstARShipTo[i].CreditHold;
                        ARS.CreditLimitAmt = lstARShipTo[i].CreditLimitAmt;
                        //ARS.ContactName = lstARShipTo[i].ContactName;
                        //ARS.ContactEmail = lstARShipTo[i].ContactEmail;
                        //ARS.PhoneNo = lstARShipTo[i].PhoneNo;
                        ARS.FormattedCode = lstARShipTo[i].FormattedCode.EncodeString();
                        ARS.LongDescr = lstARShipTo[i].LongDescr.EncodeString();
                        ARS.LastModifiedDtTm = lstARShipTo[i].LastModifiedDtTm;
                        ARS.ClientID = lstARShipTo[i].ClientID;
                        ARS.FormattedAddress = lstARShipTo[i].FormattedAddress.EncodeString();
                        ARS.PrimaryPhone = string.IsNullOrEmpty(lstARShipTo[i].PrimaryPhone) ? null : lstARShipTo[i].PrimaryPhone.Trim();

                        ARShipToDetail.ARShipToList.Add(ARS);
                    }
                    JsonParamValue.ARShipTo = ARShipToDetail;

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                    //var jsonperVal = jsonSerialiser.Serialize(jsonIgnoreNullValues);
                    ParamList paramList = new ParamList();

                    parameter paramVal = new parameter();

                    paramVal.name = "JsonValue";
                    //paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");
                    paramList.Params.Add(paramVal);


                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");


                    // string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateARShipToURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {

                                    //for (var i = 0; i < lstARShipTo.Count; i++)
                                    //{
                                    //    string ShipmentNeedUpdateMarineURL = ServiceURL.UpdateSyncFlagARShipTo + "(" + lstARShipTo[i].ShipToId + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                    //    string MarineSyncUpdateResult = new WebClient().DownloadString(ShipmentNeedUpdateMarineURL);
                                    //}

                                    MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                    JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                    marineSyncFlagUpdate.marineSyncFlagUpdate = (from i in lstARShipTo
                                                                                 select new MarineSyncFlag { ID = i.ShipToId }).ToList<MarineSyncFlag>();

                                    jsonMarineSyncFlagUpdate.marineSyncFlag = marineSyncFlagUpdate;
                                    Results results = UpdateSyncFlag(jsonMarineSyncFlagUpdate, string.Format("{0}?{1}&", ServiceURL.UpdateSyncFlagARShipTo, ConfigurationManager.AppSettings["ClientAPIKEY"].ToString()));

                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateSyncFlagARShipTo - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }

                                }
                                else
                                {
                                    Logging.WriteLog("Error in UpdateSyncFlagARShipTo - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateARShipTo - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        /// <summary>
        /// UpdatePerson
        /// Function to Update Person
        /// </summary>
        public static void UpdatePerson()
        {
            try
            {
                string GetPerson = new WebClient().DownloadString(ServiceURL.GetPersonURL);
                List<Person> lstPerson = JsonConvert.DeserializeObject<List<Person>>(GetPerson);
                Logging.WriteLog("Function Called UpdatePerson - Count " + lstPerson.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstPerson.Count > 0)
                {
                    PersonJSONParam JsonParamValue = new PersonJSONParam();
                    PersonDetails PersonDetail = new PersonDetails();
                    for (var i = 0; i < lstPerson.Count; i++)
                    {
                        Person Pers = new Person();
                        Pers.PersonID = lstPerson[i].PersonID;
                        Pers.FirstName = lstPerson[i].FirstName == null ? lstPerson[i].FirstName : lstPerson[i].FirstName.EncodeString();
                        Pers.MiddleName = lstPerson[i].MiddleName == null ? lstPerson[i].MiddleName : lstPerson[i].MiddleName.EncodeString();
                        Pers.LastName = lstPerson[i].LastName == null ? null : lstPerson[i].LastName.EncodeString();
                        Pers.Email = string.IsNullOrEmpty(lstPerson[i].Email) ? null : lstPerson[i].Email;
                        Pers.AvailableHours = lstPerson[i].AvailableHours;
                        Pers.Employee = lstPerson[i].Employee;
                        Pers.Title = string.IsNullOrEmpty(lstPerson[i].Title) ? null : lstPerson[i].Title.EncodeString();
                        Pers.AltEmail = lstPerson[i].AltEmail;
                        Pers.ContactShiptoID = lstPerson[i].ContactShiptoID;
                        Pers.ContactSupplierID = lstPerson[i].ContactSupplierID;
                        Pers.ContactSupptID = lstPerson[i].ContactSupptID;
                        Pers.ContactCarrierID = lstPerson[i].ContactCarrierID;
                        Pers.ContactSiteID = lstPerson[i].ContactSiteID;
                        Pers.LastModifiedUser = lstPerson[i].LastModifiedUser;
                        Pers.LastModifiedDtTm = lstPerson[i].LastModifiedDtTm;
                        Pers.CollectionGroupID = lstPerson[i].CollectionGroupID;
                        Pers.ContactVendorID = lstPerson[i].ContactVendorID;
                        Pers.ClientID = lstPerson[i].ClientID;
                        Pers.ContactShipToVesselID = lstPerson[i].ContactShipToVesselID;
                        Pers.EnabledInternationalAddress = lstPerson[i].EnabledInternationalAddress;
                        Pers.Name = lstPerson[i].Name == null ? lstPerson[i].Name : lstPerson[i].Name.Trim().Contains("'") ? lstPerson[i].Name.Trim().Replace("'", "''") : lstPerson[i].Name.Trim();
                        Pers.FullName = lstPerson[i].FullName == null ? lstPerson[i].FullName : lstPerson[i].FullName.Trim().Contains("'") ? lstPerson[i].FullName.Trim().Replace("'", "''") : lstPerson[i].FullName.Trim();

                        PersonDetail.PersonList.Add(Pers);
                    }
                    JsonParamValue.Person = PersonDetail;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                    ParamList paramList = new ParamList();

                    parameter paramVal = new parameter();

                    paramVal.name = "JsonValue";
                    // paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");

                    paramList.Params.Add(paramVal);

                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");

                    // string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdatePersonURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {

                                    //for (var i = 0; i < lstPerson.Count; i++)
                                    //{
                                    //    string PersonNeedUpdateMarineURL = ServiceURL.UpdateSyncFlagPerson + "(" + lstPerson[i].PersonID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                    //    string PersonSyncUpdateResult = new WebClient().DownloadString(PersonNeedUpdateMarineURL);
                                    //}
                                }
                                else
                                {
                                    Logging.WriteLog("Error in UpdateSyncFlagPerson - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdatePerson - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        /// <summary>
        /// UpdatePersonPhone
        /// Function to Update Person Phone
        /// </summary>
        public static void UpdatePersonPhone()
        {
            try
            {
                string GetPersonPhone = new WebClient().DownloadString(ServiceURL.GetPersonPhoneURL);
                List<PersonPhone> lstPersonPhone = JsonConvert.DeserializeObject<List<PersonPhone>>(GetPersonPhone);
                Logging.WriteLog("Function Called UpdatePersonPhone - Count " + lstPersonPhone.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstPersonPhone.Count > 0)
                {
                    PersonPhoneJSONParam JsonParamValue = new PersonPhoneJSONParam();
                    PersonPhoneDetails PersonPhoneDetail = new PersonPhoneDetails();
                    for (var i = 0; i < lstPersonPhone.Count; i++)
                    {
                        PersonPhone PersPh = new PersonPhone();

                        PersPh.PhoneID = lstPersonPhone[i].PhoneID;
                        PersPh.PersonID = lstPersonPhone[i].PersonID;
                        PersPh.PhoneNo = lstPersonPhone[i].PhoneNo;
                        PersPh.Type = lstPersonPhone[i].Type == null ? 0 : lstPersonPhone[i].Type;
                        PersPh.Extension = lstPersonPhone[i].Extension;
                        PersPh.ClientID = lstPersonPhone[i].ClientID;

                        PersonPhoneDetail.PersonPhoneList.Add(PersPh);
                    }
                    JsonParamValue.PersonPhone = PersonPhoneDetail;
                    var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    ParamList paramList = new ParamList();

                    parameter paramVal = new parameter();
                    paramVal.name = "JsonValue";
                    //  paramVal.param_type = "IN";
                    paramVal.value = jsonperVal.ToString().Replace("\\\\", "");

                    paramList.Params.Add(paramVal);


                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");

                    //string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdatePersonPhoneURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {
                                    //for (int i = 0; i < lstPersonPhone.Count; i++)
                                    //{
                                    //    string PersonPhoneNeedUpdateMarineURL = ServiceURL.UpdateSyncFlagPersonPhone + "(" + lstPersonPhone[i].PhoneID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                    //    string PersonPhoneSyncUpdateResult = new WebClient().DownloadString(PersonPhoneNeedUpdateMarineURL);
                                    //}

                                    MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                    JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                    marineSyncFlagUpdate.marineSyncFlagUpdate = (from i in lstPersonPhone
                                                                                 select new MarineSyncFlag { ID = i.PhoneID }).ToList<MarineSyncFlag>();

                                    jsonMarineSyncFlagUpdate.marineSyncFlag = marineSyncFlagUpdate;
                                    Results results = UpdateSyncFlag(jsonMarineSyncFlagUpdate, string.Format("{0}?{1}&", ServiceURL.UpdateSyncFlagPersonPhone, ConfigurationManager.AppSettings["ClientAPIKEY"].ToString()));

                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateSyncFlagPersonPhone - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }


                                }
                                else
                                {
                                    Logging.WriteLog("Error in UpdateSyncFlagPersonPhone - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdatePersonPhone - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        ///// <summary>
        ///// UpdateProducts
        ///// Function to Update Products
        ///// </summary>
        public static void UpdateProducts()
        {
            try
            {
                string GetProducts = new WebClient().DownloadString(ServiceURL.GetProductsToURL);
                List<Products> lstProducts = JsonConvert.DeserializeObject<List<Products>>(GetProducts);
                Logging.WriteLog("Function Called UpdateProducts - Count " + lstProducts.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstProducts.Count > 0)
                {
                    ProductsJSONParam JsonParamValue = new ProductsJSONParam();
                    ProductsDetails ProductsDetail = new ProductsDetails();
                    for (var i = 0; i < lstProducts.Count; i++)
                    {

                        Products Prod = new Products();
                        Prod.ClientID = lstProducts[i].ClientID;
                        Prod.MasterProdID = lstProducts[i].MasterProdID == null ? 0 : lstProducts[i].MasterProdID;
                        Prod.ProdID = lstProducts[i].ProdID == null ? 0 : lstProducts[i].ProdID;
                        Prod.CompanyID = lstProducts[i].CompanyID;
                        Prod.MasterProdType = lstProducts[i].MasterProdType;
                        Prod.ParentID = lstProducts[i].ParentID == null ? 0 : lstProducts[i].ParentID;
                        Prod.Code = lstProducts[i].Code.EncodeString();
                        Prod.Descr = lstProducts[i].Descr == null ? null : lstProducts[i].Descr.EncodeString();
                        Prod.SellByUOMID = lstProducts[i].SellByUOMID == null ? 0 : lstProducts[i].SellByUOMID;
                        Prod.DefOnHandUOMID = lstProducts[i].DefOnHandUOMID == null ? 0 : lstProducts[i].DefOnHandUOMID;
                        Prod.DefCountUOMID = lstProducts[i].DefCountUOMID == null ? 0 : lstProducts[i].DefCountUOMID;
                        Prod.DefCountFrequencyID = lstProducts[i].DefCountFrequencyID == null ? 0 : lstProducts[i].DefCountFrequencyID;
                        Prod.DefConversionUOMID = lstProducts[i].DefConversionUOMID == null ? 0 : lstProducts[i].DefConversionUOMID;
                        Prod.DefConversionFactor = lstProducts[i].DefConversionFactor == null ? 0 : lstProducts[i].DefConversionFactor;
                        Prod.HzrdMaterialID = lstProducts[i].HzrdMaterialID == null ? 0 : lstProducts[i].HzrdMaterialID;
                        Prod.Explanation = lstProducts[i].Explanation;
                        Prod.BIUOMID = lstProducts[i].BIUOMID == null ? 0 : lstProducts[i].BIUOMID;
                        Prod.BIEnableTankReadings = lstProducts[i].BIEnableTankReadings;
                        Prod.SpecificGravity = lstProducts[i].SpecificGravity == null ? 0 : lstProducts[i].SpecificGravity;
                        Prod.BIActiveMarneDelvApp = lstProducts[i].BIActiveMarneDelvApp == null ? 'N' : lstProducts[i].BIActiveMarneDelvApp;
                        Prod.TemperatureCorrectID = lstProducts[i].TemperatureCorrectID == null ? 0 : lstProducts[i].TemperatureCorrectID;
                        Prod.IsBulk = lstProducts[i].IsBulk == null ? 'N' : lstProducts[i].IsBulk;
                        ProductsDetail.ProductList.Add(Prod);
                    }

                    JsonParamValue.Product = ProductsDetail;
                    // var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonperVal = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                    ParamList paramList = new ParamList();


                    parameter paramVal = new parameter();

                    paramVal.name = "JsonValue";
                    // paramVal.param_type = "IN";
                    paramVal.value = jsonperVal.ToString().Replace("\\\\", "");

                    paramList.Params.Add(paramVal);


                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");

                    //   string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateProductsURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                            {
                                //string ProductNeedUpdateMarineURL = ServiceURL.UpdateSyncFlagProduct + "(" + lstProducts[i].MasterProdID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                //string ProductSyncUpdateResult = new WebClient().DownloadString(ProductNeedUpdateMarineURL);

                                MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                marineSyncFlagUpdate.marineSyncFlagUpdate = (from i in lstProducts
                                                                             select new MarineSyncFlag { ID = i.MasterProdID }).ToList<MarineSyncFlag>();

                                jsonMarineSyncFlagUpdate.marineSyncFlag = marineSyncFlagUpdate;
                                Results results = UpdateSyncFlag(jsonMarineSyncFlagUpdate, string.Format("{0}?{1}&", ServiceURL.UpdateSyncFlagProduct, ConfigurationManager.AppSettings["ClientAPIKEY"].ToString()));

                                if (results.StatusNew.ToString().ToLower() != "success")
                                {
                                    Logging.WriteLog("Error in UpdateSyncFlagMarineLoc - " + results.Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                            else
                            {
                                Logging.WriteLog("Error in UpdateSyncFlagProduct - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                            }
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateProducts - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        public static void UpdateSalesContractSalesAlias()
        {
            try
            {
                string GetSalesContractSalesAlias = new WebClient().DownloadString(ServiceURL.GetSalesContractSalesAlias);
                List<SalesContractSalesAlias> lstSalesContractSalesAlias = JsonConvert.DeserializeObject<List<SalesContractSalesAlias>>(GetSalesContractSalesAlias);
                Logging.WriteLog("Function Called UpdateSalesContractSalesAlias - Count " + lstSalesContractSalesAlias.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };

                if (lstSalesContractSalesAlias.Count() > 0)
                {

                    SalesContractSalesAliasJSONParam JsonParamValue = new SalesContractSalesAliasJSONParam();
                    SalesContractSalesAliasDetails SalesContractSalesAliasDetails = new SalesContractSalesAliasDetails();


                    SalesContractSalesAliasDetails.SalesContractSalesAliasList = lstSalesContractSalesAlias.Select(s => (new SalesContractSalesAlias
                    {
                        SysTrxNo = s.SysTrxNo,
                        CompanyID = s.CompanyID,
                        ContractDescr = s.ContractDescr.EncodeString(),
                        ContractID = s.ContractID.EncodeString(),
                        StartDate = s.StartDate,
                        EndDate = s.EndDate,
                        SalesAliasID = s.SalesAliasID,
                        ShiptoID = s.ShiptoID,
                        StandardAcctID = s.StandardAcctID,
                        SysTrxLine = s.SysTrxLine,
                        VendorProductxRef = s.VendorProductxRef.EncodeString()
                    })).ToList();

                    JsonParamValue.SalesContractSalesAlias = SalesContractSalesAliasDetails;

                    string jsonperVal = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                    ParamList paramList = new ParamList();


                    parameter paramVal = new parameter();

                    paramVal.name = "JsonValue";
                    paramVal.value = jsonperVal.ToString().Replace("\\\\", "");

                    paramList.Params.Add(paramVal);

                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");


                    string url = ServiceURL.UpdateSalesContractSalesAlias + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult[0].StatusNew.ToString().ToLower() != "success")
                            {
                                Logger.WriteErrorLog(string.Format("{0} - {1} ", "UpdateSalesContractSalesAlias", lsResult[0].Reason));
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Logger.WriteErrorLog(string.Format("{0} - {1} ", "UpdateSalesContractSalesAlias", ex.Message));
            }
        }

        ///// <summary>
        ///// UpdateUOMType
        ///// Function to Update UOMType
        ///// </summary>
        public static void UpdateUOMType()
        {
            try
            {
                string GetUOMType = new WebClient().DownloadString(ServiceURL.GetUOMTypeURL);
                List<UOMType> lstUOMType = JsonConvert.DeserializeObject<List<UOMType>>(GetUOMType);
                Logging.WriteLog("Function Called UpdateUOMType - Count " + lstUOMType.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstUOMType.Count > 0)
                {
                    UOMTypeJSONParam JsonParamValue = new UOMTypeJSONParam();
                    UOMTypeDetails UOMTypeDetail = new UOMTypeDetails();
                    for (var i = 0; i < lstUOMType.Count; i++)
                    {
                        UOMType uomType = new UOMType();
                        uomType.Type = lstUOMType[i].Type;
                        uomType.Descr = lstUOMType[i].Descr.EncodeString();
                        uomType.ClientID = lstUOMType[i].ClientID;

                        UOMTypeDetail.UOMTypeList.Add(uomType);
                    }
                    JsonParamValue.UOMType = UOMTypeDetail;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                    ParamList paramList = new ParamList();

                    parameter paramVal = new parameter();

                    paramVal.name = "JsonValue";
                    // paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");

                    paramList.Params.Add(paramVal);


                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");

                    // string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateUOMTypeURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateUOMType - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        ///// <summary>
        ///// UpdateUOM
        ///// Function to Update UOM
        ///// </summary>
        public static void UpdateUOM()
        {
            try
            {
                string GetUOM = new WebClient().DownloadString(ServiceURL.GetUOMURL);
                List<UOM> lstUOM = JsonConvert.DeserializeObject<List<UOM>>(GetUOM);
                Logging.WriteLog("Function Called UpdateUOM - Count " + lstUOM.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstUOM.Count > 0)
                {
                    UOMJSONParam JsonParamValue = new UOMJSONParam();
                    UOMDetails UOMDetail = new UOMDetails();
                    for (var i = 0; i < lstUOM.Count; i++)
                    {
                        UOM uom = new UOM();
                        uom.UOMID = lstUOM[i].UOMID;
                        uom.Code = lstUOM[i].Code.EncodeString();
                        uom.LongDescr = lstUOM[i].LongDescr.EncodeString();
                        uom.Base = lstUOM[i].Base;
                        uom.Volume = lstUOM[i].Volume;
                        uom.ConversionFactor = lstUOM[i].ConversionFactor;
                        uom.ConversionUOMID = lstUOM[i].ConversionUOMID;
                        uom.BaseUOMFactor = lstUOM[i].BaseUOMFactor;
                        uom.BaseUOMID = lstUOM[i].BaseUOMID;
                        uom.ClientID = lstUOM[i].ClientID;
                        uom.LastModifiedDtTm = lstUOM[i].LastModifiedDtTm;
                        uom.UOMType = lstUOM[i].UOMType;
                        uom.IsPackaged = lstUOM[i].IsPackaged;


                        UOMDetail.UOMList.Add(uom);
                    }
                    JsonParamValue.UOM = UOMDetail;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                    ParamList paramList = new ParamList();

                    parameter paramVal = new parameter();
                    paramVal.name = "JsonValue";
                    // paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");
                    paramList.Params.Add(paramVal);


                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");

                    //string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateUOMURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {

                                    //for (var i = 0; i < lstUOM.Count; i++)
                                    //{
                                    //     string UOMNeedUpdateMarineURL = ServiceURL.UpdateSyncFlagUOM + "(" + lstUOM[i].UOMID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                    //    string UOMSyncUpdateResult = new WebClient().DownloadString(UOMNeedUpdateMarineURL);
                                    //}

                                    MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                    JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                    marineSyncFlagUpdate.marineSyncFlagUpdate = (from i in lstUOM
                                                                                 select new MarineSyncFlag { ID = i.UOMID }).ToList<MarineSyncFlag>();

                                    jsonMarineSyncFlagUpdate.marineSyncFlag = marineSyncFlagUpdate;
                                    Results results = UpdateSyncFlag(jsonMarineSyncFlagUpdate, string.Format("{0}?{1}&", ServiceURL.UpdateSyncFlagUOM, ConfigurationManager.AppSettings["ClientAPIKEY"].ToString()));

                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateSyncFlagUOM - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }



                                }
                                else
                                {
                                    Logging.WriteLog("Error in UpdateSyncFlagUOM - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateUOM - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        ///// <summary>
        ///// UpdateMarineLocType
        ///// Function to Update MarineLocType
        ///// </summary>
        public static void UpdateMarineLocType()
        {
            try
            {
                string GetMarineLocType = new WebClient().DownloadString(ServiceURL.GetMarineLocTypeURL);
                List<MarineLocType> lstMarineLocType = JsonConvert.DeserializeObject<List<MarineLocType>>(GetMarineLocType);
                Logging.WriteLog("Function Called UpdateMarineLocType - Count " + lstMarineLocType.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstMarineLocType.Count > 0)
                {
                    MarineLocTypeJSONParam JsonParamValue = new MarineLocTypeJSONParam();
                    MarineLocTypeDetails MarineLocTypeDetail = new MarineLocTypeDetails();
                    for (var i = 0; i < lstMarineLocType.Count; i++)
                    {
                        MarineLocType marinelocType = new MarineLocType();
                        marinelocType.LocTypeID = lstMarineLocType[i].LocTypeID;
                        marinelocType.LocType = lstMarineLocType[i].LocType;
                        marinelocType.Descr = lstMarineLocType[i].Descr.EncodeString();
                        marinelocType.ClientID = lstMarineLocType[i].ClientID;

                        MarineLocTypeDetail.MarineLocTypeList.Add(marinelocType);
                    }
                    JsonParamValue.MarineLocType = MarineLocTypeDetail;
                    var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);
                    ParamList paramList = new ParamList();

                    parameter paramVal = new parameter();
                    paramVal.name = "JsonValue";
                    // paramVal.param_type = "IN";
                    paramVal.value = jsonperVal.ToString().Replace("\\\\", "");
                    paramList.Params.Add(paramVal);

                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");
                    // string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateMarineLocTypeURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateMarineLocType - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }


        ///// <summary>
        ///// UpdateMarineRegion
        ///// Function to Update MarineRegion
        ///// </summary>
        public static void UpdateMarineRegion()
        {
            try
            {
                string GetMarineRegion = new WebClient().DownloadString(ServiceURL.GetMarineRegionURL);
                List<MarineRegion> lstMarineRegion = JsonConvert.DeserializeObject<List<MarineRegion>>(GetMarineRegion);
                Logging.WriteLog("Function Called UpdateMarineRegion - Count " + lstMarineRegion.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstMarineRegion.Count > 0)
                {
                    MarineRegionJSONParam JsonParamValue = new MarineRegionJSONParam();
                    MarineRegionDetails MarineRegionDetail = new MarineRegionDetails();
                    for (var i = 0; i < lstMarineRegion.Count; i++)
                    {
                        MarineRegion MarineRegion = new MarineRegion();
                        MarineRegion.MarineRegionID = lstMarineRegion[i].MarineRegionID;
                        MarineRegion.Code = lstMarineRegion[i].Code.EncodeString();
                        MarineRegion.Descr = lstMarineRegion[i].Descr.EncodeString();
                        MarineRegion.ClientID = lstMarineRegion[i].ClientID;

                        MarineRegionDetail.MarineRegionList.Add(MarineRegion);
                    }
                    JsonParamValue.MarineRegion = MarineRegionDetail;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                    ParamList paramList = new ParamList();

                    parameter paramVal = new parameter();

                    paramVal.name = "JsonValue";
                    //paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");
                    paramList.Params.Add(paramVal);


                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");

                    //string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateMarineRegionURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {

                                    //for (var i = 0; i < lstMarineRegion.Count; i++)
                                    //{
                                    //    string MarineRegionNeedUpdateMarineURL = ServiceURL.UpdateSyncFlagMarineRegion + "(" + lstMarineRegion[i].MarineRegionID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                    //    string MarineRegionSyncUpdateResult = new WebClient().DownloadString(MarineRegionNeedUpdateMarineURL);
                                    //}

                                    MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                    JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                    marineSyncFlagUpdate.marineSyncFlagUpdate = (from i in lstMarineRegion
                                                                                 select new MarineSyncFlag { ID = i.MarineRegionID }).ToList<MarineSyncFlag>();

                                    jsonMarineSyncFlagUpdate.marineSyncFlag = marineSyncFlagUpdate;
                                    Results results = UpdateSyncFlag(jsonMarineSyncFlagUpdate, string.Format("{0}?{1}&", ServiceURL.UpdateSyncFlagMarineRegion, ConfigurationManager.AppSettings["ClientAPIKEY"].ToString()));

                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateSyncFlagMarineRegion - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }

                                }
                                else
                                {
                                    Logging.WriteLog("Error in UpdateSyncFlagMarineRegion - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateMarineRegion - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        ///// <summary>
        ///// UpdateMarineLoc
        ///// Function to Update MarineLoc
        ///// </summary>
        public static void UpdateMarineLoc()
        {
            try
            {
                string GetMarineLoc = new WebClient().DownloadString(ServiceURL.GetMarineLocURL);
                List<MarineLoc> lstMarineLoc = JsonConvert.DeserializeObject<List<MarineLoc>>(GetMarineLoc);
                Logging.WriteLog("Function Called UpdateMarineLoc - Count " + lstMarineLoc.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstMarineLoc.Count > 0)
                {
                    MarineLocJSONParam JsonParamValue = new MarineLocJSONParam();
                    MarineLocDetails MarineLocDetail = new MarineLocDetails();
                    for (var i = 0; i < lstMarineLoc.Count; i++)
                    {
                        MarineLoc marineloc = new MarineLoc();
                        marineloc.MarineLocID = lstMarineLoc[i].MarineLocID;
                        marineloc.CompanyID = lstMarineLoc[i].CompanyID;
                        marineloc.Code = lstMarineLoc[i].Code.EncodeString();
                        marineloc.Descr = lstMarineLoc[i].Descr.EncodeString();
                        marineloc.LocTypeID = lstMarineLoc[i].LocTypeID;
                        marineloc.DisplayFlag = lstMarineLoc[i].DisplayFlag;
                        marineloc.RegionID = lstMarineLoc[i].RegionID;
                        marineloc.FrtZoneID = lstMarineLoc[i].FrtZoneID;
                        marineloc.Latitude = lstMarineLoc[i].Latitude;
                        marineloc.Longitude = lstMarineLoc[i].Longitude;
                        marineloc.TaxProfileID = lstMarineLoc[i].TaxProfileID;
                        marineloc.CountryID = lstMarineLoc[i].CountryID;
                        marineloc.StateID = lstMarineLoc[i].StateID;
                        marineloc.CountyID = lstMarineLoc[i].CountyID;
                        marineloc.CityID = lstMarineLoc[i].CityID;
                        marineloc.LastModifiedDtTm = lstMarineLoc[i].LastModifiedDtTm;
                        marineloc.ClientID = lstMarineLoc[i].ClientID;
                        marineloc.DefLocDescr = lstMarineLoc[i].DefLocDescr.EncodeString();

                        MarineLocDetail.MarineLocList.Add(marineloc);
                    }
                    JsonParamValue.MarineLoc = MarineLocDetail;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                    ParamList paramList = new ParamList();


                    parameter paramVal = new parameter();
                    paramVal.name = "JsonValue";
                    // paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");
                    paramList.Params.Add(paramVal);


                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");

                    //string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateMarineLocURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {

                                    //for (var i = 0; i < lstMarineLoc.Count; i++)
                                    //{
                                    //    string MarineLocNeedUpdateMarineURL = ServiceURL.UpdateSyncFlagMarineLoc + "(" + lstMarineLoc[i].MarineLocID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                    //    string MarineLocSyncUpdateResult = new WebClient().DownloadString(MarineLocNeedUpdateMarineURL);
                                    //}
                                    MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                    JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                    marineSyncFlagUpdate.marineSyncFlagUpdate = (from m in lstMarineLoc
                                                                                 select new MarineSyncFlag { ID = m.MarineLocID }).ToList<MarineSyncFlag>();

                                    jsonMarineSyncFlagUpdate.marineSyncFlag = marineSyncFlagUpdate;
                                    Results results = UpdateSyncFlag(jsonMarineSyncFlagUpdate, string.Format("{0}?{1}&", ServiceURL.UpdateSyncFlagMarineLoc, ConfigurationManager.AppSettings["ClientAPIKEY"].ToString()));

                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateMarineLoc - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }
                                }
                                else
                                {
                                    Logging.WriteLog("Error in UpdateSyncFlagMarineLoc - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateMarineLoc - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        ///// <summary>
        ///// UpdateMarineAppSalesPLUButtons
        ///// Function to Update MarineAppSalesPLUButtons
        ///// </summary>
        public static void UpdateMarineAppSalesPLUButtons()
        {
            try
            {
                string GetMarineAppSalesPLUButtons = new WebClient().DownloadString(ServiceURL.GetMarineAppSalesPLUButtonsURL);
                List<MarineAppSalesPLUButtons> lstMarineAppSalesPLUButtons = JsonConvert.DeserializeObject<List<MarineAppSalesPLUButtons>>(GetMarineAppSalesPLUButtons);
                Logging.WriteLog("Function Called UpdateMarineAppSalesPLUButtons - Count " + lstMarineAppSalesPLUButtons.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstMarineAppSalesPLUButtons.Count > 0)
                {
                    MarineAppSalesPLUButtonsJSONParam JsonParamValue = new MarineAppSalesPLUButtonsJSONParam();
                    MarineAppSalesPLUButtonsDetails MarineAppSalesPLUButtonsDetail = new MarineAppSalesPLUButtonsDetails();
                    for (var i = 0; i < lstMarineAppSalesPLUButtons.Count; i++)
                    {
                        MarineAppSalesPLUButtons MarineAppSalesPLUButtons = new MarineAppSalesPLUButtons();
                        MarineAppSalesPLUButtons.Position = lstMarineAppSalesPLUButtons[i].Position;
                        MarineAppSalesPLUButtons.SiteID = lstMarineAppSalesPLUButtons[i].SiteID;
                        MarineAppSalesPLUButtons.MasterProdID = lstMarineAppSalesPLUButtons[i].MasterProdID;
                        MarineAppSalesPLUButtons.ClientID = lstMarineAppSalesPLUButtons[i].ClientID;

                        MarineAppSalesPLUButtonsDetail.MarineAppSalesPLUButtonsList.Add(MarineAppSalesPLUButtons);
                    }
                    JsonParamValue.MarineAppSalesPLUButtons = MarineAppSalesPLUButtonsDetail;
                    var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    ParamList paramList = new ParamList();

                    parameter paramVal = new parameter();
                    paramVal.name = "JsonValue";
                    //  paramVal.param_type = "IN";
                    paramVal.value = jsonperVal.ToString().Replace("\\\\", "");

                    paramList.Params.Add(paramVal);
                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");


                    //string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateMarineAppSalesPLUButtonsURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateMarineAppSalesPLUButtons - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        ///// <summary>
        ///// UpdateTankChart
        ///// Function to Update TankChart
        ///// </summary>
        public static void UpdateTankChart()
        {
            try
            {
                string GetTankChart = new WebClient().DownloadString(ServiceURL.GetTankChartURL);
                List<TankChart> lstTankChart = JsonConvert.DeserializeObject<List<TankChart>>(GetTankChart);
                Logging.WriteLog("Function Called UpdateTankChart - Count " + lstTankChart.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstTankChart.Count > 0)
                {
                    TankChartJSONParam JsonParamValue = new TankChartJSONParam();
                    TankChartDetails TankChartDetail = new TankChartDetails();
                    for (var i = 0; i < lstTankChart.Count; i++)
                    {
                        TankChart tankChart = new TankChart();
                        tankChart.TankChartID = lstTankChart[i].TankChartID;
                        tankChart.Code = lstTankChart[i].Code.EncodeString();
                        tankChart.Descr = lstTankChart[i].Descr.EncodeString();
                        tankChart.LMeasure = lstTankChart[i].LMeasure;
                        tankChart.VMeasure = lstTankChart[i].VMeasure;
                        tankChart.Active = lstTankChart[i].Active;
                        tankChart.VolumeUOM = lstTankChart[i].VolumeUOM;
                        tankChart.LinearUOM = lstTankChart[i].LinearUOM;
                        tankChart.Denominator = lstTankChart[i].Denominator;
                        tankChart.LastModifiedDtTm = lstTankChart[i].LastModifiedDtTm;
                        tankChart.ClientID = lstTankChart[i].ClientID;

                        TankChartDetail.TankChartList.Add(tankChart);
                    }
                    JsonParamValue.TankChart = TankChartDetail;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                    ParamList paramList = new ParamList();

                    parameter paramVal = new parameter();
                    paramVal.name = "JsonValue";
                    //paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");

                    paramList.Params.Add(paramVal);

                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");
                    // string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateTankChartURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {

                                    //for (var i = 0; i < lstTankChart.Count; i++)
                                    //{
                                    //    string TankChartNeedUpdateMarineURL = ServiceURL.UpdateSyncFlagTankChart + "(" + lstTankChart[i].TankChartID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                    //    string TankChartSyncUpdateResult = new WebClient().DownloadString(TankChartNeedUpdateMarineURL);
                                    //}

                                    MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                    JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                    marineSyncFlagUpdate.marineSyncFlagUpdate = (from i in lstTankChart
                                                                                 select new MarineSyncFlag { ID = i.TankChartID }).ToList<MarineSyncFlag>();

                                    jsonMarineSyncFlagUpdate.marineSyncFlag = marineSyncFlagUpdate;
                                    Results results = UpdateSyncFlag(jsonMarineSyncFlagUpdate, ServiceURL.UpdateSyncFlagTankChart + "&");

                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateSyncFlagTankChart - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }

                                }
                                else
                                {
                                    Logging.WriteLog("Error in UpdateSyncFlagTankChart - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateTankChart - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        ///// <summary>
        ///// UpdateTankChartDetail
        ///// Function to Update TankChartDetail
        ///// </summary>
        public static void UpdateTankChartDetail()
        {
            try
            {
                string GetTankChartDetail = new WebClient().DownloadString(ServiceURL.GetTankChartDetailURL);
                List<TankChartDetail> lstTankChartDetail = JsonConvert.DeserializeObject<List<TankChartDetail>>(GetTankChartDetail);
                Logging.WriteLog("Function Called UpdateTankChartDetail - Count " + lstTankChartDetail.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstTankChartDetail.Count > 0)
                {
                    for (var i = 0; i < lstTankChartDetail.Count; i++)
                    {
                        TankChartDetailsJSONParam JsonParamValue = new TankChartDetailsJSONParam();
                        TankChartDetailDetails TankChartDetailDetail = new TankChartDetailDetails();

                        TankChartDetail tankChartDetail = new TankChartDetail();
                        tankChartDetail.TankChartID = lstTankChartDetail[i].TankChartID;
                        tankChartDetail.Depth = lstTankChartDetail[i].Depth;
                        tankChartDetail.DepthFraction = lstTankChartDetail[i].DepthFraction;
                        tankChartDetail.DepthExtFraction = lstTankChartDetail[i].DepthExtFraction;
                        tankChartDetail.Volume = lstTankChartDetail[i].Volume;
                        tankChartDetail.ClientID = lstTankChartDetail[i].ClientID;
                        tankChartDetail.DepthFeet = lstTankChartDetail[i].DepthFeet;
                        TankChartDetailDetail.TankChartDetailList.Add(tankChartDetail);

                        JsonParamValue.TankChartDetail = TankChartDetailDetail;
                        //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                        string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                        });
                        ParamList paramList = new ParamList();
                        parameter paramVal = new parameter();

                        paramVal.name = "JsonValue";
                        // paramVal.param_type = "IN";
                        paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");
                        paramList.Params.Add(paramVal);
                        var jsonVal = jsonSerialiser.Serialize(paramList);
                        jsonVal = jsonVal.Replace("Params", "params");
                        // string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                        string url = ServiceURL.UpdateTankChartDetailURL + "&";
                        var request = (HttpWebRequest)HttpWebRequest.Create(url);
                        request.ContentType = "application/json; charset=utf-8";
                        request.Method = "POST";
                        request.Accept = "application/json; charset=utf-8";

                        using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                        {
                            streamWriter.Write(jsonVal);
                            //streamWriter.Close();
                        }
                        var httpResponse = (HttpWebResponse)request.GetResponse();
                        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                        {
                            var result = streamReader.ReadToEnd();
                            List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                            if (lsResult != null)
                            {
                                if (lsResult.Count > 0)
                                {
                                    if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                    {
                                        string TankChartDetailNeedUpdateMarineURL = ServiceURL.UpdateSyncFlagTankChartDetail + "(" + lstTankChartDetail[i].TankChartID + "," + lstTankChartDetail[i].Depth + "," + +lstTankChartDetail[i].DepthFraction + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                        string TankChartDetailSyncUpdateResult = new WebClient().DownloadString(TankChartDetailNeedUpdateMarineURL);
                                    }
                                    else
                                    {
                                        Logging.WriteLog("Error in UpdateSyncFlagTankChartDetail - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                    }
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateTankChartDetail - " + ex.Message.ToString(), EventLogEntryType.Error);
            }
        }

        ///// <summary>
        ///// UpdateTankChartKeel
        ///// Function to Update TankChartKeel
        ///// </summary>
        public static void UpdateTankChartKeel()
        {
            try
            {
                string GetTankChartKeel = new WebClient().DownloadString(ServiceURL.GetTankChartKeelURL);
                List<TankChartKeel> lstTankChartKeel = JsonConvert.DeserializeObject<List<TankChartKeel>>(GetTankChartKeel);
                Logging.WriteLog("Function Called UpdateTankChartKeel - Count " + lstTankChartKeel.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstTankChartKeel.Count > 0)
                {
                    TankChartKeelJSONParam JsonParamValue = new TankChartKeelJSONParam();
                    TankChartKeelDetails TankChartKeelDetail = new TankChartKeelDetails();
                    for (var i = 0; i < lstTankChartKeel.Count; i++)
                    {
                        TankChartKeel tankChartKeel = new TankChartKeel();
                        tankChartKeel.TankChartKeelID = lstTankChartKeel[i].TankChartKeelID;
                        tankChartKeel.TankChartID = lstTankChartKeel[i].TankChartID;
                        tankChartKeel.KeelTo = lstTankChartKeel[i].KeelTo;
                        tankChartKeel.KeelDegree = lstTankChartKeel[i].KeelDegree;
                        tankChartKeel.ClientID = lstTankChartKeel[i].ClientID;

                        TankChartKeelDetail.TankChartKeelList.Add(tankChartKeel);
                    }
                    JsonParamValue.TankChartKeel = TankChartKeelDetail;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                    param paramVal = new param();
                    paramVal.name = "JsonValue";
                    paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");


                    var jsonVal = jsonSerialiser.Serialize(paramVal);

                    string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateTankChartKeelURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(JsonStr);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {

                                    //for (var i = 0; i < lstTankChartKeel.Count; i++)
                                    //{
                                    //    string TankChartKeelNeedUpdateMarineURL = ServiceURL.UpdateSyncFlagTankChartKeel + "(" + lstTankChartKeel[i].TankChartKeelID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                    //    string TankChartKeelSyncUpdateResult = new WebClient().DownloadString(TankChartKeelNeedUpdateMarineURL);
                                    //}

                                    MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                    JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                    marineSyncFlagUpdate.marineSyncFlagUpdate = (from i in lstTankChartKeel
                                                                                 select new MarineSyncFlag { ID = i.TankChartKeelID }).ToList<MarineSyncFlag>();

                                    jsonMarineSyncFlagUpdate.marineSyncFlag = marineSyncFlagUpdate;
                                    Results results = UpdateSyncFlag(jsonMarineSyncFlagUpdate, ServiceURL.UpdateSyncFlagTankChartKeel + "&");

                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateSyncFlagTankChartKeel - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }

                                }
                                else
                                {
                                    Logging.WriteLog("Error in UpdateSyncFlagTankChartKeel - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateTankChartDetail - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        ///// <summary>
        ///// UpdateTankChartTrim
        ///// Function to Update TankChartTrim
        ///// </summary>
        public static void UpdateTankChartTrim()
        {
            try
            {
                string GetTankChartTrim = new WebClient().DownloadString(ServiceURL.GetTankChartTrimURL);
                List<TankChartTrim> lstTankChartTrim = JsonConvert.DeserializeObject<List<TankChartTrim>>(GetTankChartTrim);
                Logging.WriteLog("Function Called UpdateTankChartTrim - Count " + lstTankChartTrim.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstTankChartTrim.Count > 0)
                {
                    TankChartTrimJSONParam JsonParamValue = new TankChartTrimJSONParam();
                    TankChartTrimDetails TankChartTrimDetail = new TankChartTrimDetails();
                    for (var i = 0; i < lstTankChartTrim.Count; i++)
                    {
                        TankChartTrim tankChartTrim = new TankChartTrim();
                        tankChartTrim.TankChartTrimID = lstTankChartTrim[i].TankChartTrimID;
                        tankChartTrim.TankChartKeelID = lstTankChartTrim[i].TankChartKeelID;
                        tankChartTrim.TankChartID = lstTankChartTrim[i].TankChartID;
                        tankChartTrim.TrimInch = lstTankChartTrim[i].TrimInch;
                        tankChartTrim.CorrInch = lstTankChartTrim[i].CorrInch;
                        tankChartTrim.CorrFraction = lstTankChartTrim[i].CorrFraction;
                        tankChartTrim.CorrExtFraction = lstTankChartTrim[i].CorrExtFraction;
                        tankChartTrim.DivisionTemp = lstTankChartTrim[i].DivisionTemp;
                        tankChartTrim.DenominatorTemp = lstTankChartTrim[i].DenominatorTemp;
                        tankChartTrim.ClientID = lstTankChartTrim[i].ClientID;
                        tankChartTrim.TrimFeet = lstTankChartTrim[i].TrimFeet;
                        tankChartTrim.CorrFeet = lstTankChartTrim[i].CorrFeet;
                        tankChartTrim.TrimExtFraction = lstTankChartTrim[i].TrimExtFraction;

                        TankChartTrimDetail.TankChartTrimList.Add(tankChartTrim);
                    }
                    JsonParamValue.TankChartTrim = TankChartTrimDetail;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                    param paramVal = new param();
                    paramVal.name = "JsonValue";
                    paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");


                    var jsonVal = jsonSerialiser.Serialize(paramVal);

                    string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateTankChartTrimURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(JsonStr);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {

                                    //for (var i = 0; i < lstTankChartTrim.Count; i++)
                                    //{
                                    //    string TankChartTrimNeedUpdateMarineURL = ServiceURL.UpdateSyncFlagTankChartTrim + "(" + lstTankChartTrim[i].TankChartTrimID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                    //    string TankChartTrimSyncUpdateResult = new WebClient().DownloadString(TankChartTrimNeedUpdateMarineURL);
                                    //}

                                    MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                    JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                    marineSyncFlagUpdate.marineSyncFlagUpdate = (from i in lstTankChartTrim
                                                                                 select new MarineSyncFlag { ID = i.TankChartTrimID }).ToList<MarineSyncFlag>();

                                    jsonMarineSyncFlagUpdate.marineSyncFlag = marineSyncFlagUpdate;
                                    Results results = UpdateSyncFlag(jsonMarineSyncFlagUpdate, ServiceURL.UpdateSyncFlagTankChartTrim + "&");

                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateSyncFlagTankChartTrim - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }

                                }
                                else
                                {
                                    Logging.WriteLog("Error in UpdateSyncFlagTankChartTrim - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateTankChartTrim - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        ///// <summary>
        ///// UpdateVessel
        ///// Function to Update Vessel
        ///// </summary>
        public static void UpdateVessel()
        {
            try
            {
                string GetVessel = new WebClient().DownloadString(ServiceURL.GetShipToVesselURL);
                List<Vessel> lstVessel = JsonConvert.DeserializeObject<List<Vessel>>(GetVessel);
                Logging.WriteLog("Function Called UpdateVessel - Count " + lstVessel.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstVessel.Count > 0)
                {
                    VesselJSONParam JsonParamValue = new VesselJSONParam();
                    VesselDetails VesselDetail = new VesselDetails();
                    for (var i = 0; i < lstVessel.Count; i++)
                    {

                        Vessel Vessel = new Vessel();
                        Vessel.ShipToVesselID = lstVessel[i].ShipToVesselID;
                        Vessel.VesselCode = lstVessel[i].VesselCode.EncodeString();
                        Vessel.VesselDescr = lstVessel[i].VesselDescr.EncodeString();
                        Vessel.VesselTypeID = lstVessel[i].VesselTypeID;
                        Vessel.OwnershipStdAcctID = lstVessel[i].OwnershipStdAcctID;
                        Vessel.GrossTonnage = lstVessel[i].GrossTonnage;
                        Vessel.ActualCapacity = lstVessel[i].ActualCapacity;
                        Vessel.UOMID = lstVessel[i].UOMID;
                        Vessel.CompanyID = lstVessel[i].CompanyID;
                        Vessel.ClientID = lstVessel[i].ClientID;
                        Vessel.IMONo = lstVessel[i].IMONo;

                        VesselDetail.VesselList.Add(Vessel);
                    }

                    JsonParamValue.Vessel = VesselDetail;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                    ParamList paramList = new ParamList();
                    parameter paramVal = new parameter();

                    paramVal.name = "JsonValue";
                    // paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");
                    paramList.Params.Add(paramVal);


                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");


                    // string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateVesselURL + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {
                                    //string ShipToVesselNeedUpdateMarineURL = ServiceURL.UpdateSyncFlagShipToVessel + "(" + lstVessel[i].ShipToVesselID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                    //string ShipToVesselSyncUpdateResult = new WebClient().DownloadString(ShipToVesselNeedUpdateMarineURL);

                                    MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                    JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                    marineSyncFlagUpdate.marineSyncFlagUpdate = (from i in lstVessel
                                                                                 select new MarineSyncFlag { ID = i.ShipToVesselID }).ToList<MarineSyncFlag>();

                                    jsonMarineSyncFlagUpdate.marineSyncFlag = marineSyncFlagUpdate;
                                    Results results = UpdateSyncFlag(jsonMarineSyncFlagUpdate, string.Format("{0}?{1}&", ServiceURL.UpdateSyncFlagShipToVessel, ConfigurationManager.AppSettings["ClientAPIKEY"].ToString()));

                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateSyncFlagShipToVessel - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }
                                }
                                else
                                {
                                    Logging.WriteLog("Error in UpdateSyncFlagShipToVessel - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateVessel - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        ///// <summary>
        ///// UpdateAdHocVessel
        ///// Function to Update AdHocVessel
        ///// </summary>
        public static void UpdateAdHocVessel()
        {
            try
            {
                string GetVessel = new WebClient().DownloadString(ServiceURL.GetAdHocVessel);
                List<Vessel> lstVessel = JsonConvert.DeserializeObject<List<Vessel>>(GetVessel);
                Logging.WriteLog("Function Called UpdateAdHocVessel - Count " + lstVessel.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstVessel.Count > 0)
                {
                    VesselJSONParam JsonParamValue = new VesselJSONParam();
                    VesselDetails VesselDetail = new VesselDetails();
                    for (var i = 0; i < lstVessel.Count; i++)
                    {

                        Vessel Vessel = new Vessel();
                        Vessel.ShipToVesselID = lstVessel[i].ShipToVesselID;
                        Vessel.VesselCode = lstVessel[i].VesselCode.EncodeString();
                        Vessel.VesselDescr = Vessel.VesselCode;
                        Vessel.GrossTonnage = lstVessel[i].GrossTonnage != 0 ? lstVessel[i].GrossTonnage : 0;
                        Vessel.ActualCapacity = lstVessel[i].ActualCapacity != 0 ? lstVessel[i].ActualCapacity : 0;
                        Vessel.ClientID = lstVessel[i].ClientID;
                        Vessel.IMONo = lstVessel[i].IMONo;
                        Vessel.Instruction = lstVessel[i].Instruction;

                        VesselDetail.VesselList.Add(Vessel);
                    }

                    JsonParamValue.Vessel = VesselDetail;
                    //var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                    ParamList paramList = new ParamList();
                    parameter paramVal = new parameter();

                    paramVal.name = "JsonValue";
                    //  paramVal.param_type = "IN";
                    paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");
                    paramList.Params.Add(paramVal);


                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");


                    // string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                    string url = ServiceURL.UpdateAdHocVessel + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {
                                    //string UpdateSyncVesselMarineURL = ServiceURL.UpdateSyncVesselFlag + "(" + lstVessel[i].ShipToVesselID + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                                    //string UpdateSyncVesselResult = new WebClient().DownloadString(UpdateSyncVesselMarineURL);
                                    MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                    JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                    marineSyncFlagUpdate.marineSyncFlagUpdate = (from i in lstVessel
                                                                                 select new MarineSyncFlag { ID = i.ShipToVesselID }).ToList<MarineSyncFlag>();

                                    jsonMarineSyncFlagUpdate.marineSyncFlag = marineSyncFlagUpdate;
                                    Results results = UpdateSyncFlag(jsonMarineSyncFlagUpdate, string.Format("{0}?{1}&", ServiceURL.UpdateSyncVesselFlag, ConfigurationManager.AppSettings["CloudAPIKEY"].ToString()));

                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateSyncFlagShipToAdHocVessel - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }
                                }
                                else
                                {
                                    Logging.WriteLog("Error in UpdateSyncFlagShipToAdHocVessel - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateAdHocVessel - " + ex.Message.ToString(), EventLogEntryType.Error);
            }
        }


        /// <summary>
        /// UpdateOrders
        /// Function to update Orders
        /// </summary>
        public static void UpdateOrders()
        {
            try
            {
                /* Get OrderHdr to update in ascend */
                string GetOrderHdr = new WebClient().DownloadString(string.Format("{0}({1})?{2}", ServiceURL.GetOrderHdrURL, Convert.ToInt32(ConfigurationManager.AppSettings["RetryCount"]), ConfigurationManager.AppSettings["CloudAPIKEY"]));
                // string GetOrderHdr = new WebClient().DownloadString(ServiceURL.GetOrderHdrURL);
                List<OrderHdr> lstOrderHdr = JsonConvert.DeserializeObject<List<OrderHdr>>(GetOrderHdr);

                //  lstOrderHdr = lstOrderHdr.Where(item => item.OrderNo == "X8095-5").ToList();

                /* Get OrderItems to update in ascend */
                // string GetOrderItems = new WebClient().DownloadString(ServiceURL.GetOrderItemURL);
                string GetOrderItems = new WebClient().DownloadString(string.Format("{0}({1})?{2}", ServiceURL.GetOrderItemURL, Convert.ToInt32(ConfigurationManager.AppSettings["RetryCount"]), ConfigurationManager.AppSettings["CloudAPIKEY"]));
                List<OrderItem> lstOrderItems = JsonConvert.DeserializeObject<List<OrderItem>>(GetOrderItems);

                /* Get OrderItemComponent to update in ascend */
                //  string GetOrderItemComp = new WebClient().DownloadString(ServiceURL.GetOrderItemComponentURL);
                string GetOrderItemComp = new WebClient().DownloadString(string.Format("{0}({1})?{2}", ServiceURL.GetOrderItemComponentURL, Convert.ToInt32(ConfigurationManager.AppSettings["RetryCount"]), ConfigurationManager.AppSettings["CloudAPIKEY"]));
                List<OrderItemComponent> lstOrderItemComp = JsonConvert.DeserializeObject<List<OrderItemComponent>>(GetOrderItemComp);

                // string GetOrderNotes = new WebClient().DownloadString(ServiceURL.GetOrderNotesURL);
                string GetOrderNotes = new WebClient().DownloadString(string.Format("{0}({1})?{2}", ServiceURL.GetOrderNotesURL, Convert.ToInt32(ConfigurationManager.AppSettings["RetryCount"]), ConfigurationManager.AppSettings["CloudAPIKEY"]));
                List<OrderNote> lstOrderNotes = JsonConvert.DeserializeObject<List<OrderNote>>(GetOrderNotes);

                Logging.WriteLog("Function Called UpdateOrders - Count " + lstOrderHdr.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };

                if (lstOrderHdr.Count > 0)
                {
                    for (var i = 0; i < lstOrderHdr.Count; i++)
                    {

                        try
                        {
                            OrderJSONParam JsonParamValue = new OrderJSONParam();

                            OrderHdr OrdHdr = new OrderHdr();
                            OrdHdr.SysTrxNo = lstOrderHdr[i].SysTrxNo;
                            OrdHdr.CompanyID = lstOrderHdr[i].CompanyID;
                            OrdHdr.OrderNo = lstOrderHdr[i].OrderNo;
                            OrdHdr.PONo = !string.IsNullOrEmpty(lstOrderHdr[i].PONo) ? lstOrderHdr[i].PONo.EncodeString() : null;
                            //OrdHdr.DefCarrierID = lstOrderHdr[i].DefCarrierID == null ? 0 : lstOrderHdr[i].DefCarrierID;
                            OrdHdr.DefCarrierID = lstOrderHdr[i].DefCarrierID;
                            OrdHdr.OrderDtTm = lstOrderHdr[i].OrderDtTm;
                            //OrdHdr.OrderDtTm = null;
                            OrdHdr.DtTm = lstOrderHdr[i].DtTm;
                            //OrdHdr.DtTm = null;

                            OrdHdr.UserID = lstOrderHdr[i].UserID;
                            OrdHdr.Status = lstOrderHdr[i].Status;
                            OrdHdr.ToSiteID = lstOrderHdr[i].ToSiteID;
                            OrdHdr.OrderType = lstOrderHdr[i].OrderType;
                            OrdHdr.LoadNo = lstOrderHdr[i].LoadNo;
                            OrdHdr.LastStatusDate = lstOrderHdr[i].LastStatusDate;
                            //OrdHdr.LastStatusDate = null;
                            OrdHdr.InternalTransferOrder = lstOrderHdr[i].InternalTransferOrder;
                            OrdHdr.CustomerID = lstOrderHdr[i].CustomerID;
                            OrdHdr.ShipToVesselID = lstOrderHdr[i].ShipToVesselID == null ? 0 : lstOrderHdr[i].ShipToVesselID;
                            OrdHdr.AuxiliaryVesselID = lstOrderHdr[i].AuxiliaryVesselID == null ? 0 : lstOrderHdr[i].AuxiliaryVesselID;
                            OrdHdr.AuxiliaryVesselCount = lstOrderHdr[i].AuxiliaryVesselCount == null ? 0 : lstOrderHdr[i].AuxiliaryVesselCount;
                            OrdHdr.MarineLocID = lstOrderHdr[i].MarineLocID == null ? 0 : lstOrderHdr[i].MarineLocID;
                            OrdHdr.MarineLocDescr = lstOrderHdr[i].MarineLocDescr == null ? "" : lstOrderHdr[i].MarineLocDescr.EncodeString();
                            OrdHdr.FreightIN = lstOrderHdr[i].FreightIN;
                            OrdHdr.FreightOUT = lstOrderHdr[i].FreightOUT;
                            OrdHdr.MarineSessionID = lstOrderHdr[i].MarineSessionID == null ? 0 : lstOrderHdr[i].MarineSessionID;
                            //OrdHdr.DefDriverID = lstOrderHdr[i].DefDriverID == null ? 0 : lstOrderHdr[i].DefDriverID;
                            OrdHdr.DefVehicleID = lstOrderHdr[i].DefVehicleID == null ? 0 : lstOrderHdr[i].DefVehicleID;
                            OrdHdr.ReceivingContactID = lstOrderHdr[i].ReceivingContactID;
                            OrdHdr.LastModifiedUser = lstOrderHdr[i].LastModifiedUser == null ? "" : lstOrderHdr[i].LastModifiedUser;

                            JsonParamValue.OrderHdrList.Add(OrdHdr);

                            var lstOrderItemsFiltered = lstOrderItems.Where(item => item.SysTrxNo.Equals(lstOrderHdr[i].SysTrxNo));
                            List<OrderItem> lstOrderItemsNew = new List<OrderItem>();

                            lstOrderItemsNew = lstOrderItemsFiltered.ToList();

                            if (lstOrderItemsFiltered.Count() > 0)
                            {
                                for (var j = 0; j < lstOrderItemsFiltered.Count(); j++)
                                {
                                    OrderItem OrdItem = new OrderItem();
                                    OrdItem.SysTrxNo = lstOrderItemsNew[j].SysTrxNo;
                                    OrdItem.SysTrxLine = lstOrderItemsNew[j].SysTrxLine;
                                    OrdItem.MasterProdID = lstOrderItemsNew[j].MasterProdID;
                                    OrdItem.MasterSiteID = lstOrderItemsNew[j].MasterSiteID;
                                    OrdItem.Qty = lstOrderItemsNew[j].Qty;
                                    OrdItem.Priority = lstOrderItemsNew[j].Priority;
                                    OrdItem.Status = lstOrderItemsNew[j].Status;
                                    OrdItem.DtTm = lstOrderItemsNew[j].DtTm;
                                    //OrdItem.DtTm = null;
                                    OrdItem.UnitPrice = lstOrderItemsNew[j].UnitPrice == null ? 0 : lstOrderItemsNew[j].UnitPrice;
                                    OrdItem.UnitPriceKeyed = lstOrderItemsNew[j].UnitPriceKeyed == null ? 0 : lstOrderItemsNew[j].UnitPriceKeyed;
                                    OrdItem.RequestedDtTm = lstOrderItemsNew[j].RequestedDtTm;
                                    //OrdItem.RequestedDtTm = null;
                                    OrdItem.PromisedDtTm = lstOrderItemsNew[j].PromisedDtTm;
                                    //OrdItem.PromisedDtTm = null;
                                    OrdItem.Notes = !lstOrderItemsNew[j].Notes.IsStringEmpty() ? lstOrderItemsNew[j].Notes.EncodeString() : string.Empty;
                                    OrdItem.CustomerID = lstOrderItemsNew[j].CustomerID;
                                    OrdItem.ShipToTankID = lstOrderItemsNew[j].ShipToTankID == null ? 0 : lstOrderItemsNew[j].ShipToTankID;
                                    OrdItem.AdditionalCost = lstOrderItemsNew[j].AdditionalCost == null ? 0 : lstOrderItemsNew[j].AdditionalCost;
                                    OrdItem.RackPriceKeyed = lstOrderItemsNew[j].RackPriceKeyed == null ? 0 : lstOrderItemsNew[j].RackPriceKeyed;
                                    OrdItem.ARShipToTankID = lstOrderItemsNew[j].ARShipToTankID == null ? 0 : lstOrderItemsNew[j].ARShipToTankID;
                                    OrdItem.PONo = lstOrderItemsNew[j].PONo.EncodeString();
                                    JsonParamValue.OrderItemList.Add(OrdItem);
                                }
                            }

                            var lstOrderItemCompFiltered = lstOrderItemComp.Where(item => item.SysTrxNo.Equals(lstOrderHdr[i].SysTrxNo));
                            List<OrderItemComponent> lstOrderItemCompNew = new List<OrderItemComponent>();

                            lstOrderItemCompNew = lstOrderItemCompFiltered.ToList();

                            if (lstOrderItemCompFiltered.Count() > 0)
                            {
                                for (var k = 0; k < lstOrderItemCompFiltered.Count(); k++)
                                {
                                    OrderItemComponent OrdItemComp = new OrderItemComponent();
                                    OrdItemComp.SysTrxNo = lstOrderItemCompNew[k].SysTrxNo;
                                    OrdItemComp.SysTrxLine = lstOrderItemCompNew[k].SysTrxLine;
                                    OrdItemComp.ComponentNo = lstOrderItemCompNew[k].ComponentNo;
                                    OrdItemComp.MasterProdID = lstOrderItemCompNew[k].MasterProdID;
                                    OrdItemComp.MasterSiteID = lstOrderItemCompNew[k].MasterSiteID;
                                    OrdItemComp.Qty = lstOrderItemCompNew[k].Qty;
                                    OrdItemComp.UnitCost = lstOrderItemCompNew[k].UnitCost == null ? 0 : lstOrderItemComp[k].UnitCost;
                                    OrdItemComp.CustomerID = lstOrderItemCompNew[k].CustomerID;
                                    OrdItemComp.RackPrice = lstOrderItemCompNew[k].RackPrice == null ? 0 : lstOrderItemComp[k].RackPrice;
                                    OrdItemComp.RackPriceKeyed = lstOrderItemCompNew[k].RackPriceKeyed == null ? 0 : lstOrderItemComp[k].RackPriceKeyed;
                                    OrdItemComp.FromCsTankFuelHistoryID = lstOrderItemCompNew[k].FromCsTankFuelHistoryID;
                                    OrdItemComp.ToCsTankFuelHistoryID = lstOrderItemCompNew[k].ToCsTankFuelHistoryID;

                                    JsonParamValue.OrderItemComponentList.Add(OrdItemComp);
                                }
                            }

                            var lstOrderNoteFiltered = lstOrderNotes.Where(item => item.SysTrxNo.Equals(lstOrderHdr[i].SysTrxNo));
                            List<OrderNote> lstOrderNotesNew = new List<OrderNote>();

                            lstOrderNotesNew = lstOrderNoteFiltered.ToList();

                            if (lstOrderNoteFiltered.Count() > 0)
                            {
                                for (var j = 0; j < lstOrderNoteFiltered.Count(); j++)
                                {
                                    OrderNote OrdNote = new OrderNote();
                                    OrdNote.SysTrxNo = lstOrderNotesNew[j].SysTrxNo;
                                    OrdNote.NoteNo = lstOrderNotesNew[j].NoteNo;
                                    OrdNote.NoteTypeID = lstOrderNotesNew[j].NoteTypeID;
                                    OrdNote.Note = lstOrderNotesNew[j].Note.EncodeString();
                                    OrdNote.PrintOn = lstOrderNotesNew[j].PrintOn;
                                    OrdNote.ClientID = lstOrderNotesNew[j].ClientID;

                                    JsonParamValue.OrderNoteList.Add(OrdNote);
                                }
                            }

                            Orders OrderList = new Orders();
                            OrderList.OrderList = JsonParamValue;

                            //var jsonperVal = jsonSerialiser.Serialize(OrderList);

                            string jsonIgnoreNullValues = JsonConvert.SerializeObject(OrderList, Formatting.None, new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });

                            // ParamList paramList = new ParamList();
                            // parameter paramVal = new parameter();
                            // paramVal.name = "JsonValue";
                            //// paramVal.param_type = "IN";
                            // paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");

                            // paramList.Params.Add(paramVal);

                            parameterList paramList = new parameterList();
                            paramList.Params.Add(jsonIgnoreNullValues);

                            var jsonVal = jsonSerialiser.Serialize(paramList);
                            jsonVal = jsonVal.Replace("Params", "params");


                            //string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                            string url = ServiceURL.UpdateOrderDetailsURL + "&";
                            var request = (HttpWebRequest)HttpWebRequest.Create(url);
                            request.ContentType = "application/json; charset=utf-8";
                            request.Method = "POST";
                            request.Accept = "application/json; charset=utf-8";

                            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                            {
                                streamWriter.Write(jsonVal);
                                //streamWriter.Close();
                            }

                            //if (lstOrderItemsFiltered.Count() > 0)
                            //{
                            //    string OrderItemDeleteURL = ServiceURL.UpdateOrderItemDelete + "(" + lstOrderHdr[i].SysTrxNo + ")?" + ConfigurationManager.AppSettings["ClientAPIKey"].ToString();
                            //    string OrderItemDeleteResult = new WebClient().DownloadString(OrderItemDeleteURL);
                            //}

                            var httpResponse = (HttpWebResponse)request.GetResponse();
                            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                            {
                                var result = streamReader.ReadToEnd();
                                List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                                if (lsResult != null)
                                {
                                    if (lsResult.Count > 0)
                                    {
                                        if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                        {
                                            //for (var l = 0; l < lstOrderHdr.Count; i++)
                                            //{
                                            string OrderNeedUpdateURL = ServiceURL.UpdateOrderDetailsNeedUpdateFlagURL + "(" + lstOrderHdr[i].SysTrxNo + "," + lstOrderHdr[i].OrderNo + "," + lstOrderHdr[i].CompanyID + "," + lstOrderHdr[i].CustomerID + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                                            string OrderNeedUpdateResult = new WebClient().DownloadString(OrderNeedUpdateURL);

                                            //string LoadStatusUpdateURL = ServiceURL.UpdateLoadStatusURL + "(" + lstOrderHdr[i].LoadNo + ",O)?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                            //string LoadStatusUpdateResult = new WebClient().DownloadString(LoadStatusUpdateURL);
                                            //}
                                        }
                                        else
                                        {
                                            Logging.WriteLog("Error in UpdateOrders - OrderNo - " + lstOrderHdr[i].OrderNo + ", Reason - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                            string UpdateOrderRetryCountURL = ServiceURL.UpdateOrderRetryCount + "(" + lstOrderHdr[i].SysTrxNo + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                                            string UpdateOrderRetryCountURLResult = new WebClient().DownloadString(UpdateOrderRetryCountURL);
                                        }
                                    }
                                }
                            }
                        }
                        catch (System.Data.SqlClient.SqlException sqlEx)
                        {
                            Logging.WriteLog(string.Format("Error in UpdateOrders -OrderNO - {0} , ErrorMessage - {1} ", lstOrderHdr[i].OrderNo, sqlEx.Message.ToString()), EventLogEntryType.Error);
                            string UpdateOrderRetryCountURL = ServiceURL.UpdateOrderRetryCount + "(" + lstOrderHdr[i].SysTrxNo + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                            string UpdateOrderRetryCountURLResult = new WebClient().DownloadString(UpdateOrderRetryCountURL);
                        }
                        catch (Exception ex)
                        {
                            Logging.WriteLog("Error in UpdateOrders - " + ex.Message.ToString(), EventLogEntryType.Error);
                            string UpdateOrderRetryCountURL = ServiceURL.UpdateOrderRetryCount + "(" + lstOrderHdr[i].SysTrxNo + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                            string UpdateOrderRetryCountURLResult = new WebClient().DownloadString(UpdateOrderRetryCountURL);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateOrders - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        /// <summary>
        /// UpdateShipments
        /// Function to update Shipment details
        /// </summary>
        public static void UpdateShipments()
        {

            UpdateOrders();
            UpdateOrderStatus('L');

            /* Get ShipDoc to update in ascend */
            string GetShipDoc = new WebClient().DownloadString(string.Format("{0}({1})?{2}", ServiceURL.GetShipDocURL, Convert.ToInt32(ConfigurationManager.AppSettings["RetryCount"]), ConfigurationManager.AppSettings["CloudAPIKEY"]));
            //  string GetShipDoc = new WebClient().DownloadString(ServiceURL.GetShipDocURL);
            List<ShipDoc> lstShipDocHdr = JsonConvert.DeserializeObject<List<ShipDoc>>(GetShipDoc);

            /* Get ShipDocItem to update in ascend */
            // string GetShipDocItem = new WebClient().DownloadString(ServiceURL.GetShipDocItemURL);
            string GetShipDocItem = new WebClient().DownloadString(string.Format("{0}({1})?{2}", ServiceURL.GetShipDocItemURL, Convert.ToInt32(ConfigurationManager.AppSettings["RetryCount"]), ConfigurationManager.AppSettings["CloudAPIKEY"]));
            List<ShipDocItem> lstShipDocItem = JsonConvert.DeserializeObject<List<ShipDocItem>>(GetShipDocItem);

            /* Get ShipDocItemComp to update in ascend */
            //  string GetShipDocItemComp = new WebClient().DownloadString(ServiceURL.GetShipDocItemCompURL);
            string GetShipDocItemComp = new WebClient().DownloadString(string.Format("{0}({1})?{2}", ServiceURL.GetShipDocItemCompURL, Convert.ToInt32(ConfigurationManager.AppSettings["RetryCount"]), ConfigurationManager.AppSettings["CloudAPIKEY"]));
            List<ShipDocItemComp> lstShipDocItemComp = JsonConvert.DeserializeObject<List<ShipDocItemComp>>(GetShipDocItemComp);

            /* Get ShipDocItemComp to update in ascend */
            string GetShipDocItemReading = new WebClient().DownloadString(ServiceURL.GetShipDocItemReadingURL);
            List<ShipDocItemReading> lstShipDocItemReading = JsonConvert.DeserializeObject<List<ShipDocItemReading>>(GetShipDocItemReading);

            /* Get ShipDocItemComp to update in ascend */
            string GetShipDocItemReadingDtl = new WebClient().DownloadString(ServiceURL.GetShipDocItemReadingDtlURL);
            List<ShipDocItemReadingDtl> lstShipDocItemReadingDtl = JsonConvert.DeserializeObject<List<ShipDocItemReadingDtl>>(GetShipDocItemReadingDtl);

            /* Get ShipmentLoad to update in ascend */
            string GetShipmentLoad = new WebClient().DownloadString(ServiceURL.GetShipmentDetails);
            List<MarineShipment> lstMarineShipment = JsonConvert.DeserializeObject<List<MarineShipment>>(GetShipmentLoad);

            /* Get ShipmentLoadDetail to update in ascend */
            string GetShipmentLoadDetails = new WebClient().DownloadString(ServiceURL.GetShipmentLoadDetails);
            List<MarineShipmentDetail> lstMarineShipmentDetails = JsonConvert.DeserializeObject<List<MarineShipmentDetail>>(GetShipmentLoadDetails);

            Logging.WriteLog("Function Called UpdateShipments - Count " + lstShipDocHdr.Count.ToString(), EventLogEntryType.Error);
            var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };


            if (lstShipDocHdr.Count > 0)
            {


                for (var i = 0; i < lstShipDocHdr.Count; i++)
                {
                    try
                    {
                        ShipmentJSONParam JsonParamValue = new ShipmentJSONParam();

                        ShipDoc ShipDocHdr = new ShipDoc();
                        ShipDocHdr.SysTrxNo = lstShipDocHdr[i].SysTrxNo;
                        ShipDocHdr.SO = lstShipDocHdr[i].SO;
                        ShipDocHdr.CompanyID = lstShipDocHdr[i].CompanyID;
                        ShipDocHdr.DtTm = lstShipDocHdr[i].DtTm == null ? "Jan  1 1900 12:00:00:000AM" : lstShipDocHdr[i].DtTm;
                        ShipDocHdr.PrintDtTm = lstShipDocHdr[i].PrintDtTm == null ? "Jan  1 1900 12:00:00:000AM" : lstShipDocHdr[i].PrintDtTm;
                        ShipDocHdr.ShipDtTm = lstShipDocHdr[i].ShipDtTm == null ? "Jan  1 1900 12:00:00:000AM" : lstShipDocHdr[i].ShipDtTm;
                        ShipDocHdr.DocType = lstShipDocHdr[i].DocType;
                        ShipDocHdr.DocNo = lstShipDocHdr[i].DocNo;
                        ShipDocHdr.UserID = lstShipDocHdr[i].UserID;
                        ShipDocHdr.CarrierID = lstShipDocHdr[i].CarrierID == null ? 0 : lstShipDocHdr[i].CarrierID;
                        ShipDocHdr.VehicleID = lstShipDocHdr[i].VehicleID;
                        //ShipDocHdr.DriverID = lstShipDocHdr[i].DriverID;
                        ShipDocHdr.BOLNo = lstShipDocHdr[i].BOLNo;
                        ShipDocHdr.Status = lstShipDocHdr[i].Status;
                        ShipDocHdr.FrtInID = lstShipDocHdr[i].FrtInID == null ? 0 : lstShipDocHdr[i].FrtInID;
                        ShipDocHdr.OrderStatusID = lstShipDocHdr[i].OrderStatusID == null ? 0 : lstShipDocHdr[i].OrderStatusID;
                        ShipDocHdr.SessionNo = lstShipDocHdr[i].SessionNo;
                        ShipDocHdr.ManualLinkCreate = lstShipDocHdr[i].ManualLinkCreate;
                        ShipDocHdr.DiversionState = lstShipDocHdr[i].DiversionState;
                        ShipDocHdr.DiversionShipToID = lstShipDocHdr[i].DiversionShipToID == null ? 0 : lstShipDocHdr[i].DiversionShipToID;
                        ShipDocHdr.CustomerID = lstShipDocHdr[i].CustomerID;
                        ShipDocHdr.SignatureImage = lstShipDocHdr[i].SignatureImage;
                        ShipDocHdr.SignatureDateTime = lstShipDocHdr[i].SignatureDateTime == null ? "Jan  1 1900 12:00:00:000AM" : lstShipDocHdr[i].SignatureDateTime;
                        ShipDocHdr.SignatureStatus = lstShipDocHdr[i].SignatureStatus == null ? 'O' : lstShipDocHdr[i].SignatureStatus;
                        ShipDocHdr.BOLImage = lstShipDocHdr[i].BOLImage;
                        ShipDocHdr.DeliveryImage = lstShipDocHdr[i].DeliveryImage;
                        ShipDocHdr.LoadNo = lstShipDocHdr[i].LoadNo;

                        JsonParamValue.ShipDocList.Add(ShipDocHdr);

                        int shipDocItemCount = lstShipDocItem.Where(item => item.SysTrxNo.Equals(lstShipDocHdr[i].SysTrxNo)).Count();
                        // string orderItemCount = new WebClient().DownloadString(ServiceURL.GetOrderItemCountURL);


                        string orderItemCount = new WebClient().DownloadString(string.Format("{0}({1})?{2}", ServiceURL.GetOrderItemCountURL, ShipDocHdr.SysTrxNo, ConfigurationManager.AppSettings["CloudAPIKEY"]));
                        string clientOrderItemCount = new WebClient().DownloadString(string.Format("{0}({1})?{2}", ServiceURL.GetClientOrderItemCountURL, ShipDocHdr.SysTrxNo, ConfigurationManager.AppSettings["ClientAPIKEY"]));

                        List<Counts> lstItemCount = JsonConvert.DeserializeObject<List<Counts>>(orderItemCount);
                        List<Counts> lstClientItemCount = JsonConvert.DeserializeObject<List<Counts>>(clientOrderItemCount);


                        if (shipDocItemCount == lstItemCount[0].Count && lstItemCount[0].Count == lstClientItemCount[0].Count)
                        {

                            // ShipmentLoad starts

                            var lstMarineShipmentFiltered = lstMarineShipment.Where(item => item.OrderSysTrxNo.Equals(lstShipDocHdr[i].SysTrxNo));
                            List<MarineShipment> lstMarineShipmentNew = new List<MarineShipment>();
                            lstMarineShipmentNew = lstMarineShipmentFiltered.ToList();
                            if (lstMarineShipmentNew.Count > 0)
                            {
                                for (var n = 0; n < lstMarineShipmentNew.Count; n++)
                                {
                                    MarineShipment MarineShipmentHdr = new MarineShipment();
                                    MarineShipmentHdr.SessionID = lstMarineShipmentNew[n].SessionID;
                                    MarineShipmentHdr.OrderSysTrxNo = lstMarineShipmentNew[n].OrderSysTrxNo == null ? 0 : lstMarineShipmentNew[n].OrderSysTrxNo;
                                    MarineShipmentHdr.LoadNo = lstMarineShipmentNew[n].LoadNo;
                                    MarineShipmentHdr.ShipDtTm = lstMarineShipmentNew[n].ShipDtTm == null ? "Jan  1 1900 12:00:00:000AM" : lstMarineShipmentNew[n].ShipDtTm;
                                    MarineShipmentHdr.MasterSiteID = lstMarineShipmentNew[n].MasterSiteID == null ? 0 : lstMarineShipmentNew[n].MasterSiteID;
                                    MarineShipmentHdr.CarrierID = lstMarineShipmentNew[n].CarrierID;
                                    MarineShipmentHdr.VehicleID = lstMarineShipmentNew[n].VehicleID;
                                    MarineShipmentHdr.DocumentNo = lstMarineShipmentNew[n].DocumentNo;
                                    MarineShipmentHdr.DocumentType = lstMarineShipmentNew[n].DocumentType;
                                    MarineShipmentHdr.CustomerID = lstMarineShipmentNew[n].CustomerID;
                                    JsonParamValue.MarineShipmentList.Add(MarineShipmentHdr);
                                }
                            }

                            var lstMarineShipmentDetailsFiltered = lstMarineShipmentDetails.Where(item => item.SysTrxNo.Equals(lstShipDocHdr[i].SysTrxNo));
                            List<MarineShipmentDetail> lstMarineShipmentDetailsNew = new List<MarineShipmentDetail>();
                            lstMarineShipmentDetailsNew = lstMarineShipmentDetailsFiltered.ToList();
                            if (lstMarineShipmentDetailsNew.Count > 0)
                            {
                                for (var p = 0; p < lstMarineShipmentDetailsNew.Count; p++)
                                {
                                    MarineShipmentDetail MarineShipmentDetailHdr = new MarineShipmentDetail();
                                    MarineShipmentDetailHdr.SessionID = lstMarineShipmentDetailsNew[p].SessionID;
                                    MarineShipmentDetailHdr.SysTrxLine = lstMarineShipmentDetailsNew[p].SysTrxLine;
                                    MarineShipmentDetailHdr.MasterProdID = lstMarineShipmentDetailsNew[p].MasterProdID;
                                    MarineShipmentDetailHdr.UOMID = lstMarineShipmentDetailsNew[p].UOMID;
                                    MarineShipmentDetailHdr.Temperature = lstMarineShipmentDetailsNew[p].Temperature == null ? 0 : lstMarineShipmentDetailsNew[p].Temperature;
                                    MarineShipmentDetailHdr.SpecificGravity = lstMarineShipmentDetailsNew[p].SpecificGravity == null ? 0 : lstMarineShipmentDetailsNew[p].SpecificGravity;
                                    MarineShipmentDetailHdr.GrossQty = lstMarineShipmentDetailsNew[p].GrossQty;
                                    MarineShipmentDetailHdr.NetQty = lstMarineShipmentDetailsNew[p].NetQty;
                                    MarineShipmentDetailHdr.Note = lstMarineShipmentDetailsNew[p].Note;
                                    MarineShipmentDetailHdr.OrderSysTrxLine = lstMarineShipmentDetailsNew[p].OrderSysTrxLine;
                                    MarineShipmentDetailHdr.Ship = lstMarineShipmentDetailsNew[p].Ship;
                                    MarineShipmentDetailHdr.UOMGrossQty = lstMarineShipmentDetailsNew[p].UOMGrossQty;
                                    MarineShipmentDetailHdr.UOMNetQty = lstMarineShipmentDetailsNew[p].UOMNetQty;
                                    MarineShipmentDetailHdr.InterUOMID = lstMarineShipmentDetailsNew[p].InterUOMID;
                                    MarineShipmentDetailHdr.ToUOMID = lstMarineShipmentDetailsNew[p].ToUOMID;
                                    MarineShipmentDetailHdr.KeyedGrossQty = lstMarineShipmentDetailsNew[p].KeyedGrossQty;
                                    MarineShipmentDetailHdr.KeyedNetQty = lstMarineShipmentDetailsNew[p].KeyedNetQty;
                                    MarineShipmentDetailHdr.ClientID = lstMarineShipmentDetailsNew[p].CustomerID == null ? 0 : Convert.ToInt32(lstMarineShipmentDetailsNew[p].CustomerID);
                                    JsonParamValue.MarineShipmentDetailList.Add(MarineShipmentDetailHdr);

                                }
                            }

                            // ShipmentLoad ends

                            var lstShipDocItemFiltered = lstShipDocItem.Where(item => item.SysTrxNo.Equals(lstShipDocHdr[i].SysTrxNo));

                            List<ShipDocItem> lstShipDocItemNew = new List<ShipDocItem>();

                            lstShipDocItemNew = lstShipDocItemFiltered.ToList();

                            if (lstShipDocItemFiltered.Count() > 0)
                            {
                                for (var j = 0; j < lstShipDocItemFiltered.Count(); j++)
                                {
                                    ShipDocItem ShipDocItemVal = new ShipDocItem();
                                    ShipDocItemVal.SysTrxNo = lstShipDocItemNew[j].SysTrxNo;
                                    ShipDocItemVal.SysTrxLine = lstShipDocItemNew[j].SysTrxLine;
                                    ShipDocItemVal.MasterProdID = lstShipDocItemNew[j].MasterProdID;
                                    ShipDocItemVal.MasterSiteID = lstShipDocItemNew[j].MasterSiteID;
                                    ShipDocItemVal.OrderSysTrxNo = lstShipDocItemNew[j].OrderSysTrxNo == null ? 0 : lstShipDocItemNew[j].OrderSysTrxNo;
                                    ShipDocItemVal.OrderSysTrxLine = lstShipDocItemNew[j].OrderSysTrxLine == null ? 0 : lstShipDocItemNew[j].OrderSysTrxLine;
                                    ShipDocItemVal.InvoiceSysTrxNo = lstShipDocItemNew[j].InvoiceSysTrxNo == null ? 0 : lstShipDocItemNew[j].InvoiceSysTrxNo;
                                    ShipDocItemVal.InvoiceSysTrxLine = lstShipDocItemNew[j].InvoiceSysTrxLine == null ? 0 : lstShipDocItemNew[j].InvoiceSysTrxLine;
                                    ShipDocItemVal.DtTm = lstShipDocItemNew[j].DtTm == null ? "Jan  1 1900 12:00:00:000AM" : lstShipDocItemNew[j].DtTm;
                                    ShipDocItemVal.UserID = lstShipDocItemNew[j].UserID;
                                    ShipDocItemVal.ShipQty = lstShipDocItemNew[j].ShipQty == null ? 0 : lstShipDocItemNew[j].ShipQty;
                                    ShipDocItemVal.DelivDtTm = lstShipDocItemNew[j].DelivDtTm == null ? "Jan  1 1900 12:00:00:000AM" : lstShipDocItemNew[j].DelivDtTm;
                                    ShipDocItemVal.DelivQty = lstShipDocItemNew[j].DelivQty == null ? 0 : lstShipDocItemNew[j].DelivQty;
                                    ShipDocItemVal.DiscDt = lstShipDocItemNew[j].DiscDt == null ? "Jan  1 1900 12:00:00:000AM" : lstShipDocItemNew[j].DiscDt;
                                    ShipDocItemVal.DueDt1 = lstShipDocItemNew[j].DueDt1 == null ? "Jan  1 1900 12:00:00:000AM" : lstShipDocItemNew[j].DueDt1;
                                    ShipDocItemVal.DueDt2 = lstShipDocItemNew[j].DueDt2 == null ? "Jan  1 1900 12:00:00:000AM" : lstShipDocItemNew[j].DueDt2;
                                    ShipDocItemVal.DueDt3 = lstShipDocItemNew[j].DueDt3 == null ? "Jan  1 1900 12:00:00:000AM" : lstShipDocItemNew[j].DueDt3;
                                    ShipDocItemVal.TermsID = lstShipDocItemNew[j].TermsID == null ? 0 : lstShipDocItemNew[j].TermsID;
                                    ShipDocItemVal.Invoice = lstShipDocItemNew[j].Invoice;
                                    ShipDocItemVal.Invoiced = lstShipDocItemNew[j].Invoiced;
                                    ShipDocItemVal.Status = lstShipDocItemNew[j].Status;
                                    ShipDocItemVal.ProdAggrGrpID = lstShipDocItemNew[j].ProdAggrGrpID == null ? 0 : lstShipDocItemNew[j].ProdAggrGrpID;
                                    ShipDocItemVal.OrderQty = lstShipDocItemNew[j].OrderQty == null ? 0 : lstShipDocItemNew[j].OrderQty;
                                    ShipDocItemVal.SellAt = lstShipDocItemNew[j].SellAt;
                                    ShipDocItemVal.ShipNetQty = lstShipDocItemNew[j].ShipNetQty == null ? 0 : lstShipDocItemNew[j].ShipNetQty;
                                    ShipDocItemVal.CustomerID = lstShipDocItemNew[j].CustomerID;
                                    ShipDocItemVal.BOLQtyVarianceReason = lstShipDocItemNew[j].BOLQtyVarianceReason;
                                    ShipDocItemVal.DeliveryQtyVarianceReason = lstShipDocItemNew[j].DeliveryQtyVarianceReason;
                                    ShipDocItemVal.IsNotShipped = lstShipDocItemNew[j].IsNotShipped;
                                    ShipDocItemVal.IsNotShippedReason = lstShipDocItemNew[j].IsNotShippedReason;
                                    ShipDocItemVal.IsNotDelivered = lstShipDocItemNew[j].IsNotDelivered;
                                    ShipDocItemVal.IsNotDeliveredReason = lstShipDocItemNew[j].IsNotDeliveredReason;
                                    ShipDocItemVal.ARShipToTankID = lstShipDocItemNew[j].ARShipToTankID == null ? 0 : lstShipDocItemNew[j].ARShipToTankID;
                                    ShipDocItemVal.DeliveryNotes = lstShipDocItemNew[j].DeliveryNotes;
                                    ShipDocItemVal.DeliverTrfSysTrxNo = lstShipDocItemNew[j].DeliverTrfSysTrxNo == null ? 0 : lstShipDocItemNew[j].DeliverTrfSysTrxNo;
                                    ShipDocItemVal.DeliverTrfSysLineNo = lstShipDocItemNew[j].DeliverTrfSysLineNo == null ? 0 : lstShipDocItemNew[j].DeliverTrfSysLineNo;
                                    ShipDocItemVal.MarineSessionID = lstShipDocItemNew[j].MarineSessionID == null ? 0 : lstShipDocItemNew[j].MarineSessionID;
                                    ShipDocItemVal.OrderItemNotes = lstShipDocItemNew[j].OrderItemNotes.EncodeString();
                                    ShipDocItemVal.VesselID = lstShipDocItemNew[j].VesselID == null ? 0 : lstShipDocItemNew[j].VesselID;

                                    JsonParamValue.ShipDocItemList.Add(ShipDocItemVal);
                                }
                            }

                            var lstShipDocItemCompFiltered = lstShipDocItemComp.Where(item => item.SysTrxNo.Equals(lstShipDocHdr[i].SysTrxNo));

                            List<ShipDocItemComp> lstShipDocItemCompNew = new List<ShipDocItemComp>();

                            lstShipDocItemCompNew = lstShipDocItemCompFiltered.ToList();

                            if (lstShipDocItemCompFiltered.Count() > 0)
                            {
                                for (var k = 0; k < lstShipDocItemCompFiltered.Count(); k++)
                                {
                                    ShipDocItemComp ShipDocItemCompVal = new ShipDocItemComp();
                                    ShipDocItemCompVal.SysTrxNo = lstShipDocItemCompNew[k].SysTrxNo;
                                    ShipDocItemCompVal.SysTrxLine = lstShipDocItemCompNew[k].SysTrxLine;
                                    ShipDocItemCompVal.ComponentNo = lstShipDocItemCompNew[k].ComponentNo;
                                    ShipDocItemCompVal.MasterProdID = lstShipDocItemCompNew[k].MasterProdID;
                                    ShipDocItemCompVal.MasterSiteID = lstShipDocItemCompNew[k].MasterSiteID;
                                    ShipDocItemCompVal.GrossQty = lstShipDocItemCompNew[k].GrossQty == null ? 0 : lstShipDocItemCompNew[k].GrossQty;
                                    ShipDocItemCompVal.NetQty = lstShipDocItemCompNew[k].NetQty == null ? 0 : lstShipDocItemCompNew[k].NetQty;
                                    ShipDocItemCompVal.BOLItemID = lstShipDocItemCompNew[k].BOLItemID == null ? 0 : lstShipDocItemCompNew[k].BOLItemID;
                                    ShipDocItemCompVal.FrtRateID = lstShipDocItemCompNew[k].FrtRateID == null ? 0 : lstShipDocItemCompNew[k].FrtRateID;
                                    ShipDocItemCompVal.BlendPct = lstShipDocItemCompNew[k].BlendPct == null ? 0 : lstShipDocItemCompNew[k].BlendPct;
                                    ShipDocItemCompVal.OrderQty = lstShipDocItemCompNew[k].OrderQty == null ? 0 : lstShipDocItemCompNew[k].OrderQty;
                                    ShipDocItemCompVal.Temperature = lstShipDocItemCompNew[k].Temperature == null ? 0 : lstShipDocItemCompNew[k].Temperature;
                                    ShipDocItemCompVal.SpecificGravity = lstShipDocItemCompNew[k].SpecificGravity == null ? 0 : lstShipDocItemCompNew[k].SpecificGravity;
                                    ShipDocItemCompVal.OvrBOLNo = lstShipDocItemCompNew[k].OvrBOLNo;
                                    ShipDocItemCompVal.OvrBOLDate = lstShipDocItemCompNew[k].OvrBOLDate == null ? "Jan  1 1900 12:00:00:000AM" : lstShipDocItemCompNew[k].OvrBOLDate;
                                    ShipDocItemCompVal.OvrCarrier = lstShipDocItemCompNew[k].OvrCarrier == null ? 0 : lstShipDocItemCompNew[k].OvrCarrier;
                                    ShipDocItemCompVal.OvrVehicle = lstShipDocItemCompNew[k].OvrVehicle == null ? 0 : lstShipDocItemCompNew[k].OvrVehicle;
                                    ShipDocItemCompVal.OvrDriver = lstShipDocItemCompNew[k].OvrDriver == null ? 0 : lstShipDocItemCompNew[k].OvrDriver;
                                    ShipDocItemCompVal.PayOn = lstShipDocItemCompNew[k].PayOn;
                                    ShipDocItemCompVal.FrtAmtKeyed = lstShipDocItemCompNew[k].FrtAmtKeyed == null ? 0 : lstShipDocItemCompNew[k].FrtAmtKeyed;
                                    ShipDocItemCompVal.DDPCT = lstShipDocItemCompNew[k].DDPCT == null ? 0 : lstShipDocItemCompNew[k].DDPCT;
                                    ShipDocItemCompVal.UnitCostKeyed = lstShipDocItemCompNew[k].UnitCostKeyed == null ? 0 : lstShipDocItemCompNew[k].UnitCostKeyed;
                                    ShipDocItemCompVal.CSTankFuelHistoryID = lstShipDocItemCompNew[k].CSTankFuelHistoryID == null ? 0 : lstShipDocItemCompNew[k].CSTankFuelHistoryID;
                                    ShipDocItemCompVal.BOLLineNo = lstShipDocItemCompNew[k].BOLLineNo == null ? 0 : lstShipDocItemCompNew[k].BOLLineNo;
                                    ShipDocItemCompVal.OvrDiversionState = lstShipDocItemCompNew[k].OvrDiversionState;
                                    ShipDocItemCompVal.ManualLinkToOrder = lstShipDocItemCompNew[k].ManualLinkToOrder;
                                    ShipDocItemCompVal.OvrDiversionShipToID = lstShipDocItemCompNew[k].OvrDiversionShipToID == null ? 0 : lstShipDocItemCompNew[k].OvrDiversionShipToID;
                                    ShipDocItemCompVal.FromCSTankFuelHistoryID = lstShipDocItemCompNew[k].FromCSTankFuelHistoryID == null ? 0 : lstShipDocItemCompNew[k].FromCSTankFuelHistoryID;
                                    ShipDocItemCompVal.OrgShipCompGrossQty = lstShipDocItemCompNew[k].OrgShipCompGrossQty == null ? 0 : lstShipDocItemCompNew[k].OrgShipCompGrossQty;
                                    ShipDocItemCompVal.CustomerID = lstShipDocItemCompNew[k].CustomerID;
                                    ShipDocItemCompVal.FromCSMeterFuelHistoryID = lstShipDocItemCompNew[k].FromCSMeterFuelHistoryID == null ? 0 : lstShipDocItemCompNew[k].FromCSMeterFuelHistoryID;
                                    ShipDocItemCompVal.ToCSTankID = lstShipDocItemCompNew[k].ToCSTankID == null ? 0 : lstShipDocItemCompNew[k].ToCSTankID;
                                    ShipDocItemCompVal.FromCSTankID = lstShipDocItemCompNew[k].FromCSTankID == null ? 0 : lstShipDocItemCompNew[k].FromCSTankID;
                                    ShipDocItemCompVal.FromCSMeterID = lstShipDocItemCompNew[k].FromCSMeterID == null ? 0 : lstShipDocItemCompNew[k].FromCSMeterID;
                                    ShipDocItemCompVal.EBOL_ID = lstShipDocItemCompNew[k].EBOL_ID == null ? 0 : lstShipDocItemCompNew[k].EBOL_ID;
                                    ShipDocItemCompVal.EBOLItemNumber = lstShipDocItemCompNew[k].EBOLItemNumber == null ? 0 : lstShipDocItemCompNew[k].EBOLItemNumber;
                                    ShipDocItemCompVal.ShippingNotes = lstShipDocItemCompNew[k].ShippingNotes.EncodeString();
                                    ShipDocItemCompVal.ShipTrfSysTrxNo = lstShipDocItemCompNew[k].ShipTrfSysTrxNo == null ? 0 : lstShipDocItemCompNew[k].ShipTrfSysTrxNo;
                                    ShipDocItemCompVal.ShipTrfSysLineNo = lstShipDocItemCompNew[k].ShipTrfSysLineNo == null ? 0 : lstShipDocItemCompNew[k].ShipTrfSysLineNo;

                                    JsonParamValue.ShipDocItemCompList.Add(ShipDocItemCompVal);
                                }
                            }

                            var lstShipDocItemReadingFiltered = lstShipDocItemReading.Where(item => item.SysTrxNo.Equals(lstShipDocHdr[i].SysTrxNo));

                            List<ShipDocItemReading> lstShipDocItemReadingNew = new List<ShipDocItemReading>();

                            lstShipDocItemReadingNew = lstShipDocItemReadingFiltered.ToList();

                            if (lstShipDocItemReadingFiltered.Count() > 0)
                            {
                                for (var l = 0; l < lstShipDocItemReadingFiltered.Count(); l++)
                                {
                                    ShipDocItemReading ShipDocItemReadingVal = new ShipDocItemReading();
                                    ShipDocItemReadingVal.ReadingID = lstShipDocItemReadingNew[l].ReadingID;
                                    ShipDocItemReadingVal.SrcDst = lstShipDocItemReadingNew[l].SrcDst;
                                    ShipDocItemReadingVal.CustomerID = lstShipDocItemReadingNew[l].CustomerID;
                                    ShipDocItemReadingVal.SysTrxNo = lstShipDocItemReadingNew[l].SysTrxNo;
                                    ShipDocItemReadingVal.SysTrxLine = lstShipDocItemReadingNew[l].SysTrxLine;
                                    ShipDocItemReadingVal.ComponentNo = lstShipDocItemReadingNew[l].ComponentNo;
                                    ShipDocItemReadingVal.BOLLineNo = lstShipDocItemReadingNew[l].BOLLineNo;
                                    ShipDocItemReadingVal.ReadingBy = lstShipDocItemReadingNew[l].ReadingBy;
                                    ShipDocItemReadingVal.StartTime = lstShipDocItemReadingNew[l].StartTime;
                                    ShipDocItemReadingVal.StopTime = lstShipDocItemReadingNew[l].StopTime;
                                    ShipDocItemReadingVal.BeforeDraftB = lstShipDocItemReadingNew[l].BeforeDraftB == null ? 0 : lstShipDocItemReadingNew[l].BeforeDraftB;
                                    ShipDocItemReadingVal.BeforeDraftS = lstShipDocItemReadingNew[l].BeforeDraftS == null ? 0 : lstShipDocItemReadingNew[l].BeforeDraftS;
                                    ShipDocItemReadingVal.BeforeTemp = lstShipDocItemReadingNew[l].BeforeTemp == null ? 0 : lstShipDocItemReadingNew[l].BeforeTemp;
                                    ShipDocItemReadingVal.AfterDraftB = lstShipDocItemReadingNew[l].AfterDraftB == null ? 0 : lstShipDocItemReadingNew[l].AfterDraftB;
                                    ShipDocItemReadingVal.AfterDraftS = lstShipDocItemReadingNew[l].AfterDraftS == null ? 0 : lstShipDocItemReadingNew[l].AfterDraftS;
                                    ShipDocItemReadingVal.AfterTemp = lstShipDocItemReadingNew[l].AfterTemp == null ? 0 : lstShipDocItemReadingNew[l].AfterTemp;
                                    ShipDocItemReadingVal.KeelTo = lstShipDocItemReadingNew[l].KeelTo;
                                    ShipDocItemReadingVal.KeelDegree = lstShipDocItemReadingNew[l].KeelDegree == null ? 0 : lstShipDocItemReadingNew[l].KeelDegree;
                                    ShipDocItemReadingVal.QtyBefore = lstShipDocItemReadingNew[l].QtyBefore == null ? 0 : lstShipDocItemReadingNew[l].QtyBefore;
                                    ShipDocItemReadingVal.QtyAfter = lstShipDocItemReadingNew[l].QtyAfter == null ? 0 : lstShipDocItemReadingNew[l].QtyAfter;
                                    ShipDocItemReadingVal.CalcQty = lstShipDocItemReadingNew[l].CalcQty == null ? 0 : lstShipDocItemReadingNew[l].CalcQty;
                                    ShipDocItemReadingVal.EnteredBy = lstShipDocItemReadingNew[l].EnteredBy;
                                    ShipDocItemReadingVal.ReadBy = lstShipDocItemReadingNew[l].ReadBy;
                                    ShipDocItemReadingVal.BeforeDraftFeetB = lstShipDocItemReadingNew[l].BeforeDraftFeetB == null ? 0 : lstShipDocItemReadingNew[l].BeforeDraftFeetB;
                                    ShipDocItemReadingVal.BeforeDraftFeetS = lstShipDocItemReadingNew[l].BeforeDraftFeetS == null ? 0 : lstShipDocItemReadingNew[l].BeforeDraftFeetS;
                                    ShipDocItemReadingVal.AfterDraftFeetB = lstShipDocItemReadingNew[l].AfterDraftFeetB == null ? 0 : lstShipDocItemReadingNew[l].AfterDraftFeetB;
                                    ShipDocItemReadingVal.AfterDraftFeetS = lstShipDocItemReadingNew[l].AfterDraftFeetS == null ? 0 : lstShipDocItemReadingNew[l].AfterDraftFeetS;
                                    ShipDocItemReadingVal.InSiteTankID = lstShipDocItemReadingNew[l].InSiteTankID == null ? 0 : lstShipDocItemReadingNew[l].InSiteTankID;
                                    ShipDocItemReadingVal.ProcessStep = lstShipDocItemReadingNew[l].ProcessStep;
                                    ShipDocItemReadingVal.BeforeATemp = lstShipDocItemReadingNew[l].BeforeATemp == null ? 0 : lstShipDocItemReadingNew[l].BeforeATemp;
                                    ShipDocItemReadingVal.AfterATemp = lstShipDocItemReadingNew[l].AfterATemp == null ? 0 : lstShipDocItemReadingNew[l].AfterATemp;

                                    JsonParamValue.ShipDocItemReadingList.Add(ShipDocItemReadingVal);

                                    var lstShipDocItemReadingDtlFiltered = lstShipDocItemReadingDtl.Where(item => item.ReadingID.Equals(lstShipDocItemReadingNew[l].ReadingID));

                                    List<ShipDocItemReadingDtl> lstShipDocItemReadingDtlNew = new List<ShipDocItemReadingDtl>();

                                    lstShipDocItemReadingDtlNew = lstShipDocItemReadingDtlFiltered.ToList();

                                    if (lstShipDocItemReadingDtlFiltered.Count() > 0)
                                    {
                                        for (var m = 0; m < lstShipDocItemReadingDtlFiltered.Count(); m++)
                                        {
                                            ShipDocItemReadingDtl ShipDocItemReadingDtlVal = new ShipDocItemReadingDtl();
                                            ShipDocItemReadingDtlVal.DtlID = lstShipDocItemReadingDtlNew[m].DtlID;
                                            ShipDocItemReadingDtlVal.ReadingID = lstShipDocItemReadingDtlNew[m].ReadingID;
                                            ShipDocItemReadingDtlVal.InSiteTankID = lstShipDocItemReadingDtlNew[m].InSiteTankID == null ? 0 : lstShipDocItemReadingDtlNew[m].InSiteTankID;
                                            ShipDocItemReadingDtlVal.CompartmentID = lstShipDocItemReadingDtlNew[m].CompartmentID == null ? 0 : lstShipDocItemReadingDtlNew[m].CompartmentID;
                                            ShipDocItemReadingDtlVal.PortFuelDepth_B = lstShipDocItemReadingDtlNew[m].PortFuelDepth_B == null ? -1 : lstShipDocItemReadingDtlNew[m].PortFuelDepth_B;
                                            ShipDocItemReadingDtlVal.PortFuelDepthNumerator_B = lstShipDocItemReadingDtlNew[m].PortFuelDepthNumerator_B == null ? -1 : lstShipDocItemReadingDtlNew[m].PortFuelDepthNumerator_B;
                                            ShipDocItemReadingDtlVal.MiddleFuelDepth_B = lstShipDocItemReadingDtlNew[m].MiddleFuelDepth_B == null ? -1 : lstShipDocItemReadingDtlNew[m].MiddleFuelDepth_B;
                                            ShipDocItemReadingDtlVal.MiddleFuelDepthNumerator_B = lstShipDocItemReadingDtlNew[m].MiddleFuelDepthNumerator_B == null ? -1 : lstShipDocItemReadingDtlNew[m].MiddleFuelDepthNumerator_B;
                                            ShipDocItemReadingDtlVal.SBoardFuelDepth_B = lstShipDocItemReadingDtlNew[m].SBoardFuelDepth_B == null ? -1 : lstShipDocItemReadingDtlNew[m].SBoardFuelDepth_B;
                                            ShipDocItemReadingDtlVal.SBoardFuelDepthNumerator_B = lstShipDocItemReadingDtlNew[m].SBoardFuelDepthNumerator_B == null ? -1 : lstShipDocItemReadingDtlNew[m].SBoardFuelDepthNumerator_B;
                                            ShipDocItemReadingDtlVal.PortFuelDepth_A = lstShipDocItemReadingDtlNew[m].PortFuelDepth_A == null ? -1 : lstShipDocItemReadingDtlNew[m].PortFuelDepth_A;
                                            ShipDocItemReadingDtlVal.PortFuelDepthNumerator_A = lstShipDocItemReadingDtlNew[m].PortFuelDepthNumerator_A == null ? -1 : lstShipDocItemReadingDtlNew[m].PortFuelDepthNumerator_A;
                                            ShipDocItemReadingDtlVal.MiddleFuelDepth_A = lstShipDocItemReadingDtlNew[m].MiddleFuelDepth_A == null ? -1 : lstShipDocItemReadingDtlNew[m].MiddleFuelDepth_A;
                                            ShipDocItemReadingDtlVal.MiddleFuelDepthNumerator_A = lstShipDocItemReadingDtlNew[m].MiddleFuelDepthNumerator_A == null ? -1 : lstShipDocItemReadingDtlNew[m].MiddleFuelDepthNumerator_A;
                                            ShipDocItemReadingDtlVal.SBoardFuelDepth_a = lstShipDocItemReadingDtlNew[m].SBoardFuelDepth_a == null ? -1 : lstShipDocItemReadingDtlNew[m].SBoardFuelDepth_a;
                                            ShipDocItemReadingDtlVal.SBoardFuelDepthNumerator_A = lstShipDocItemReadingDtlNew[m].SBoardFuelDepthNumerator_A == null ? -1 : lstShipDocItemReadingDtlNew[m].SBoardFuelDepthNumerator_A;
                                            ShipDocItemReadingDtlVal.Denominator = lstShipDocItemReadingDtlNew[m].Denominator == null ? 0 : lstShipDocItemReadingDtlNew[m].Denominator;
                                            ShipDocItemReadingDtlVal.MeterReading_B = lstShipDocItemReadingDtlNew[m].MeterReading_B == null ? -1 : lstShipDocItemReadingDtlNew[m].MeterReading_B;
                                            ShipDocItemReadingDtlVal.MeterReading_A = lstShipDocItemReadingDtlNew[m].MeterReading_A == null ? -1 : lstShipDocItemReadingDtlNew[m].MeterReading_A;
                                            ShipDocItemReadingDtlVal.CustomerID = lstShipDocItemReadingDtlNew[m].CustomerID;
                                            ShipDocItemReadingDtlVal.PortFeet_B = lstShipDocItemReadingDtlNew[m].PortFeet_B == null ? -1 : lstShipDocItemReadingDtlNew[m].PortFeet_B;
                                            ShipDocItemReadingDtlVal.MiddleFeet_B = lstShipDocItemReadingDtlNew[m].MiddleFeet_B == null ? -1 : lstShipDocItemReadingDtlNew[m].MiddleFeet_B;
                                            ShipDocItemReadingDtlVal.SBoardFeet_B = lstShipDocItemReadingDtlNew[m].SBoardFeet_B == null ? -1 : lstShipDocItemReadingDtlNew[m].SBoardFeet_B;
                                            ShipDocItemReadingDtlVal.PortFeet_A = lstShipDocItemReadingDtlNew[m].PortFeet_A == null ? -1 : lstShipDocItemReadingDtlNew[m].PortFeet_A;
                                            ShipDocItemReadingDtlVal.MiddleFeet_A = lstShipDocItemReadingDtlNew[m].MiddleFeet_A == null ? -1 : lstShipDocItemReadingDtlNew[m].MiddleFeet_A;
                                            ShipDocItemReadingDtlVal.SBoardFeet_A = lstShipDocItemReadingDtlNew[m].SBoardFeet_A == null ? -1 : lstShipDocItemReadingDtlNew[m].SBoardFeet_A;


                                            JsonParamValue.ShipDocItemReadingDtlList.Add(ShipDocItemReadingDtlVal);
                                        }
                                    }
                                }
                            }


                            Shipments ShipmentList = new Shipments();
                            ShipmentList.ShipmentList = JsonParamValue;

                            var jsonperVal = jsonSerialiser.Serialize(ShipmentList);

                            string jsonIgnoreNullValues = JsonConvert.SerializeObject(ShipmentList, Formatting.None, new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });

                            ParamList paramList = new ParamList();
                            parameterList parameterList = new parameterList();
                            string jsonVal = null;
                            if (ConfigurationManager.AppSettings["Env"] == "qa")
                            {
                                parameter paramVal = new parameter();
                                paramVal.name = "JsonValue";
                                //  paramVal.param_type = "IN";
                                paramVal.value = jsonperVal.ToString().Replace("\\\\", "");

                                paramList.Params.Add(paramVal);
                                jsonVal = jsonSerialiser.Serialize(paramList);
                                jsonVal = jsonVal.Replace("Params", "params");
                            }
                            else
                            {
                                parameterList.Params.Add(jsonIgnoreNullValues);
                                jsonVal = jsonSerialiser.Serialize(parameterList);
                                jsonVal = jsonVal.Replace("Params", "params");
                            }


                            //   string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                            string url = ServiceURL.UpdateShipmentDetailsURL + "&";
                            var request = (HttpWebRequest)HttpWebRequest.Create(url);
                            request.ContentType = "application/json; charset=utf-8";
                            request.Method = "POST";
                            request.Accept = "application/json; charset=utf-8";

                            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                            {
                                streamWriter.Write(jsonVal);
                                //streamWriter.Close();
                            }

                            var httpResponse = (HttpWebResponse)request.GetResponse();
                            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                            {
                                var result = streamReader.ReadToEnd();
                                List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                                if (lsResult != null)
                                {
                                    if (lsResult.Count > 0)
                                    {
                                        if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                        {
                                            string ShipmentNeedUpdateURL = ServiceURL.UpdateShipmentDetailsNeedUpdateFlagURL + "(" + lstShipDocHdr[i].SysTrxNo + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                                            string ShipmentNeedUpdateResult = new WebClient().DownloadString(ShipmentNeedUpdateURL);

                                            if (lstShipDocItemReading.Count() > 0)
                                            {
                                                string ShipmentReadingNeedUpdateURL = ServiceURL.UpdateShipmentReadingDetailsNeedUpdateFlagURL + "(" + lstShipDocHdr[i].SysTrxNo + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                                                string ShipmentReadingNeedUpdateResult = new WebClient().DownloadString(ShipmentReadingNeedUpdateURL);
                                            }
                                        }
                                        else
                                        {
                                            Logging.WriteLog("Error in UpdateShipments - SysTrxNo - " + lstShipDocHdr[i].SysTrxNo + ", Reason - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);

                                            string urlTemp = ServiceURL.UpdateShipmentDetailsReviewURL + "&";
                                            var requestTemp = (HttpWebRequest)HttpWebRequest.Create(urlTemp);
                                            requestTemp.ContentType = "application/json; charset=utf-8";
                                            requestTemp.Method = "POST";
                                            requestTemp.Accept = "application/json; charset=utf-8";

                                            using (var streamWriterTemp = new StreamWriter(requestTemp.GetRequestStream()))
                                            {
                                                streamWriterTemp.Write(jsonVal);
                                            }

                                            var httpResponseTemp = (HttpWebResponse)requestTemp.GetResponse();
                                            using (var streamReaderTemp = new StreamReader(httpResponseTemp.GetResponseStream()))
                                            {
                                                var resultTemp = streamReaderTemp.ReadToEnd();
                                                List<Results> lsResultTemp = JsonConvert.DeserializeObject<List<Results>>(resultTemp);
                                                if (lsResultTemp != null)
                                                {
                                                    if (lsResultTemp.Count > 0)
                                                    {
                                                        if (lsResultTemp[0].StatusNew.ToString().ToLower() == "success")
                                                        {
                                                            string ShipmentNeedUpdateURL = ServiceURL.UpdateShipmentDetailsNeedUpdateFlagURL + "(" + lstShipDocHdr[i].SysTrxNo + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                                                            string ShipmentNeedUpdateResult = new WebClient().DownloadString(ShipmentNeedUpdateURL);
                                                        }
                                                        else
                                                        {
                                                            Logging.WriteLog("Error in UpdateShipmentsReview - SysTrxNo - " + lstShipDocHdr[i].SysTrxNo + ", Reason - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                                            string UpdateShipmentRetryCountURL = ServiceURL.UpdateShipmentRetryCount + "(" + lstShipDocHdr[i].SysTrxNo + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                                                            string UpdateOrderRetryCountURLResult = new WebClient().DownloadString(UpdateShipmentRetryCountURL);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            Logging.WriteLog(string.Format("Error in UpdateShipments -OrderNO - {0} , ErrorMessage - {1} ", lstShipDocHdr[i].DocNo, "ShipDocItem and OrderItem are having mismatching number of rows"), EventLogEntryType.Error);
                            string UpdateShipmentRetryCountURL = ServiceURL.UpdateShipmentRetryCount + "(" + lstShipDocHdr[i].SysTrxNo + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                            string UpdateOrderRetryCountURLResult = new WebClient().DownloadString(UpdateShipmentRetryCountURL);
                        }
                    }
                    catch (System.Data.SqlClient.SqlException sqlEx)
                    {
                        Logging.WriteLog(string.Format("Error in UpdateShipments -OrderNO - {0} , ErrorMessage - {1} ", lstShipDocHdr[i].DocNo, sqlEx.Message.ToString()), EventLogEntryType.Error);
                        string UpdateShipmentRetryCountURL = ServiceURL.UpdateShipmentRetryCount + "(" + lstShipDocHdr[i].SysTrxNo + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                        string UpdateOrderRetryCountURLResult = new WebClient().DownloadString(UpdateShipmentRetryCountURL);
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteLog(string.Format("Error in UpdateShipments -OrderNO - {0} , ErrorMessage - {1} ", lstShipDocHdr[i].DocNo, ex.Message.ToString()), EventLogEntryType.Error);
                        string UpdateShipmentRetryCountURL = ServiceURL.UpdateShipmentRetryCount + "(" + lstShipDocHdr[i].SysTrxNo + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                        string UpdateOrderRetryCountURLResult = new WebClient().DownloadString(UpdateShipmentRetryCountURL);

                    }
                }
            }
            //catch (WebException webex)
            //{
            //    WebResponse errResp = webex.Response;
            //    using (Stream respStream = errResp.GetResponseStream())
            //    {
            //        StreamReader reader = new StreamReader(respStream);
            //        string text = reader.ReadToEnd();
            //    }
            //}

        }

        /// <summary>
        /// UpdateDeliveryDetails
        /// Function to update delivery details
        /// </summary>
        public static void UpdateDeliveryDetails()
        {
            try
            {
                /* Get ShipDoc to update in ascend */
                string GetShipDoc = new WebClient().DownloadString(string.Format("{0}({1})?{2}", ServiceURL.GetDeliveryDocURL, Convert.ToInt32(ConfigurationManager.AppSettings["RetryCount"]), ConfigurationManager.AppSettings["CloudAPIKEY"]));
                // string GetShipDoc = new WebClient().DownloadString(ServiceURL.GetDeliveryDocURL);
                List<ShipDoc> lstShipDocHdr = JsonConvert.DeserializeObject<List<ShipDoc>>(GetShipDoc);

                /* Get ShipDocItem to update in ascend */
                // string GetShipDocItem = new WebClient().DownloadString(ServiceURL.GetDeliveryDocItemURL);
                string GetShipDocItem = new WebClient().DownloadString(string.Format("{0}({1})?{2}", ServiceURL.GetDeliveryDocItemURL, Convert.ToInt32(ConfigurationManager.AppSettings["RetryCount"]), ConfigurationManager.AppSettings["CloudAPIKEY"]));
                List<ShipDocItem> lstShipDocItem = JsonConvert.DeserializeObject<List<ShipDocItem>>(GetShipDocItem);

                /* Get ShipDocItemComp to update in ascend */
                //  string GetShipDocItemComp = new WebClient().DownloadString(ServiceURL.GetDeliveryDocItemCompURL);
                string GetShipDocItemComp = new WebClient().DownloadString(string.Format("{0}({1})?{2}", ServiceURL.GetDeliveryDocItemCompURL, Convert.ToInt32(ConfigurationManager.AppSettings["RetryCount"]), ConfigurationManager.AppSettings["CloudAPIKEY"]));
                List<ShipDocItemComp> lstShipDocItemComp = JsonConvert.DeserializeObject<List<ShipDocItemComp>>(GetShipDocItemComp);

                /* Get ShipDocItemComp to update in ascend */
                string GetShipDocItemReading = new WebClient().DownloadString(ServiceURL.GetDeliveryDocItemReadingURL);
                List<ShipDocItemReading> lstShipDocItemReading = JsonConvert.DeserializeObject<List<ShipDocItemReading>>(GetShipDocItemReading);

                /* Get ShipDocItemComp to update in ascend */
                string GetShipDocItemReadingDtl = new WebClient().DownloadString(ServiceURL.GetDeliveryDocItemReadingDtlURL);
                List<ShipDocItemReadingDtl> lstShipDocItemReadingDtl = JsonConvert.DeserializeObject<List<ShipDocItemReadingDtl>>(GetShipDocItemReadingDtl);

                /* Get Delivery to update in ascend */
                string GetShipmentLoad = new WebClient().DownloadString(ServiceURL.GetDelivery);
                List<MarineShipment> lstMarineShipment = JsonConvert.DeserializeObject<List<MarineShipment>>(GetShipmentLoad);

                /* Get DeliveryDetails to update in ascend */
                string GetShipmentLoadDetails = new WebClient().DownloadString(ServiceURL.GetDeliveryDetails);
                List<MarineShipmentDetail> lstMarineShipmentDetails = JsonConvert.DeserializeObject<List<MarineShipmentDetail>>(GetShipmentLoadDetails);

                /* Get ShipDocItemVessel to update in ascend*/
                string GetShipDocItemVessel = new WebClient().DownloadString(ServiceURL.GetShipDocItemVessel);
                List<ShipDocItemVessel> lstShipDocItemVessel = JsonConvert.DeserializeObject<List<ShipDocItemVessel>>(GetShipDocItemVessel);

                Logging.WriteLog("Function Called UpdateDeliveryDetails - Count " + lstShipDocHdr.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };

                if (lstShipDocHdr.Count > 0)
                {
                    for (var i = 0; i < lstShipDocHdr.Count; i++)
                    {
                        try
                        {
                            ShipmentJSONParam JsonParamValue = new ShipmentJSONParam();

                            ShipDoc ShipDocHdr = new ShipDoc();
                            ShipDocHdr.SysTrxNo = lstShipDocHdr[i].SysTrxNo;
                            ShipDocHdr.SO = lstShipDocHdr[i].SO;
                            ShipDocHdr.CompanyID = lstShipDocHdr[i].CompanyID;
                            ShipDocHdr.DtTm = lstShipDocHdr[i].DtTm == null ? "Jan  1 1900 12:00:00:000AM" : lstShipDocHdr[i].DtTm;
                            ShipDocHdr.PrintDtTm = lstShipDocHdr[i].PrintDtTm == null ? "Jan  1 1900 12:00:00:000AM" : lstShipDocHdr[i].PrintDtTm;
                            ShipDocHdr.ShipDtTm = lstShipDocHdr[i].ShipDtTm == null ? "Jan  1 1900 12:00:00:000AM" : lstShipDocHdr[i].ShipDtTm;
                            ShipDocHdr.DocType = lstShipDocHdr[i].DocType;
                            ShipDocHdr.DocNo = lstShipDocHdr[i].DocNo;
                            ShipDocHdr.UserID = lstShipDocHdr[i].UserID;
                            ShipDocHdr.CarrierID = lstShipDocHdr[i].CarrierID == null ? 0 : lstShipDocHdr[i].CarrierID;
                            ShipDocHdr.VehicleID = lstShipDocHdr[i].VehicleID == null ? 0 : lstShipDocHdr[i].VehicleID;
                            //ShipDocHdr.DriverID = lstShipDocHdr[i].DriverID == null ? 0 : lstShipDocHdr[i].DriverID;
                            ShipDocHdr.BOLNo = lstShipDocHdr[i].BOLNo;
                            ShipDocHdr.Status = lstShipDocHdr[i].Status;
                            ShipDocHdr.FrtInID = lstShipDocHdr[i].FrtInID == null ? 0 : lstShipDocHdr[i].FrtInID;
                            ShipDocHdr.OrderStatusID = lstShipDocHdr[i].OrderStatusID == null ? 0 : lstShipDocHdr[i].OrderStatusID;
                            ShipDocHdr.SessionNo = lstShipDocHdr[i].SessionNo;
                            ShipDocHdr.ManualLinkCreate = lstShipDocHdr[i].ManualLinkCreate;
                            ShipDocHdr.DiversionState = lstShipDocHdr[i].DiversionState;
                            ShipDocHdr.DiversionShipToID = lstShipDocHdr[i].DiversionShipToID == null ? 0 : lstShipDocHdr[i].DiversionShipToID;
                            ShipDocHdr.CustomerID = lstShipDocHdr[i].CustomerID;
                            ShipDocHdr.SignatureImage = lstShipDocHdr[i].SignatureImage;
                            ShipDocHdr.SignatureDateTime = lstShipDocHdr[i].SignatureDateTime == null ? "Jan  1 1900 12:00:00:000AM" : lstShipDocHdr[i].SignatureDateTime;
                            ShipDocHdr.SignatureStatus = lstShipDocHdr[i].SignatureStatus == null ? 'O' : lstShipDocHdr[i].SignatureStatus;
                            ShipDocHdr.BOLImage = lstShipDocHdr[i].BOLImage;
                            ShipDocHdr.DeliveryImage = lstShipDocHdr[i].DeliveryImage;
                            ShipDocHdr.LoadNo = lstShipDocHdr[i].LoadNo;

                            JsonParamValue.ShipDocList.Add(ShipDocHdr);

                            int shipDocItemCount = lstShipDocItem.Where(item => item.SysTrxNo.Equals(lstShipDocHdr[i].SysTrxNo)).Count();
                            // string orderItemCount = new WebClient().DownloadString(ServiceURL.GetOrderItemCountURL);

                            string orderItemCount = new WebClient().DownloadString(string.Format("{0}({1})?{2}", ServiceURL.GetOrderItemCountURL, ShipDocHdr.SysTrxNo, ConfigurationManager.AppSettings["CloudAPIKEY"]));

                            string clientOrderItemCount = new WebClient().DownloadString(string.Format("{0}({1})?{2}", ServiceURL.GetClientOrderItemCountURL, ShipDocHdr.SysTrxNo, ConfigurationManager.AppSettings["ClientAPIKEY"]));

                            List<Counts> lstItemCount = JsonConvert.DeserializeObject<List<Counts>>(orderItemCount);
                            List<Counts> lstClientItemCount = JsonConvert.DeserializeObject<List<Counts>>(clientOrderItemCount);


                            // if (0==0)
                            if (shipDocItemCount == lstItemCount[0].Count && lstItemCount[0].Count == lstClientItemCount[0].Count)
                            {

                                // Delivery to update starts

                                var lstMarineShipmentFiltered = lstMarineShipment.Where(item => item.OrderSysTrxNo.Equals(lstShipDocHdr[i].SysTrxNo));

                                List<MarineShipment> lstMarineShipmentNew = new List<MarineShipment>();

                                lstMarineShipmentNew = lstMarineShipmentFiltered.ToList();

                                if (lstMarineShipmentNew.Count > 0)
                                {
                                    for (var n = 0; n < lstMarineShipmentNew.Count; n++)
                                    {
                                        MarineShipment MarineShipmentHdr = new MarineShipment();

                                        MarineShipmentHdr.SessionID = lstMarineShipmentNew[n].SessionID;
                                        MarineShipmentHdr.OrderSysTrxNo = lstMarineShipmentNew[n].OrderSysTrxNo == null ? 0 : lstMarineShipmentNew[n].OrderSysTrxNo;
                                        MarineShipmentHdr.DeliveryDtTm = lstMarineShipmentNew[n].DeliveryDtTm == null ? "Jan  1 1900 12:00:00:000AM" : lstMarineShipmentNew[n].DeliveryDtTm;
                                        MarineShipmentHdr.MarineLocID = lstMarineShipmentNew[n].MarineLocID;
                                        MarineShipmentHdr.PersonID = lstMarineShipmentNew[n].PersonID == null ? 0 : lstMarineShipmentNew[n].PersonID;
                                        MarineShipmentHdr.CarrierID = lstMarineShipmentNew[n].CarrierID;
                                        MarineShipmentHdr.VehicleID = lstMarineShipmentNew[n].VehicleID;
                                        MarineShipmentHdr.DocumentNo = lstMarineShipmentNew[n].DocumentNo;
                                        MarineShipmentHdr.DocumentType = lstMarineShipmentNew[n].DocumentType;
                                        MarineShipmentHdr.CustomerID = lstMarineShipmentNew[n].CustomerID;
                                        MarineShipmentHdr.ShipDtTm = lstMarineShipmentNew[n].ShipDtTm == null ? "Jan  1 1900 12:00:00:000AM" : lstMarineShipmentNew[n].ShipDtTm;
                                        MarineShipmentHdr.MasterSiteID = lstMarineShipmentNew[n].MasterSiteID == null ? 0 : lstMarineShipmentNew[n].MasterSiteID;

                                        JsonParamValue.MarineShipmentList.Add(MarineShipmentHdr);

                                    }
                                }
                                var lstMarineShipmentDetailsFiltered = lstMarineShipmentDetails.Where(item => item.ShipSysTrxNo.Equals(lstShipDocHdr[i].SysTrxNo));
                                List<MarineShipmentDetail> lstMarineShipmentDetailsNew = new List<MarineShipmentDetail>();
                                lstMarineShipmentDetailsNew = lstMarineShipmentDetailsFiltered.ToList();

                                if (lstMarineShipmentDetailsNew.Count > 0)
                                {
                                    for (var p = 0; p < lstMarineShipmentDetailsNew.Count; p++)
                                    {
                                        MarineShipmentDetail MarineShipmentDetailHdr = new MarineShipmentDetail();

                                        MarineShipmentDetailHdr.SessionID = lstMarineShipmentDetailsNew[p].SessionID;
                                        MarineShipmentDetailHdr.SysTrxLine = lstMarineShipmentDetailsNew[p].SysTrxLine;
                                        MarineShipmentDetailHdr.MasterProdID = lstMarineShipmentDetailsNew[p].MasterProdID;

                                        MarineShipmentDetailHdr.ShipToVesselID = lstMarineShipmentDetailsNew[p].ShipToVesselID == null ? 0 : lstMarineShipmentDetailsNew[p].ShipToVesselID;
                                        MarineShipmentDetailHdr.ToTankID = lstMarineShipmentDetailsNew[p].ToTankID == null ? 0 : lstMarineShipmentDetailsNew[p].ToTankID;
                                        MarineShipmentDetailHdr.UOMID = lstMarineShipmentDetailsNew[p].UOMID == null ? 0 : lstMarineShipmentDetailsNew[p].UOMID;
                                        MarineShipmentDetailHdr.Temperature = lstMarineShipmentDetailsNew[p].Temperature == null ? 0 : lstMarineShipmentDetailsNew[p].Temperature;
                                        MarineShipmentDetailHdr.SpecificGravity = lstMarineShipmentDetailsNew[p].SpecificGravity == null ? 0 : lstMarineShipmentDetailsNew[p].SpecificGravity;
                                        MarineShipmentDetailHdr.GrossQty = lstMarineShipmentDetailsNew[p].GrossQty;
                                        MarineShipmentDetailHdr.NetQty = lstMarineShipmentDetailsNew[p].NetQty;
                                        MarineShipmentDetailHdr.DeliverAt = lstMarineShipmentDetailsNew[p].DeliverAt == null ? 0 : lstMarineShipmentDetailsNew[p].DeliverAt;
                                        MarineShipmentDetailHdr.Note = !string.IsNullOrEmpty(lstMarineShipmentDetailsNew[p].Note) ? lstMarineShipmentDetailsNew[p].Note.EncodeString() : null;

                                        MarineShipmentDetailHdr.OrderSysTrxLine = lstMarineShipmentDetailsNew[p].OrderSysTrxLine == null ? 0 : lstMarineShipmentDetailsNew[p].OrderSysTrxLine;
                                        MarineShipmentDetailHdr.ShipSysTrxNo = lstMarineShipmentDetailsNew[p].ShipSysTrxNo == null ? 0 : lstMarineShipmentDetailsNew[p].ShipSysTrxNo;
                                        MarineShipmentDetailHdr.ShipSysTrxLine = lstMarineShipmentDetailsNew[p].ShipSysTrxLine;
                                        MarineShipmentDetailHdr.APIRating = lstMarineShipmentDetailsNew[p].APIRating == null ? 0 : lstMarineShipmentDetailsNew[p].APIRating;
                                        MarineShipmentDetailHdr.ClientID = lstMarineShipmentDetailsNew[p].CustomerID == null ? 0 : Convert.ToInt32(lstMarineShipmentDetailsNew[p].CustomerID);

                                        JsonParamValue.MarineShipmentDetailList.Add(MarineShipmentDetailHdr);

                                    }
                                }

                                var lstShipDocItemVesselFiltered = lstShipDocItemVessel.Where(item => item.SysTrxNo.Equals(lstShipDocHdr[i].SysTrxNo));
                                List<ShipDocItemVessel> lstShipDocItemVesselNew = new List<ShipDocItemVessel>();

                                lstShipDocItemVesselNew = lstShipDocItemVesselFiltered.ToList();

                                if (lstShipDocItemVesselNew.Count > 0)
                                {
                                    for (var q = 0; q < lstShipDocItemVesselNew.Count; q++)
                                    {
                                        ShipDocItemVessel MarineShipDocItemVessel = new ShipDocItemVessel();
                                        MarineShipDocItemVessel.SysTrxNo = lstShipDocItemVesselNew[q].SysTrxNo;
                                        MarineShipDocItemVessel.SysTrxLine = lstShipDocItemVesselNew[q].SysTrxLine;
                                        MarineShipDocItemVessel.MarineDeliverSessionID = lstShipDocItemVesselNew[q].MarineDeliverSessionID;
                                        MarineShipDocItemVessel.MasterProdID = lstShipDocItemVesselNew[q].MasterProdID;
                                        //MarineShipDocItemVessel.ShipToVesselID = lstShipDocItemVesselNew[q].ShipToVesselID == null ? 0 : lstShipDocItemVesselNew[q].ShipToVesselID;
                                        MarineShipDocItemVessel.ShipToVesselID = lstShipDocItemVesselNew[q].ShipToVesselID == null ? 0 : lstShipDocItemVesselNew[q].ShipToVesselID;
                                        MarineShipDocItemVessel.Qty = lstShipDocItemVesselNew[q].Qty;
                                        MarineShipDocItemVessel.OrderSysTrxNo = lstShipDocItemVesselNew[q].OrderSysTrxNo == null ? 0 : lstShipDocItemVesselNew[q].OrderSysTrxNo;
                                        MarineShipDocItemVessel.OrderSysTrxLine = lstShipDocItemVesselNew[q].OrderSysTrxLine == null ? 0 : lstShipDocItemVesselNew[q].OrderSysTrxLine;
                                        //MarineShipDocItemVessel.MarineLocID = lstShipDocItemVesselNew[q].MarineLocID == null ? 0 : lstShipDocItemVesselNew[q].MarineLocID;
                                        MarineShipDocItemVessel.MarineLocID = lstShipDocItemVesselNew[q].MarineLocID == null ? 0 : lstShipDocItemVesselNew[q].MarineLocID;
                                        MarineShipDocItemVessel.UOMID = lstShipDocItemVesselNew[q].UOMID == null ? 0 : lstShipDocItemVesselNew[q].UOMID;
                                        MarineShipDocItemVessel.PersonID = lstShipDocItemVesselNew[q].PersonID == null ? 0 : lstShipDocItemVesselNew[q].PersonID;
                                        MarineShipDocItemVessel.CustomerID = lstShipDocItemVesselNew[q].CustomerID == null ? 0 : lstShipDocItemVesselNew[q].CustomerID;
                                        MarineShipDocItemVessel.Latitude = lstShipDocItemVesselNew[q].Latitude == null ? 0 : lstShipDocItemVesselNew[q].Latitude;
                                        MarineShipDocItemVessel.Longitude = lstShipDocItemVesselNew[q].Longitude == null ? 0 : lstShipDocItemVesselNew[q].Longitude;

                                        JsonParamValue.MarineShipDocItemVesselList.Add(MarineShipDocItemVessel);
                                    }
                                }

                                // Delivery to update ends

                                var lstShipDocItemFiltered = lstShipDocItem.Where(item => item.SysTrxNo.Equals(lstShipDocHdr[i].SysTrxNo));
                                List<ShipDocItem> lstShipDocItemNew = new List<ShipDocItem>();

                                lstShipDocItemNew = lstShipDocItemFiltered.ToList();

                                if (lstShipDocItemFiltered.Count() > 0)
                                {
                                    for (var j = 0; j < lstShipDocItemFiltered.Count(); j++)
                                    {
                                        ShipDocItem ShipDocItemVal = new ShipDocItem();
                                        ShipDocItemVal.SysTrxNo = lstShipDocItemNew[j].SysTrxNo;
                                        ShipDocItemVal.SysTrxLine = lstShipDocItemNew[j].SysTrxLine;
                                        ShipDocItemVal.MasterProdID = lstShipDocItemNew[j].MasterProdID;
                                        ShipDocItemVal.MasterSiteID = lstShipDocItemNew[j].MasterSiteID;
                                        ShipDocItemVal.OrderSysTrxNo = lstShipDocItemNew[j].OrderSysTrxNo == null ? 0 : lstShipDocItemNew[j].OrderSysTrxNo;
                                        ShipDocItemVal.OrderSysTrxLine = lstShipDocItemNew[j].OrderSysTrxLine == null ? 0 : lstShipDocItemNew[j].OrderSysTrxLine;
                                        ShipDocItemVal.InvoiceSysTrxNo = lstShipDocItemNew[j].InvoiceSysTrxNo == null ? 0 : lstShipDocItemNew[j].InvoiceSysTrxNo;
                                        ShipDocItemVal.InvoiceSysTrxLine = lstShipDocItemNew[j].InvoiceSysTrxLine == null ? 0 : lstShipDocItemNew[j].InvoiceSysTrxLine;
                                        ShipDocItemVal.DtTm = lstShipDocItemNew[j].DtTm == null ? "Jan  1 1900 12:00:00:000AM" : lstShipDocItemNew[j].DtTm;
                                        ShipDocItemVal.UserID = lstShipDocItemNew[j].UserID;
                                        ShipDocItemVal.ShipQty = lstShipDocItemNew[j].ShipQty == null ? 0 : lstShipDocItemNew[j].ShipQty;
                                        ShipDocItemVal.DelivDtTm = lstShipDocItemNew[j].DelivDtTm == null ? "Jan  1 1900 12:00:00:000AM" : lstShipDocItemNew[j].DelivDtTm;
                                        ShipDocItemVal.DelivQty = lstShipDocItemNew[j].DelivQty == null ? 0 : lstShipDocItemNew[j].DelivQty;
                                        ShipDocItemVal.DiscDt = lstShipDocItemNew[j].DiscDt == null ? "Jan  1 1900 12:00:00:000AM" : lstShipDocItemNew[j].DiscDt;
                                        ShipDocItemVal.DueDt1 = lstShipDocItemNew[j].DueDt1 == null ? "Jan  1 1900 12:00:00:000AM" : lstShipDocItemNew[j].DueDt1;
                                        ShipDocItemVal.DueDt2 = lstShipDocItemNew[j].DueDt2 == null ? "Jan  1 1900 12:00:00:000AM" : lstShipDocItemNew[j].DueDt2;
                                        ShipDocItemVal.DueDt3 = lstShipDocItemNew[j].DueDt3 == null ? "Jan  1 1900 12:00:00:000AM" : lstShipDocItemNew[j].DueDt3;
                                        ShipDocItemVal.TermsID = lstShipDocItemNew[j].TermsID == null ? 0 : lstShipDocItemNew[j].TermsID;
                                        ShipDocItemVal.Invoice = lstShipDocItemNew[j].Invoice;
                                        ShipDocItemVal.Invoiced = lstShipDocItemNew[j].Invoiced;
                                        ShipDocItemVal.Status = lstShipDocItemNew[j].Status;
                                        ShipDocItemVal.ProdAggrGrpID = lstShipDocItemNew[j].ProdAggrGrpID == null ? 0 : lstShipDocItemNew[j].ProdAggrGrpID;
                                        ShipDocItemVal.OrderQty = lstShipDocItemNew[j].OrderQty == null ? 0 : lstShipDocItemNew[j].OrderQty;
                                        ShipDocItemVal.SellAt = lstShipDocItemNew[j].SellAt;
                                        ShipDocItemVal.ShipNetQty = lstShipDocItemNew[j].ShipNetQty == null ? 0 : lstShipDocItemNew[j].ShipNetQty;
                                        ShipDocItemVal.CustomerID = lstShipDocItemNew[j].CustomerID;
                                        ShipDocItemVal.BOLQtyVarianceReason = lstShipDocItemNew[j].BOLQtyVarianceReason;
                                        ShipDocItemVal.DeliveryQtyVarianceReason = lstShipDocItemNew[j].DeliveryQtyVarianceReason;
                                        ShipDocItemVal.IsNotShipped = lstShipDocItemNew[j].IsNotShipped;
                                        ShipDocItemVal.IsNotShippedReason = lstShipDocItemNew[j].IsNotShippedReason;
                                        ShipDocItemVal.IsNotDelivered = lstShipDocItemNew[j].IsNotDelivered;
                                        ShipDocItemVal.IsNotDeliveredReason = lstShipDocItemNew[j].IsNotDeliveredReason;
                                        ShipDocItemVal.ARShipToTankID = lstShipDocItemNew[j].ARShipToTankID == null ? 0 : lstShipDocItemNew[j].ARShipToTankID;
                                        ShipDocItemVal.DeliveryNotes = lstShipDocItemNew[j].DeliveryNotes;
                                        ShipDocItemVal.DeliverTrfSysTrxNo = lstShipDocItemNew[j].DeliverTrfSysTrxNo == null ? 0 : lstShipDocItemNew[j].DeliverTrfSysTrxNo;
                                        ShipDocItemVal.DeliverTrfSysLineNo = lstShipDocItemNew[j].DeliverTrfSysLineNo == null ? 0 : lstShipDocItemNew[j].DeliverTrfSysLineNo;
                                        ShipDocItemVal.MarineSessionID = lstShipDocItemNew[j].MarineSessionID == null ? 0 : lstShipDocItemNew[j].MarineSessionID;
                                        ShipDocItemVal.OrderItemNotes = !string.IsNullOrEmpty(lstShipDocItemNew[j].OrderItemNotes) ? lstShipDocItemNew[j].OrderItemNotes.EncodeString() : null;
                                        ShipDocItemVal.VesselID = lstShipDocItemNew[j].VesselID == null ? 0 : lstShipDocItemNew[j].VesselID;

                                        JsonParamValue.ShipDocItemList.Add(ShipDocItemVal);
                                    }
                                }
                                var lstShipDocItemCompFiltered = lstShipDocItemComp.Where(item => item.SysTrxNo.Equals(lstShipDocHdr[i].SysTrxNo));
                                List<ShipDocItemComp> lstShipDocItemCompNew = new List<ShipDocItemComp>();

                                lstShipDocItemCompNew = lstShipDocItemCompFiltered.ToList();

                                if (lstShipDocItemCompFiltered.Count() > 0)
                                {
                                    for (var k = 0; k < lstShipDocItemCompFiltered.Count(); k++)
                                    {
                                        ShipDocItemComp ShipDocItemCompVal = new ShipDocItemComp();
                                        ShipDocItemCompVal.SysTrxNo = lstShipDocItemCompNew[k].SysTrxNo;
                                        ShipDocItemCompVal.SysTrxLine = lstShipDocItemCompNew[k].SysTrxLine;
                                        ShipDocItemCompVal.ComponentNo = lstShipDocItemCompNew[k].ComponentNo;
                                        ShipDocItemCompVal.MasterProdID = lstShipDocItemCompNew[k].MasterProdID;
                                        ShipDocItemCompVal.MasterSiteID = lstShipDocItemCompNew[k].MasterSiteID;
                                        ShipDocItemCompVal.GrossQty = lstShipDocItemCompNew[k].GrossQty == null ? 0 : lstShipDocItemCompNew[k].GrossQty;
                                        ShipDocItemCompVal.NetQty = lstShipDocItemCompNew[k].NetQty == null ? 0 : lstShipDocItemCompNew[k].NetQty;
                                        ShipDocItemCompVal.BOLItemID = lstShipDocItemCompNew[k].BOLItemID == null ? 0 : lstShipDocItemCompNew[k].BOLItemID;
                                        ShipDocItemCompVal.FrtRateID = lstShipDocItemCompNew[k].FrtRateID == null ? 0 : lstShipDocItemCompNew[k].FrtRateID;
                                        ShipDocItemCompVal.BlendPct = lstShipDocItemCompNew[k].BlendPct == null ? 0 : lstShipDocItemCompNew[k].BlendPct;
                                        ShipDocItemCompVal.OrderQty = lstShipDocItemCompNew[k].OrderQty == null ? 0 : lstShipDocItemCompNew[k].OrderQty;
                                        ShipDocItemCompVal.Temperature = lstShipDocItemCompNew[k].Temperature == null ? 0 : lstShipDocItemCompNew[k].Temperature;
                                        ShipDocItemCompVal.SpecificGravity = lstShipDocItemCompNew[k].SpecificGravity == null ? 0 : lstShipDocItemCompNew[k].SpecificGravity;
                                        ShipDocItemCompVal.OvrBOLNo = lstShipDocItemCompNew[k].OvrBOLNo;
                                        ShipDocItemCompVal.OvrBOLDate = lstShipDocItemCompNew[k].OvrBOLDate == null ? "Jan  1 1900 12:00:00:000AM" : lstShipDocItemCompNew[k].OvrBOLDate;
                                        ShipDocItemCompVal.OvrCarrier = lstShipDocItemCompNew[k].OvrCarrier == null ? 0 : lstShipDocItemCompNew[k].OvrCarrier;
                                        ShipDocItemCompVal.OvrVehicle = lstShipDocItemCompNew[k].OvrVehicle == null ? 0 : lstShipDocItemCompNew[k].OvrVehicle;
                                        ShipDocItemCompVal.OvrDriver = lstShipDocItemCompNew[k].OvrDriver == null ? 0 : lstShipDocItemCompNew[k].OvrDriver;
                                        ShipDocItemCompVal.PayOn = lstShipDocItemCompNew[k].PayOn;
                                        ShipDocItemCompVal.FrtAmtKeyed = lstShipDocItemCompNew[k].FrtAmtKeyed == null ? 0 : lstShipDocItemCompNew[k].FrtAmtKeyed;
                                        ShipDocItemCompVal.DDPCT = lstShipDocItemCompNew[k].DDPCT == null ? 0 : lstShipDocItemCompNew[k].DDPCT;
                                        ShipDocItemCompVal.UnitCostKeyed = lstShipDocItemCompNew[k].UnitCostKeyed == null ? 0 : lstShipDocItemCompNew[k].UnitCostKeyed;
                                        ShipDocItemCompVal.CSTankFuelHistoryID = lstShipDocItemCompNew[k].CSTankFuelHistoryID == null ? 0 : lstShipDocItemCompNew[k].CSTankFuelHistoryID;
                                        ShipDocItemCompVal.BOLLineNo = lstShipDocItemCompNew[k].BOLLineNo == null ? 0 : lstShipDocItemCompNew[k].BOLLineNo;
                                        ShipDocItemCompVal.OvrDiversionState = lstShipDocItemCompNew[k].OvrDiversionState;
                                        ShipDocItemCompVal.ManualLinkToOrder = lstShipDocItemCompNew[k].ManualLinkToOrder;
                                        ShipDocItemCompVal.OvrDiversionShipToID = lstShipDocItemCompNew[k].OvrDiversionShipToID == null ? 0 : lstShipDocItemCompNew[k].OvrDiversionShipToID;
                                        ShipDocItemCompVal.FromCSTankFuelHistoryID = lstShipDocItemCompNew[k].FromCSTankFuelHistoryID == null ? 0 : lstShipDocItemCompNew[k].FromCSTankFuelHistoryID;
                                        ShipDocItemCompVal.OrgShipCompGrossQty = lstShipDocItemCompNew[k].OrgShipCompGrossQty == null ? 0 : lstShipDocItemCompNew[k].OrgShipCompGrossQty;
                                        ShipDocItemCompVal.CustomerID = lstShipDocItemCompNew[k].CustomerID;
                                        ShipDocItemCompVal.FromCSMeterFuelHistoryID = lstShipDocItemCompNew[k].FromCSMeterFuelHistoryID == null ? 0 : lstShipDocItemCompNew[k].FromCSMeterFuelHistoryID;
                                        ShipDocItemCompVal.ToCSTankID = lstShipDocItemCompNew[k].ToCSTankID == null ? 0 : lstShipDocItemCompNew[k].ToCSTankID;
                                        ShipDocItemCompVal.FromCSTankID = lstShipDocItemCompNew[k].FromCSTankID == null ? 0 : lstShipDocItemCompNew[k].FromCSTankID;
                                        ShipDocItemCompVal.FromCSMeterID = lstShipDocItemCompNew[k].FromCSMeterID == null ? 0 : lstShipDocItemCompNew[k].FromCSMeterID;
                                        ShipDocItemCompVal.EBOL_ID = lstShipDocItemCompNew[k].EBOL_ID == null ? 0 : lstShipDocItemCompNew[k].EBOL_ID;
                                        ShipDocItemCompVal.EBOLItemNumber = lstShipDocItemCompNew[k].EBOLItemNumber == null ? 0 : lstShipDocItemCompNew[k].EBOLItemNumber;
                                        ShipDocItemCompVal.ShippingNotes = lstShipDocItemCompNew[k].ShippingNotes.EncodeString();
                                        ShipDocItemCompVal.ShipTrfSysTrxNo = lstShipDocItemCompNew[k].ShipTrfSysTrxNo == null ? 0 : lstShipDocItemCompNew[k].ShipTrfSysTrxNo;
                                        ShipDocItemCompVal.ShipTrfSysLineNo = lstShipDocItemCompNew[k].ShipTrfSysLineNo == null ? 0 : lstShipDocItemCompNew[k].ShipTrfSysLineNo;

                                        JsonParamValue.ShipDocItemCompList.Add(ShipDocItemCompVal);
                                    }
                                }

                                var lstShipDocItemReadingFiltered = lstShipDocItemReading.Where(item => item.SysTrxNo.Equals(lstShipDocHdr[i].SysTrxNo));
                                List<ShipDocItemReading> lstShipDocItemReadingNew = new List<ShipDocItemReading>();

                                lstShipDocItemReadingNew = lstShipDocItemReadingFiltered.ToList();

                                if (lstShipDocItemReadingFiltered.Count() > 0)
                                {
                                    for (var l = 0; l < lstShipDocItemReadingFiltered.Count(); l++)
                                    {
                                        ShipDocItemReading ShipDocItemReadingVal = new ShipDocItemReading();
                                        ShipDocItemReadingVal.ReadingID = lstShipDocItemReadingNew[l].ReadingID;
                                        ShipDocItemReadingVal.SrcDst = lstShipDocItemReadingNew[l].SrcDst;
                                        ShipDocItemReadingVal.SysTrxNo = lstShipDocItemReadingNew[l].SysTrxNo;
                                        ShipDocItemReadingVal.SysTrxLine = lstShipDocItemReadingNew[l].SysTrxLine;
                                        ShipDocItemReadingVal.ComponentNo = lstShipDocItemReadingNew[l].ComponentNo;
                                        ShipDocItemReadingVal.BOLLineNo = lstShipDocItemReadingNew[l].BOLLineNo;
                                        ShipDocItemReadingVal.ReadingBy = lstShipDocItemReadingNew[l].ReadingBy;
                                        ShipDocItemReadingVal.StartTime = lstShipDocItemReadingNew[l].StartTime;
                                        ShipDocItemReadingVal.StopTime = lstShipDocItemReadingNew[l].StopTime;
                                        ShipDocItemReadingVal.BeforeDraftB = lstShipDocItemReadingNew[l].BeforeDraftB == null ? 0 : lstShipDocItemReadingNew[l].BeforeDraftB;
                                        ShipDocItemReadingVal.BeforeDraftS = lstShipDocItemReadingNew[l].BeforeDraftS == null ? 0 : lstShipDocItemReadingNew[l].BeforeDraftS;
                                        ShipDocItemReadingVal.BeforeTemp = lstShipDocItemReadingNew[l].BeforeTemp == null ? 0 : lstShipDocItemReadingNew[l].BeforeTemp;
                                        ShipDocItemReadingVal.AfterDraftB = lstShipDocItemReadingNew[l].AfterDraftB == null ? 0 : lstShipDocItemReadingNew[l].AfterDraftB;
                                        ShipDocItemReadingVal.AfterDraftS = lstShipDocItemReadingNew[l].AfterDraftS == null ? 0 : lstShipDocItemReadingNew[l].AfterDraftS;
                                        ShipDocItemReadingVal.AfterTemp = lstShipDocItemReadingNew[l].AfterTemp == null ? 0 : lstShipDocItemReadingNew[l].AfterTemp;
                                        ShipDocItemReadingVal.KeelTo = lstShipDocItemReadingNew[l].KeelTo;
                                        ShipDocItemReadingVal.KeelDegree = lstShipDocItemReadingNew[l].KeelDegree == null ? 0 : lstShipDocItemReadingNew[l].KeelDegree;
                                        ShipDocItemReadingVal.QtyBefore = lstShipDocItemReadingNew[l].QtyBefore == null ? 0 : lstShipDocItemReadingNew[l].QtyBefore;
                                        ShipDocItemReadingVal.QtyAfter = lstShipDocItemReadingNew[l].QtyAfter == null ? 0 : lstShipDocItemReadingNew[l].QtyAfter;
                                        ShipDocItemReadingVal.CalcQty = lstShipDocItemReadingNew[l].CalcQty == null ? 0 : lstShipDocItemReadingNew[l].CalcQty;
                                        ShipDocItemReadingVal.EnteredBy = lstShipDocItemReadingNew[l].EnteredBy;
                                        ShipDocItemReadingVal.ReadBy = lstShipDocItemReadingNew[l].ReadBy;
                                        ShipDocItemReadingVal.BeforeDraftFeetB = lstShipDocItemReadingNew[l].BeforeDraftFeetB == null ? 0 : lstShipDocItemReadingNew[l].BeforeDraftFeetB;
                                        ShipDocItemReadingVal.BeforeDraftFeetS = lstShipDocItemReadingNew[l].BeforeDraftFeetS == null ? 0 : lstShipDocItemReadingNew[l].BeforeDraftFeetS;
                                        ShipDocItemReadingVal.AfterDraftFeetB = lstShipDocItemReadingNew[l].AfterDraftFeetB == null ? 0 : lstShipDocItemReadingNew[l].AfterDraftFeetB;
                                        ShipDocItemReadingVal.AfterDraftFeetS = lstShipDocItemReadingNew[l].AfterDraftFeetS == null ? 0 : lstShipDocItemReadingNew[l].AfterDraftFeetS;
                                        ShipDocItemReadingVal.InSiteTankID = lstShipDocItemReadingNew[l].InSiteTankID == null ? 0 : lstShipDocItemReadingNew[l].InSiteTankID;
                                        ShipDocItemReadingVal.ProcessStep = lstShipDocItemReadingNew[l].ProcessStep;
                                        ShipDocItemReadingVal.BeforeATemp = lstShipDocItemReadingNew[l].BeforeATemp == null ? 0 : lstShipDocItemReadingNew[l].BeforeATemp;
                                        ShipDocItemReadingVal.AfterATemp = lstShipDocItemReadingNew[l].AfterATemp == null ? 0 : lstShipDocItemReadingNew[l].AfterATemp;

                                        //ShipDocItemReadingVal.SessionID = lstShipDocItemReadingNew[l].SessionID == null ? 0 : lstShipDocItemReadingNew[l].SessionID; 
                                        //ShipDocItemReadingVal.OrderNo = lstShipDocItemReadingNew[l].OrderNo;
                                        //ShipDocItemReadingVal.UniqueID = lstShipDocItemReadingNew[l].UniqueID == null ? 0 : lstShipDocItemReadingNew[l].UniqueID; 

                                        JsonParamValue.ShipDocItemReadingList.Add(ShipDocItemReadingVal);

                                        var lstShipDocItemReadingDtlFiltered = lstShipDocItemReadingDtl.Where(item => item.ReadingID.Equals(lstShipDocItemReadingNew[l].ReadingID));

                                        List<ShipDocItemReadingDtl> lstShipDocItemReadingDtlNew = new List<ShipDocItemReadingDtl>();

                                        lstShipDocItemReadingDtlNew = lstShipDocItemReadingDtlFiltered.ToList();

                                        if (lstShipDocItemReadingDtlFiltered.Count() > 0)
                                        {
                                            for (var m = 0; m < lstShipDocItemReadingDtlFiltered.Count(); m++)
                                            {
                                                ShipDocItemReadingDtl ShipDocItemReadingDtlVal = new ShipDocItemReadingDtl();
                                                ShipDocItemReadingDtlVal.DtlID = lstShipDocItemReadingDtlNew[m].DtlID;
                                                ShipDocItemReadingDtlVal.ReadingID = lstShipDocItemReadingDtlNew[m].ReadingID;
                                                ShipDocItemReadingDtlVal.InSiteTankID = lstShipDocItemReadingDtlNew[m].InSiteTankID == null ? 0 : lstShipDocItemReadingDtlNew[m].InSiteTankID;
                                                ShipDocItemReadingDtlVal.CompartmentID = lstShipDocItemReadingDtlNew[m].CompartmentID == null ? 0 : lstShipDocItemReadingDtlNew[m].CompartmentID;
                                                ShipDocItemReadingDtlVal.PortFuelDepth_B = lstShipDocItemReadingDtlNew[m].PortFuelDepth_B == null ? -1 : lstShipDocItemReadingDtlNew[m].PortFuelDepth_B;
                                                ShipDocItemReadingDtlVal.PortFuelDepthNumerator_B = lstShipDocItemReadingDtlNew[m].PortFuelDepthNumerator_B == null ? -1 : lstShipDocItemReadingDtlNew[m].PortFuelDepthNumerator_B;
                                                ShipDocItemReadingDtlVal.MiddleFuelDepth_B = lstShipDocItemReadingDtlNew[m].MiddleFuelDepth_B == null ? -1 : lstShipDocItemReadingDtlNew[m].MiddleFuelDepth_B;
                                                ShipDocItemReadingDtlVal.MiddleFuelDepthNumerator_B = lstShipDocItemReadingDtlNew[m].MiddleFuelDepthNumerator_B == null ? -1 : lstShipDocItemReadingDtlNew[m].MiddleFuelDepthNumerator_B;
                                                ShipDocItemReadingDtlVal.SBoardFuelDepth_B = lstShipDocItemReadingDtlNew[m].SBoardFuelDepth_B == null ? -1 : lstShipDocItemReadingDtlNew[m].SBoardFuelDepth_B;
                                                ShipDocItemReadingDtlVal.SBoardFuelDepthNumerator_B = lstShipDocItemReadingDtlNew[m].SBoardFuelDepthNumerator_B == null ? -1 : lstShipDocItemReadingDtlNew[m].SBoardFuelDepthNumerator_B;
                                                ShipDocItemReadingDtlVal.PortFuelDepth_A = lstShipDocItemReadingDtlNew[m].PortFuelDepth_A == null ? -1 : lstShipDocItemReadingDtlNew[m].PortFuelDepth_A;
                                                ShipDocItemReadingDtlVal.PortFuelDepthNumerator_A = lstShipDocItemReadingDtlNew[m].PortFuelDepthNumerator_A == null ? -1 : lstShipDocItemReadingDtlNew[m].PortFuelDepthNumerator_A;
                                                ShipDocItemReadingDtlVal.MiddleFuelDepth_A = lstShipDocItemReadingDtlNew[m].MiddleFuelDepth_A == null ? -1 : lstShipDocItemReadingDtlNew[m].MiddleFuelDepth_A;
                                                ShipDocItemReadingDtlVal.MiddleFuelDepthNumerator_A = lstShipDocItemReadingDtlNew[m].MiddleFuelDepthNumerator_A == null ? -1 : lstShipDocItemReadingDtlNew[m].MiddleFuelDepthNumerator_A;
                                                ShipDocItemReadingDtlVal.SBoardFuelDepth_a = lstShipDocItemReadingDtlNew[m].SBoardFuelDepth_a == null ? -1 : lstShipDocItemReadingDtlNew[m].SBoardFuelDepth_a;
                                                ShipDocItemReadingDtlVal.SBoardFuelDepthNumerator_A = lstShipDocItemReadingDtlNew[m].SBoardFuelDepthNumerator_A == null ? -1 : lstShipDocItemReadingDtlNew[m].SBoardFuelDepthNumerator_A;
                                                ShipDocItemReadingDtlVal.Denominator = lstShipDocItemReadingDtlNew[m].Denominator == null ? 0 : lstShipDocItemReadingDtlNew[m].Denominator;
                                                ShipDocItemReadingDtlVal.MeterReading_B = lstShipDocItemReadingDtlNew[m].MeterReading_B == null ? -1 : lstShipDocItemReadingDtlNew[m].MeterReading_B;
                                                ShipDocItemReadingDtlVal.MeterReading_A = lstShipDocItemReadingDtlNew[m].MeterReading_A == null ? -1 : lstShipDocItemReadingDtlNew[m].MeterReading_A;
                                                ShipDocItemReadingDtlVal.CustomerID = lstShipDocItemReadingDtlNew[m].CustomerID;
                                                ShipDocItemReadingDtlVal.PortFeet_B = lstShipDocItemReadingDtlNew[m].PortFeet_B == null ? -1 : lstShipDocItemReadingDtlNew[m].PortFeet_B;
                                                ShipDocItemReadingDtlVal.MiddleFeet_B = lstShipDocItemReadingDtlNew[m].MiddleFeet_B == null ? -1 : lstShipDocItemReadingDtlNew[m].MiddleFeet_B;
                                                ShipDocItemReadingDtlVal.SBoardFeet_B = lstShipDocItemReadingDtlNew[m].SBoardFeet_B == null ? -1 : lstShipDocItemReadingDtlNew[m].SBoardFeet_B;
                                                ShipDocItemReadingDtlVal.PortFeet_A = lstShipDocItemReadingDtlNew[m].PortFeet_A == null ? -1 : lstShipDocItemReadingDtlNew[m].PortFeet_A;
                                                ShipDocItemReadingDtlVal.MiddleFeet_A = lstShipDocItemReadingDtlNew[m].MiddleFeet_A == null ? -1 : lstShipDocItemReadingDtlNew[m].MiddleFeet_A;
                                                ShipDocItemReadingDtlVal.SBoardFeet_A = lstShipDocItemReadingDtlNew[m].SBoardFeet_A == null ? -1 : lstShipDocItemReadingDtlNew[m].SBoardFeet_A;

                                                JsonParamValue.ShipDocItemReadingDtlList.Add(ShipDocItemReadingDtlVal);
                                            }
                                        }
                                    }
                                }

                                Shipments ShipmentList = new Shipments();
                                ShipmentList.ShipmentList = JsonParamValue;

                                var jsonperVal = jsonSerialiser.Serialize(ShipmentList);

                                string jsonIgnoreNullValues = JsonConvert.SerializeObject(ShipmentList, Formatting.None, new JsonSerializerSettings
                                {
                                    NullValueHandling = NullValueHandling.Ignore
                                });

                                // ParamList paramList = new ParamList();
                                // parameter paramVal = new parameter();
                                // paramVal.name = "JsonValue";
                                //// paramVal.param_type = "IN";
                                // paramVal.value = jsonperVal.ToString().Replace("\\\\", "");
                                // paramList.Params.Add(paramVal);

                                // Logging.WriteLog(jsonIgnoreNullValues, EventLogEntryType.Information);

                                parameterList paramList = new parameterList();
                                paramList.Params.Add(jsonIgnoreNullValues);

                                var jsonVal = jsonSerialiser.Serialize(paramList);
                                jsonVal = jsonVal.Replace("Params", "params");


                                // string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                                string url = ServiceURL.UpdateDeliveryDetailsURL + "&";
                                var request = (HttpWebRequest)HttpWebRequest.Create(url);
                                request.ContentType = "application/json; charset=utf-8";
                                request.Method = "POST";
                                request.Accept = "application/json; charset=utf-8";

                                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                                {
                                    streamWriter.Write(jsonVal);
                                    //streamWriter.Close();
                                }

                                var httpResponse = (HttpWebResponse)request.GetResponse();
                                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                                {
                                    var result = streamReader.ReadToEnd();
                                    List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                                    if (lsResult != null)
                                    {
                                        if (lsResult.Count > 0)
                                        {
                                            if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                            {

                                                string DeliveryNeedUpdateURL = ServiceURL.UpdateDeliveryDetailsNeedUpdateFlagURL + "(" + lstShipDocHdr[i].SysTrxNo + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                                                string DeliveryNeedUpdateResult = new WebClient().DownloadString(DeliveryNeedUpdateURL);

                                                string DeliveryDetailsLineUpdateURL = ServiceURL.UpdateDeliveryDetailsLineUpdateFlagURL + "(" + lstShipDocHdr[i].DocNo + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                                string DeliveryDetailsLineUpdateResult = new WebClient().DownloadString(DeliveryDetailsLineUpdateURL);

                                                if (lstShipDocItemReading.Count > 0)
                                                {
                                                    string DeliveryReadingNeedUpdateURL = ServiceURL.UpdateDeliveryReadingDetailsNeedUpdateFlagURL + "(" + lstShipDocHdr[i].SysTrxNo + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                                                    string DeliveryReadingNeedUpdateResult = new WebClient().DownloadString(DeliveryReadingNeedUpdateURL);
                                                }
                                            }
                                            else
                                            {
                                                Logging.WriteLog("Error in UpdateDeliveryDetails - SysTrxNo - " + lstShipDocHdr[i].SysTrxNo + ", Reason - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);

                                                string urlTemp = ServiceURL.UpdateDeliveryDetailsReviewURL + "&";
                                                var requestTemp = (HttpWebRequest)HttpWebRequest.Create(urlTemp);
                                                requestTemp.ContentType = "application/json; charset=utf-8";
                                                requestTemp.Method = "POST";
                                                requestTemp.Accept = "application/json; charset=utf-8";

                                                using (var streamWriterTemp = new StreamWriter(requestTemp.GetRequestStream()))
                                                {
                                                    streamWriterTemp.Write(jsonVal);
                                                }

                                                var httpResponseTemp = (HttpWebResponse)requestTemp.GetResponse();
                                                using (var streamReaderTemp = new StreamReader(httpResponseTemp.GetResponseStream()))
                                                {
                                                    var resultTemp = streamReaderTemp.ReadToEnd();
                                                    List<Results> lsResultTemp = JsonConvert.DeserializeObject<List<Results>>(resultTemp);
                                                    if (lsResultTemp != null)
                                                    {
                                                        if (lsResultTemp.Count > 0)
                                                        {
                                                            if (lsResultTemp[0].StatusNew.ToString().ToLower() == "success")
                                                            {
                                                                string DeliveryDetailsNeedUpdateURL = ServiceURL.UpdateDeliveryDetailsNeedUpdateFlagURL + "(" + lstShipDocHdr[i].SysTrxNo + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                                                                string DeliveryDetailsNeedUpdateResult = new WebClient().DownloadString(DeliveryDetailsNeedUpdateURL);
                                                            }
                                                            else
                                                            {
                                                                Logging.WriteLog("Error in UpdateDeliveryReview - SysTrxNo - " + lstShipDocHdr[i].SysTrxNo + ", Reason - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                                                string UpdateDeliveryRetryCountURL = ServiceURL.UpdateDeliveryRetryCount + "(" + lstShipDocHdr[i].SysTrxNo + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                                                                string UpdateDeliveryRetryCountResult = new WebClient().DownloadString(UpdateDeliveryRetryCountURL);
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Logging.WriteLog(string.Format("Error in UpdateDeliveryDetails -OrderNO - {0} , ErrorMessage - {1} ", lstShipDocHdr[i].DocNo, "ShipDocItem and OrderItem are having mismatching number of rows"), EventLogEntryType.Error);
                                string UpdateDeliveryRetryCountURL = ServiceURL.UpdateDeliveryRetryCount + "(" + lstShipDocHdr[i].SysTrxNo + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                                string UpdateDeliveryRetryCountResult = new WebClient().DownloadString(UpdateDeliveryRetryCountURL);
                            }
                        }
                        catch (System.Data.SqlClient.SqlException sqlEx)
                        {
                            Logging.WriteLog(string.Format("Error in UpdateDeliveryDetails -OrderNO - {0} , ErrorMessage - {1} ", lstShipDocHdr[i].DocNo, sqlEx.Message.ToString()), EventLogEntryType.Error);
                            string UpdateDeliveryRetryCountURL = ServiceURL.UpdateDeliveryRetryCount + "(" + lstShipDocHdr[i].SysTrxNo + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                            string UpdateDeliveryRetryCountResult = new WebClient().DownloadString(UpdateDeliveryRetryCountURL);
                        }
                        catch (Exception ex)
                        {
                            Logging.WriteLog(string.Format("Error in UpdateDeliveryDetails -OrderNO - {0} , ErrorMessage - {1} ", lstShipDocHdr[i].DocNo, ex.Message.ToString()), EventLogEntryType.Error);
                            //string UpdateDeliveryRetryCountURL = ServiceURL.UpdateDeliveryRetryCount + "(" + lstShipDocHdr[i].SysTrxNo + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                            //string UpdateDeliveryRetryCountResult = new WebClient().DownloadString(UpdateDeliveryRetryCountURL);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateDeliveryDetails - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        /// <summary>
        /// UpdateOrdersToCloud
        /// Function to update Orders to Cloud
        /// </summary>
        public static void UpdateOrdersToCloud()
        {
            try
            {
                const int invoicedOrderStatusID = 1007;
                /* Get OrderHdr to update in ascend */
                string GetOrderHdr = new WebClient().DownloadString(ServiceURL.GetClientOrderHdrURL);
                List<OrderHdr> lstOrderHdr = JsonConvert.DeserializeObject<List<OrderHdr>>(GetOrderHdr);

                /* Get OrderItems to update in ascend */
                string GetOrderItems = new WebClient().DownloadString(ServiceURL.GetClientOrderItemURL);
                List<OrderItem> lstOrderItems = JsonConvert.DeserializeObject<List<OrderItem>>(GetOrderItems);

                /* Get OrderItemComponent to update in ascend */
                string GetOrderItemComp = new WebClient().DownloadString(ServiceURL.GetClientOrderItemComponentURL);
                List<OrderItemComponent> lstOrderItemComp = JsonConvert.DeserializeObject<List<OrderItemComponent>>(GetOrderItemComp);

                //string GetOrderNotes = new WebClient().DownloadString(ServiceURL.GetClientOrderNoteURL);
                //List<OrderNote> lstOrderNotes = JsonConvert.DeserializeObject<List<OrderNote>>(GetOrderNotes);

                Logging.WriteLog("Function Called UpdateOrdersToCloud - Count " + lstOrderHdr.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };

                if (lstOrderHdr.Count > 0)
                {
                    for (var i = 0; i < lstOrderHdr.Count; i++)
                    {
                        try
                        {
                            int orderStatusID = 0;
                            OrderJSONParam JsonParamValue = new OrderJSONParam();

                            OrderHdr OrdHdr = new OrderHdr();
                            OrdHdr.SysTrxNo = lstOrderHdr[i].SysTrxNo;
                            OrdHdr.CompanyID = lstOrderHdr[i].CompanyID;
                            OrdHdr.OrderNo = lstOrderHdr[i].OrderNo;
                            OrdHdr.PONo = !string.IsNullOrEmpty(lstOrderHdr[i].PONo) ? lstOrderHdr[i].PONo.EncodeString() : null;
                            OrdHdr.DefCarrierID = lstOrderHdr[i].DefCarrierID == null ? 0 : lstOrderHdr[i].DefCarrierID;
                            OrdHdr.OrderDtTm = lstOrderHdr[i].OrderDtTm == null ? "Jan  1 1900 12:00:00:000AM" : lstOrderHdr[i].OrderDtTm;
                            OrdHdr.DefRequestedDtTm = lstOrderHdr[i].DefRequestedDtTm == null ? "Jan  1 1900 12:00:00:000AM" : lstOrderHdr[i].DefRequestedDtTm;
                            OrdHdr.DefPromisedDtTm = lstOrderHdr[i].DefPromisedDtTm == null ? "Jan  1 1900 12:00:00:000AM" : lstOrderHdr[i].DefPromisedDtTm;
                            //OrdHdr.OrderDtTm = null;
                            OrdHdr.DtTm = lstOrderHdr[i].DtTm == null ? "Jan  1 1900 12:00:00:000AM" : lstOrderHdr[i].DtTm;
                            //OrdHdr.DtTm = null;

                            OrdHdr.UserID = lstOrderHdr[i].UserID;
                            OrdHdr.Status = lstOrderHdr[i].Status;
                            OrdHdr.ToSiteID = lstOrderHdr[i].ToSiteID;
                            OrdHdr.OrderType = lstOrderHdr[i].OrderType;
                            OrdHdr.LoadNo = lstOrderHdr[i].LoadNo;
                            OrdHdr.LastStatusDate = lstOrderHdr[i].LastStatusDate == null ? "Jan  1 1900 12:00:00:000AM" : lstOrderHdr[i].LastStatusDate;
                            //OrdHdr.LastStatusDate = null;
                            OrdHdr.InternalTransferOrder = lstOrderHdr[i].InternalTransferOrder;
                            OrdHdr.CustomerID = lstOrderHdr[i].CustomerID;
                            OrdHdr.ShipToVesselID = lstOrderHdr[i].ShipToVesselID == null ? 0 : lstOrderHdr[i].ShipToVesselID;
                            OrdHdr.AuxiliaryVesselID = lstOrderHdr[i].AuxiliaryVesselID == null ? 0 : lstOrderHdr[i].AuxiliaryVesselID;
                            OrdHdr.AuxiliaryVesselCount = lstOrderHdr[i].AuxiliaryVesselCount == null ? 0 : lstOrderHdr[i].AuxiliaryVesselCount;
                            OrdHdr.MarineLocID = lstOrderHdr[i].MarineLocID == null ? 0 : lstOrderHdr[i].MarineLocID;
                            OrdHdr.MarineLocDescr = lstOrderHdr[i].MarineLocDescr == null ? "" : lstOrderHdr[i].MarineLocDescr.EncodeString();
                            OrdHdr.FreightIN = lstOrderHdr[i].FreightIN;
                            OrdHdr.FreightOUT = lstOrderHdr[i].FreightOUT;
                            OrdHdr.MarineSessionID = lstOrderHdr[i].MarineSessionID == null ? 0 : lstOrderHdr[i].MarineSessionID;
                            //OrdHdr.DefDriverID = lstOrderHdr[i].DefDriverID == null ? 0 : lstOrderHdr[i].DefDriverID;
                            OrdHdr.DefVehicleID = lstOrderHdr[i].DefVehicleID == null ? 0 : lstOrderHdr[i].DefVehicleID;
                            OrdHdr.ClientID = lstOrderHdr[i].ClientID;
                            OrdHdr.ReceivingContact = lstOrderHdr[i].ReceivingContact;
                            OrdHdr.ReceivingContactID = lstOrderHdr[i].ReceivingContactID;
                            OrdHdr.LastModifiedUser = lstOrderHdr[i].LastModifiedUser;
                            OrdHdr.Contracts = lstOrderHdr[i].Contracts;
                            orderStatusID = lstOrderHdr[i].OrderStatusID <= 0 ? 0 : lstOrderHdr[i].OrderStatusID;

                            JsonParamValue.OrderHdrList.Add(OrdHdr);

                            var lstOrderItemsFiltered = lstOrderItems.Where(item => item.SysTrxNo.Equals(lstOrderHdr[i].SysTrxNo));
                            List<OrderItem> lstOrderItemsNew = new List<OrderItem>();

                            lstOrderItemsNew = lstOrderItemsFiltered.ToList();

                            if (lstOrderItemsFiltered.Count() > 0)
                            {
                                for (var j = 0; j < lstOrderItemsFiltered.Count(); j++)
                                {
                                    OrderItem OrdItem = new OrderItem();
                                    OrdItem.SysTrxNo = lstOrderItemsNew[j].SysTrxNo;
                                    OrdItem.SysTrxLine = lstOrderItemsNew[j].SysTrxLine;
                                    OrdItem.MasterProdID = lstOrderItemsNew[j].MasterProdID;
                                    OrdItem.MasterSiteID = lstOrderItemsNew[j].MasterSiteID;
                                    OrdItem.Qty = lstOrderItemsNew[j].Qty;
                                    OrdItem.Priority = lstOrderItemsNew[j].Priority;
                                    OrdItem.Status = lstOrderItemsNew[j].Status;
                                    OrdItem.DtTm = lstOrderItemsNew[j].DtTm == null ? "Jan  1 1900 12:00:00:000AM" : lstOrderItemsNew[j].DtTm;
                                    //OrdItem.DtTm = null;
                                    OrdItem.UnitPrice = lstOrderItemsNew[j].UnitPrice == null ? 0 : lstOrderItemsNew[j].UnitPrice;
                                    OrdItem.UnitPriceKeyed = lstOrderItemsNew[j].UnitPriceKeyed == null ? 0 : lstOrderItemsNew[j].UnitPriceKeyed;
                                    OrdItem.RequestedDtTm = lstOrderItemsNew[j].RequestedDtTm == null ? "Jan  1 1900 12:00:00:000AM" : lstOrderItemsNew[j].RequestedDtTm;
                                    //OrdItem.RequestedDtTm = null;
                                    OrdItem.PromisedDtTm = lstOrderItemsNew[j].PromisedDtTm == null ? "Jan  1 1900 12:00:00:000AM" : lstOrderItemsNew[j].PromisedDtTm;
                                    //OrdItem.PromisedDtTm = null;
                                    OrdItem.Notes = !string.IsNullOrEmpty(lstOrderItemsNew[j].Notes) ? lstOrderItemsNew[j].Notes.EncodeString() : null;
                                    OrdItem.CustomerID = lstOrderItemsNew[j].CustomerID;
                                    OrdItem.ShipToTankID = lstOrderItemsNew[j].ShipToTankID == null ? 0 : lstOrderItemsNew[j].ShipToTankID;
                                    OrdItem.AdditionalCost = lstOrderItemsNew[j].AdditionalCost == null ? 0 : lstOrderItemsNew[j].AdditionalCost;
                                    OrdItem.RackPriceKeyed = lstOrderItemsNew[j].RackPriceKeyed == null ? 0 : lstOrderItemsNew[j].RackPriceKeyed;
                                    OrdItem.ARShipToTankID = lstOrderItemsNew[j].ARShipToTankID == null ? 0 : lstOrderItemsNew[j].ARShipToTankID;
                                    OrdItem.ClientID = lstOrderItemsNew[j].ClientID;
                                    OrdItem.PONo = !string.IsNullOrEmpty(lstOrderItemsNew[j].PONo) ? lstOrderItemsNew[j].PONo.EncodeString() : null;
                                    OrdItem.BillToShiptoID = lstOrderItemsNew[j].BillToShiptoID;
                                    OrdItem.VendorProductxRef = lstOrderItemsNew[j].VendorProductxRef;
                                    JsonParamValue.OrderItemList.Add(OrdItem);
                                }
                            }

                            var lstOrderItemCompFiltered = lstOrderItemComp.Where(item => item.SysTrxNo.Equals(lstOrderHdr[i].SysTrxNo));
                            List<OrderItemComponent> lstOrderItemCompNew = new List<OrderItemComponent>();

                            lstOrderItemCompNew = lstOrderItemCompFiltered.ToList();
                            if (lstOrderItemCompFiltered.Count() > 0)
                            {
                                for (var k = 0; k < lstOrderItemCompFiltered.Count(); k++)
                                {
                                    OrderItemComponent OrdItemComp = new OrderItemComponent();
                                    OrdItemComp.SysTrxNo = lstOrderItemCompNew[k].SysTrxNo;
                                    OrdItemComp.SysTrxLine = lstOrderItemCompNew[k].SysTrxLine;
                                    OrdItemComp.ComponentNo = lstOrderItemCompNew[k].ComponentNo;
                                    OrdItemComp.MasterProdID = lstOrderItemCompNew[k].MasterProdID;
                                    OrdItemComp.MasterSiteID = lstOrderItemCompNew[k].MasterSiteID;
                                    OrdItemComp.Qty = lstOrderItemCompNew[k].Qty;
                                    OrdItemComp.UnitCost = lstOrderItemCompNew[k].UnitCost == null ? 0 : lstOrderItemComp[k].UnitCost;
                                    OrdItemComp.CustomerID = lstOrderItemCompNew[k].CustomerID;
                                    OrdItemComp.RackPrice = lstOrderItemCompNew[k].RackPrice == null ? 0 : lstOrderItemComp[k].RackPrice;
                                    OrdItemComp.RackPriceKeyed = lstOrderItemCompNew[k].RackPriceKeyed == null ? 0 : lstOrderItemComp[k].RackPriceKeyed;
                                    OrdItemComp.FromCsTankFuelHistoryID = lstOrderItemCompNew[k].FromCsTankFuelHistoryID;
                                    OrdItemComp.ToCsTankFuelHistoryID = lstOrderItemCompNew[k].ToCsTankFuelHistoryID;
                                    OrdItemComp.ClientID = lstOrderItemCompNew[k].ClientID;

                                    JsonParamValue.OrderItemComponentList.Add(OrdItemComp);
                                }
                            }


                            // New code added for Order Note
                            //var lstOrderNoteFiltered = lstOrderNotes.Where(item => item.SysTrxNo.Equals(lstOrderHdr[i].SysTrxNo));
                            //List<OrderNote> lstOrderNotesNew = new List<OrderNote>();

                            //lstOrderNotesNew = lstOrderNoteFiltered.ToList();

                            //if (lstOrderNoteFiltered.Count() > 0)
                            //{
                            //    for (var j = 0; j < lstOrderNoteFiltered.Count(); j++)
                            //    {
                            //        OrderNote OrdNote = new OrderNote();
                            //        OrdNote.SysTrxNo = lstOrderNotesNew[j].SysTrxNo;
                            //        OrdNote.NoteNo = lstOrderNotesNew[j].NoteNo;
                            //        OrdNote.NoteTypeID = lstOrderNotesNew[j].NoteTypeID;
                            //        OrdNote.Note = lstOrderNotesNew[j].Note;
                            //        OrdNote.PrintOn = lstOrderNotesNew[j].PrintOn;
                            //        OrdNote.ClientID = lstOrderNotesNew[j].ClientID;
                            //        JsonParamValue.OrderNoteList.Add(OrdNote);
                            //    }
                            //}
                            // Order Note Ends Here


                            Orders OrderList = new Orders();
                            OrderList.OrderList = JsonParamValue;

                            //var jsonperVal = jsonSerialiser.Serialize(OrderList);
                            string jsonIgnoreNullValues = JsonConvert.SerializeObject(OrderList, Formatting.None, new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });

                            // ParamList paramList = new ParamList();
                            // parameter paramVal = new parameter();
                            // paramVal.name = "JsonValue";
                            //// paramVal.param_type = "IN";
                            // paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");



                            // paramList.Params.Add(paramVal);

                            parameterList paramList = new parameterList();
                            paramList.Params.Add(jsonIgnoreNullValues);

                            var jsonVal = jsonSerialiser.Serialize(paramList);
                            jsonVal = jsonVal.Replace("Params", "params");


                            string url = ServiceURL.UpdateClientOrderDetailsURL + "&";
                            var request = (HttpWebRequest)HttpWebRequest.Create(url);
                            request.ContentType = "application/json; charset=utf-8";
                            request.Method = "POST";
                            request.Accept = "application/json; charset=utf-8";

                            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                            {
                                streamWriter.Write(jsonVal);
                                //streamWriter.Close();
                            }

                            var httpResponse = (HttpWebResponse)request.GetResponse();
                            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                            {
                                var result = streamReader.ReadToEnd();
                                List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                                if (lsResult != null)
                                {
                                    if (lsResult.Count > 0)
                                    {
                                        if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                        {
                                            string LoadStatusUpdateURL = "";
                                            string LoadStatusUpdateResult = string.Empty;
                                            if (lstOrderHdr[i].Status == 'Z' && orderStatusID != invoicedOrderStatusID)
                                            {
                                                LoadStatusUpdateURL = ServiceURL.UpdateLoadStatusURL + "(" + lstOrderHdr[i].SysTrxNo + ",O)?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                                LoadStatusUpdateResult = new WebClient().DownloadString(LoadStatusUpdateURL);

                                                LoadStatusUpdateURL = ServiceURL.UpdateLoadStatusURL + "(" + lstOrderHdr[i].SysTrxNo + ",Z)?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                                LoadStatusUpdateResult = new WebClient().DownloadString(LoadStatusUpdateURL);
                                            }
                                            else if (lstOrderHdr[i].Status != 'Z')
                                            {
                                                LoadStatusUpdateURL = ServiceURL.UpdateLoadStatusURL + "(" + lstOrderHdr[i].SysTrxNo + ",I)?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                                LoadStatusUpdateResult = new WebClient().DownloadString(LoadStatusUpdateURL);
                                            }
                                            else if (lstOrderHdr[i].Status == 'Z')
                                            {
                                                LoadStatusUpdateURL = ServiceURL.UpdateLoadStatusURL + "(" + lstOrderHdr[i].SysTrxNo + ",Z)?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                                LoadStatusUpdateResult = new WebClient().DownloadString(LoadStatusUpdateURL);
                                            }


                                        }
                                        else
                                        {
                                            Logging.WriteLog("Error in UpdateOrdersToCloud - OrderNo - " + lstOrderHdr[i].OrderNo + ", Reason - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Logging.WriteLog("Error in UpdateOrdersToCloud - " + ex.Message.ToString(), EventLogEntryType.Error);
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateOrdersToCloud - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }


        /// <summary>
        /// UpdateOrderStatus
        /// Function to update Order Status
        /// </summary>
        public static void UpdateOrderStatus(char docType)
        {
            try
            {

                string json = new WebClient().DownloadString(string.Format("{0}({1})?{2}", ServiceURL.GetOrderStatusHistoryURL, docType, ConfigurationManager.AppSettings["CloudAPIKEY"].ToString()));
                //JArray results = JArray.Parse(json);
                List<OrderStatusHistory> lstOrderStatusHistory = JsonConvert.DeserializeObject<List<OrderStatusHistory>>(json);
                Logging.WriteLog("Function Called UpdateOrderStatus - Count " + lstOrderStatusHistory.Count.ToString(), EventLogEntryType.Error);

                if (lstOrderStatusHistory.Count > 0)
                {
                    for (var i = 0; i < lstOrderStatusHistory.Count; i++)
                    {
                        //Logging.WriteLog("Function Called UpdateOrderStatus LoadNo - " + lstOrderStatusHistory[i].LoadNo.ToString() + ", OrderStatusID - " + lstOrderStatusHistory[i].OrderStatusID + ", SysTrxNo - " + lstOrderStatusHistory[i].SysTrxNo.ToString(), EventLogEntryType.Error);
                        try
                        {
                            string LoadStatusUpdateURL = ServiceURL.UpdateLoadStatusURL + "(" + lstOrderStatusHistory[i].SysTrxNo + "," + lstOrderStatusHistory[i].OrderStatusID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                            string LoadStatusUpdateResult = new WebClient().DownloadString(LoadStatusUpdateURL);

                            string OrderStatusNeedUpdateURL = ServiceURL.UpdateOrderStatusHistoryNeedUpdateFlagURL + "(" + lstOrderStatusHistory[i].SysTrxNo + "," + lstOrderStatusHistory[i].OrderStatusID + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                            string OrderStatusNeedUpdateResult = new WebClient().DownloadString(OrderStatusNeedUpdateURL);
                        }
                        catch (Exception ex)
                        {
                            Logging.WriteLog("Error in UpdateOrderStatus - " + ex.Message.ToString(), EventLogEntryType.Error);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateOrderStatus - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        /// <summary>
        /// UpdateMeterTicket
        /// Function to update MeterTicket
        /// </summary>
        public static void UpdateMeterTicket()
        {
            try
            {
                string GetMeterTicket = new WebClient().DownloadString(ServiceURL.GetMeterTicket);
                List<MeterTicket> lstMeterTicket = JsonConvert.DeserializeObject<List<MeterTicket>>(GetMeterTicket);
                Logging.WriteLog("Function Called UpdateMeterTicket - Count " + lstMeterTicket.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };

                if (lstMeterTicket.Count > 0)
                {
                    for (int i = 0; i < lstMeterTicket.Count; i++)
                    {
                        MeterTicketJSONParam JsonParamValue = new MeterTicketJSONParam();
                        MeterTicketUpdate MeterTicket_Update = new MeterTicketUpdate();
                        MeterTicket MeterTicketGet = new MeterTicket();

                        MeterTicketGet.ID = lstMeterTicket[i].ID;

                        MeterTicketGet.FileName = lstMeterTicket[i].FileName;

                        MeterTicketGet.OrderNo = lstMeterTicket[i].OrderNo;
                        MeterTicketGet.SysTrxNo = lstMeterTicket[i].SysTrxNo;
                        MeterTicketGet.SysTrxLineNo = lstMeterTicket[i].SysTrxLineNo;
                        MeterTicketGet.CreatedDate = lstMeterTicket[i].CreatedDate;
                        MeterTicketGet.DeviceTime = lstMeterTicket[i].DeviceTime;
                        MeterTicketGet.MeterImage = lstMeterTicket[i].MeterImage;
                        MeterTicketGet.CustomerID = lstMeterTicket[i].CustomerID;
                        MeterTicketGet.NeedUpdate = lstMeterTicket[i].NeedUpdate;
                        MeterTicketGet.CompanyID = lstMeterTicket[i].CompanyID;

                        MeterTicketGet.Quantity = lstMeterTicket[i].Quantity;
                        MeterTicketGet.StartMeter = lstMeterTicket[i].StartMeter;
                        MeterTicketGet.EndMeter = lstMeterTicket[i].EndMeter;
                        MeterTicketGet.Vessel = lstMeterTicket[i].Vessel.EncodeString();



                        Logging.WriteLog("MeterTicket - " + lstMeterTicket[i].FileName, EventLogEntryType.Information);

                        MeterTicket_Update.MeterTicketUpdateList.Add(MeterTicketGet);
                        JsonParamValue.MeterTicketGetToUpdate = MeterTicket_Update;

                        string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                        });

                        ParamList paramList = new ParamList();
                        parameter paramVal = new parameter();
                        paramVal.name = "JsonValue";
                        //paramVal.param_type = "IN";
                        paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");

                        paramList.Params.Add(paramVal);

                        var jsonVal = jsonSerialiser.Serialize(paramList);
                        jsonVal = jsonVal.Replace("Params", "params");


                        string url = ServiceURL.UpdateMeterTicket + "&";
                        var request = (HttpWebRequest)HttpWebRequest.Create(url);
                        request.ContentType = "application/json; charset=utf-8";
                        request.Method = "POST";
                        request.Accept = "application/json; charset=utf-8";


                        using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                        {
                            streamWriter.Write(jsonVal);
                        }
                        var httpResponse = (HttpWebResponse)request.GetResponse();

                        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                        {
                            var result = streamReader.ReadToEnd();
                            List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                            if (lsResult != null)
                            {
                                if (lsResult.Count > 0)
                                {
                                    if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                    {
                                        string MeterTicketNeedUpdateMarineURL = ServiceURL.UpdateNeedUpdateMeterTicket + "(" + lstMeterTicket[i].ID + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                                        string MeterTicketSyncUpdateResult = new WebClient().DownloadString(MeterTicketNeedUpdateMarineURL);

                                    }
                                    else
                                    {
                                        Logging.WriteLog("Error in UpdateNeedUpdateMeterTicket - ID - " + lstMeterTicket[i].ID + ", Reason - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                    }
                                }
                            }
                        }
                    }

                }
            }
            catch (WebException e)
            {
                string pageContent = new StreamReader(e.Response.GetResponseStream()).ReadToEnd().ToString();

            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateMeterTicket - " + ex.Message.ToString(), EventLogEntryType.Error);

            }

        }

        /// <summary>
        /// UpdateDOI
        /// Function to update DOI
        /// </summary>
        public static void UpdateDOI()
        {
            try
            {
                string GetDOIUpdate = new WebClient().DownloadString(ServiceURL.GetDOIURL);
                List<DOIGetToUpdate> lstDOIGetToUpdate = JsonConvert.DeserializeObject<List<DOIGetToUpdate>>(GetDOIUpdate);
                Logging.WriteLog("Function Called UpdateDOI - Count " + lstDOIGetToUpdate.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };


                if (lstDOIGetToUpdate.Count > 0)
                {
                    for (int i = 0; i < lstDOIGetToUpdate.Count; i++)
                    {
                        DOIUpdateJSONParam JsonParamValue = new DOIUpdateJSONParam();
                        DOIGetToUpdate DOIGet = new DOIGetToUpdate();
                        DOIUpdate Doiupdate = new DOIUpdate();
                        DOIGet.ID = lstDOIGetToUpdate[i].ID;
                        DOIGet.OrderNO = lstDOIGetToUpdate[i].OrderNO;
                        DOIGet.OrderItemID = lstDOIGetToUpdate[i].OrderItemID;
                        DOIGet.DOIImage = lstDOIGetToUpdate[i].DOIImage;
                        DOIGet.UserID = lstDOIGetToUpdate[i].UserID;
                        DOIGet.DOIType = lstDOIGetToUpdate[i].DOIType;
                        DOIGet.FileName = lstDOIGetToUpdate[i].FileName;
                        DOIGet.NeedUpdate = lstDOIGetToUpdate[i].NeedUpdate;
                        DOIGet.CompanyID = lstDOIGetToUpdate[i].CompanyID;
                        Doiupdate.DOIUpdateList.Add(DOIGet);

                        JsonParamValue.DOIGetToUpdate = Doiupdate;

                        string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                        });

                        ParamList paramList = new ParamList();
                        parameter paramVal = new parameter();
                        paramVal.name = "JsonValue";
                        //  paramVal.param_type = "IN";
                        paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");

                        paramList.Params.Add(paramVal);

                        var jsonVal = jsonSerialiser.Serialize(paramList);
                        jsonVal = jsonVal.Replace("Params", "params");


                        string url = ServiceURL.UpdateDOIURL + "&";
                        var request = (HttpWebRequest)HttpWebRequest.Create(url);
                        request.ContentType = "application/json; charset=utf-8";
                        request.Method = "POST";
                        request.Accept = "application/json; charset=utf-8";

                        using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                        {
                            streamWriter.Write(jsonVal);
                        }
                        var httpResponse = (HttpWebResponse)request.GetResponse();

                        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                        {
                            var result = streamReader.ReadToEnd();
                            List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                            if (lsResult != null)
                            {
                                if (lsResult.Count > 0)
                                {
                                    if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                    {

                                        string DOINeedUpdateMarineURL = ServiceURL.UpdateNeedUpdateDOI + "(" + lstDOIGetToUpdate[i].ID + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                                        string TankChartSyncUpdateResult = new WebClient().DownloadString(DOINeedUpdateMarineURL);

                                    }
                                    else
                                    {
                                        Logging.WriteLog("Error in UpdateNeedUpdateDOI - ID - " + lstDOIGetToUpdate[i].ID + ", Reason - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                    }
                                }
                            }
                        }
                    }

                }
            }
            catch (WebException webex)
            {
                WebResponse errResp = webex.Response;
                using (Stream respStream = errResp.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(respStream);
                    string text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateDOI - " + ex.Message.ToString(), EventLogEntryType.Error);

            }

        }

        public static void UpdateDocMessage()
        {
            try
            {
                string GetDcoMessage = new WebClient().DownloadString(ServiceURL.GetDcoMessage);
                List<DocMessage> lstDocMessage = JsonConvert.DeserializeObject<List<DocMessage>>(GetDcoMessage);
                Logging.WriteLog("Function Called UpdateCompany - Count " + lstDocMessage.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstDocMessage.Count > 0)
                {
                    DocMessageJSONParam JsonParamValue = new DocMessageJSONParam();
                    DocMessageUpdate DocMsgUpdate = new DocMessageUpdate();
                    for (var i = 0; i < lstDocMessage.Count; i++)
                    {
                        DocMessage DocMsg = new DocMessage();
                        DocMsg.DocMessageID = lstDocMessage[i].DocMessageID;
                        DocMsg.MessageCode = lstDocMessage[i].MessageCode;
                        DocMsg.MessageType = lstDocMessage[i].MessageType;
                        DocMsg.DocType = lstDocMessage[i].DocType;
                        DocMsg.DocFormatID = lstDocMessage[i].DocFormatID == null ? 0 : lstDocMessage[i].DocFormatID;
                        DocMsg.DXExportFormatID = lstDocMessage[i].DXExportFormatID == null ? 0 : lstDocMessage[i].DXExportFormatID;
                        DocMsg.CompanyID = lstDocMessage[i].CompanyID;
                        DocMsg.MessageDescr1 = lstDocMessage[i].MessageDescr1 == null ? lstDocMessage[i].MessageDescr1 : lstDocMessage[i].MessageDescr1.Trim();
                        DocMsg.MessageDescr2 = lstDocMessage[i].MessageDescr2 == null ? lstDocMessage[i].MessageDescr2 : lstDocMessage[i].MessageDescr2.Trim();
                        DocMsg.MessageDescr3 = lstDocMessage[i].MessageDescr3 == null ? lstDocMessage[i].MessageDescr3 : lstDocMessage[i].MessageDescr3.Trim();
                        DocMsg.MessageDescr4 = lstDocMessage[i].MessageDescr4 == null ? lstDocMessage[i].MessageDescr4 : lstDocMessage[i].MessageDescr4.Trim();
                        DocMsg.ClientID = lstDocMessage[i].ClientID;
                        DocMsg.LastModifiedUser = lstDocMessage[i].LastModifiedUser;
                        DocMsg.LastModifiedDtTm = lstDocMessage[i].LastModifiedDtTm;
                        DocMsg.UQDocFormatID = lstDocMessage[i].UQDocFormatID;
                        DocMsgUpdate.DocMessageUpdateList.Add(DocMsg);


                    }
                    JsonParamValue.DocMessageGetToUpdate = DocMsgUpdate;
                    var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    ParamList paramList = new ParamList();
                    parameter paramVal = new parameter();
                    paramVal.name = "JsonValue";
                    // paramVal.param_type = "IN";
                    paramVal.value = jsonperVal.ToString().Replace("\\\\", "");
                    paramList.Params.Add(paramVal);


                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");


                    string url = ServiceURL.UpdateDocMessage + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateDocMessage - " + ex.Message.ToString(), EventLogEntryType.Error);

            }
        }

        public static void UpdateDeliveryTicket()
        {
            try
            {
                string GetDeliveryTicket = new WebClient().DownloadString(ServiceURL.GetDeliveryTicket);
                List<DeliveryTicket> lstDeliveryTicket = JsonConvert.DeserializeObject<List<DeliveryTicket>>(GetDeliveryTicket);
                Logging.WriteLog("Function Called UpdateDeliveryTicket - Count " + lstDeliveryTicket.Count.ToString(), EventLogEntryType.Error);
                //var jsonSerialiser = new JavaScriptSerializer();
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };

                if (lstDeliveryTicket.Count > 0)
                {
                    for (int i = 0; i < lstDeliveryTicket.Count; i++)
                    {
                        DeliveryTicketJSONParam JsonParamValue = new DeliveryTicketJSONParam();
                        DeliveryTicketUpdate DeliveryTicket_Update = new DeliveryTicketUpdate();
                        DeliveryTicket DeliveryTicketGet = new DeliveryTicket();
                        DeliveryTicketGet.ID = lstDeliveryTicket[i].ID;
                        DeliveryTicketGet.OrderNo = lstDeliveryTicket[i].OrderNo;
                        DeliveryTicketGet.DeviceTime = lstDeliveryTicket[i].DeviceTime;
                        DeliveryTicketGet.DeliveryImage = lstDeliveryTicket[i].DeliveryImage;
                        DeliveryTicketGet.CreatedDate = lstDeliveryTicket[i].CreatedDate;
                        DeliveryTicketGet.NeedUpdate = lstDeliveryTicket[i].NeedUpdate;
                        DeliveryTicketGet.FileName = lstDeliveryTicket[i].FileName;
                        DeliveryTicketGet.CustomerID = lstDeliveryTicket[i].CustomerID;
                        DeliveryTicketGet.CompanyID = lstDeliveryTicket[i].CompanyID;
                        DeliveryTicket_Update.DeliveryTicketUpdateList.Add(DeliveryTicketGet);
                        JsonParamValue.DeliveryTicketGetToUpdate = DeliveryTicket_Update;

                        string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                        });

                        ParamList paramList = new ParamList();
                        parameter paramVal = new parameter();

                        paramVal.name = "JsonValue";
                        // paramVal.param_type = "IN";
                        paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");
                        paramList.Params.Add(paramVal);

                        var jsonVal = jsonSerialiser.Serialize(paramList);
                        jsonVal = jsonVal.Replace("Params", "params");


                        string url = ServiceURL.UpdateDeliveryTicket + "&";
                        var request = (HttpWebRequest)HttpWebRequest.Create(url);
                        request.ContentType = "application/json; charset=utf-8";
                        request.Method = "POST";
                        request.Accept = "application/json; charset=utf-8";


                        using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                        {
                            streamWriter.Write(jsonVal);
                        }
                        var httpResponse = (HttpWebResponse)request.GetResponse();

                        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                        {
                            var result = streamReader.ReadToEnd();
                            List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                            if (lsResult != null)
                            {
                                if (lsResult.Count > 0)
                                {
                                    if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                    {


                                        string DeliveryTicketNeedUpdateMarineURL = ServiceURL.UpdateNeedUpdateDeliveryTicket + "(" + lstDeliveryTicket[i].ID + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                                        string TankChartSyncUpdateResult = new WebClient().DownloadString(DeliveryTicketNeedUpdateMarineURL);

                                    }
                                    else
                                    {
                                        Logging.WriteLog("Error in UpdateNeedUpdateDeliveryTicket - ID - " + lstDeliveryTicket[i].ID + ", Reason - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                    }
                                }
                            }
                        }
                    }

                }
            }
            catch (WebException e)
            {
                string pageContent = new StreamReader(e.Response.GetResponseStream()).ReadToEnd().ToString();

            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateDeliveryTicket - " + ex.Message.ToString(), EventLogEntryType.Error);

            }

        }

        public static void UpdateAttachment()
        {
            try
            {
                string GetAttachment = new WebClient().DownloadString(ServiceURL.GetAttachment);
                List<Attachment> lstAttachment = JsonConvert.DeserializeObject<List<Attachment>>(GetAttachment);
                Logging.WriteLog("Function Called UpdateAttachment - Count " + lstAttachment.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };

                if (lstAttachment.Count > 0)
                {
                    for (int i = 0; i < lstAttachment.Count; i++)
                    {
                        AttachmentJSONParam JsonParamValue = new AttachmentJSONParam();
                        AttachmentUpdate Attachment_Update = new AttachmentUpdate();
                        Attachment AttachmentGet = new Attachment();
                        AttachmentGet.ID = lstAttachment[i].ID;
                        AttachmentGet.OrderNo = lstAttachment[i].OrderNo;
                        AttachmentGet.SysTrxNo = lstAttachment[i].SysTrxNo;
                        AttachmentGet.CreatedDate = lstAttachment[i].CreatedDate;
                        AttachmentGet.DeviceTime = lstAttachment[i].DeviceTime;
                        AttachmentGet.AttachmentFile = lstAttachment[i].AttachmentFile;
                        AttachmentGet.CustomerID = lstAttachment[i].CustomerID;
                        AttachmentGet.AttachmentName = lstAttachment[i].AttachmentName;
                        AttachmentGet.NeedUpdate = lstAttachment[i].NeedUpdate;
                        AttachmentGet.FileName = lstAttachment[i].FileName;
                        AttachmentGet.Status = lstAttachment[i].Status;
                        AttachmentGet.CompanyID = lstAttachment[i].CompanyID;
                        Attachment_Update.AttachmentUpdateList.Add(AttachmentGet);
                        JsonParamValue.AttachmentGetToUpdate = Attachment_Update;

                        string jsonIgnoreNullValues = JsonConvert.SerializeObject(JsonParamValue, Formatting.None, new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                        });

                        ParamList paramList = new ParamList();
                        parameter paramVal = new parameter();
                        paramVal.name = "JsonValue";
                        //paramVal.param_type = "IN";
                        paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");
                        paramList.Params.Add(paramVal);

                        var jsonVal = jsonSerialiser.Serialize(paramList);
                        jsonVal = jsonVal.Replace("Params", "params");

                        string url = ServiceURL.UpdateAttachment + "&";
                        var request = (HttpWebRequest)HttpWebRequest.Create(url);
                        request.ContentType = "application/json; charset=utf-8";
                        request.Method = "POST";
                        request.Accept = "application/json; charset=utf-8";


                        using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                        {
                            streamWriter.Write(jsonVal);
                        }
                        var httpResponse = (HttpWebResponse)request.GetResponse();

                        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                        {
                            var result = streamReader.ReadToEnd();
                            List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                            if (lsResult != null)
                            {
                                if (lsResult.Count > 0)
                                {
                                    if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                    {


                                        string AttachmentNeedUpdateMarineURL = ServiceURL.UpdateNeedUpdateAttachment + "(" + lstAttachment[i].ID + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                                        string AttachmentSyncUpdateResult = new WebClient().DownloadString(AttachmentNeedUpdateMarineURL);

                                    }
                                    else
                                    {
                                        Logging.WriteLog("Error in UpdateNeedUpdateAttachment - ID - " + lstAttachment[i].ID + ", Reason - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                    }
                                }
                            }
                        }
                    }

                }
            }
            catch (WebException e)
            {
                string pageContent = new StreamReader(e.Response.GetResponseStream()).ReadToEnd().ToString();

            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateAttachment - " + ex.Message.ToString(), EventLogEntryType.Error);
            }
        }

        public static void UpdateINSiteTankVolume()
        {

            try
            {
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };

                string GetINSiteTankVolume = new WebClient().DownloadString(ServiceURL.GetINSiteTankVolume);
                List<INSiteTankVolume> ltINSiteTankVolume = JsonConvert.DeserializeObject<List<INSiteTankVolume>>(GetINSiteTankVolume);

                string GetINSiteTankVolumeDetail = new WebClient().DownloadString(ServiceURL.GetINSiteTankVolumeDetail);
                List<INSiteTankVolumeDetails> ltINSiteTankVolumeDetails = JsonConvert.DeserializeObject<List<INSiteTankVolumeDetails>>(GetINSiteTankVolumeDetail);

                Logging.WriteToFileException("UpdateINSiteTankVolume - " + ltINSiteTankVolume.Count);
                if (ltINSiteTankVolume != null && ltINSiteTankVolume.Count > 0)
                {
                    for (int i = 0; i < ltINSiteTankVolume.Count; i++)
                    {
                        try
                        {
                            INSiteTankVolume inSiteTankVolume = new INSiteTankVolume();


                            INSiteTankVolumeUpdate inSiteTankVolumeUpdate = new INSiteTankVolumeUpdate();
                            INSiteTankVolumeJSONParam inSiteTankVolumeJSONParam = new INSiteTankVolumeJSONParam();

                            int insiteTankVolumeID = ltINSiteTankVolume[i].INSiteTankVolumeID;

                            inSiteTankVolume.INSiteTankVolumeID = 0;
                            inSiteTankVolume.INSiteTankID = ltINSiteTankVolume[i].INSiteTankID;
                            inSiteTankVolume.INSiteID = ltINSiteTankVolume[i].INSiteID;
                            inSiteTankVolume.Depth = ltINSiteTankVolume[i].Depth;
                            inSiteTankVolume.DepthNumerator = ltINSiteTankVolume[i].DepthNumerator;
                            inSiteTankVolume.Feet = ltINSiteTankVolume[i].Feet;
                            inSiteTankVolume.ReadingDateTime = ltINSiteTankVolume[i].ReadingDateTime;
                            inSiteTankVolume.Quantity = ltINSiteTankVolume[i].Quantity;
                            inSiteTankVolume.Status = ltINSiteTankVolume[i].Status;
                            inSiteTankVolume.ProdContID = ltINSiteTankVolume[i].ProdContID;
                            inSiteTankVolume.LastModifiedDtTm = ltINSiteTankVolume[i].LastModifiedDtTm;
                            inSiteTankVolume.LastModifiedUser = ltINSiteTankVolume[i].LastModifiedUser;
                            inSiteTankVolume.BeforeorAfter = ltINSiteTankVolume[i].BeforeorAfter;
                            inSiteTankVolume.TankReadingTypeID = ltINSiteTankVolume[i].TankReadingTypeID;
                            inSiteTankVolume.LastReadingDateTime = ltINSiteTankVolume[i].LastReadingDateTime;
                            inSiteTankVolume.DraftB = ltINSiteTankVolume[i].DraftB;
                            inSiteTankVolume.DraftFeetB = ltINSiteTankVolume[i].DraftFeetB;
                            inSiteTankVolume.DraftFeetS = ltINSiteTankVolume[i].DraftFeetS;
                            inSiteTankVolume.DraftS = ltINSiteTankVolume[i].DraftS;
                            inSiteTankVolume.CustomerID = ltINSiteTankVolume[i].CustomerID;
                            inSiteTankVolume.Temperature = ltINSiteTankVolume[i].Temperature;
                            inSiteTankVolume.AmbientTemperature = ltINSiteTankVolume[i].AmbientTemperature;
                            inSiteTankVolume.Comment = ltINSiteTankVolume[i].Comment;
                            //    inSiteTankVolumeUpdate.INSiteTankVolumeList.Add(inSiteTankVolume);
                            inSiteTankVolumeJSONParam.INSiteTankVolumeReading.INSiteTankVolumeList.Add(inSiteTankVolume);
                            List<INSiteTankVolumeDetails> filteredINSiteTankVolumeDetails = ltINSiteTankVolumeDetails.Where(item => item.INSiteTankVolumeID == insiteTankVolumeID).ToList();

                            for (int j = 0; j < filteredINSiteTankVolumeDetails.Count; j++)
                            {
                                INSiteTankVolumeDetails inSiteTankVolumeDetails = new INSiteTankVolumeDetails();
                                inSiteTankVolumeDetails.INSiteTankID = filteredINSiteTankVolumeDetails[j].INSiteTankID;
                                inSiteTankVolumeDetails.CompartmentID = filteredINSiteTankVolumeDetails[j].CompartmentID;
                                inSiteTankVolumeDetails.PortFeet = filteredINSiteTankVolumeDetails[j].PortFeet;
                                inSiteTankVolumeDetails.PortFuelDepth = filteredINSiteTankVolumeDetails[j].PortFuelDepth;
                                inSiteTankVolumeDetails.PortFuelDepthNumerator = filteredINSiteTankVolumeDetails[j].PortFuelDepthNumerator;
                                inSiteTankVolumeDetails.MiddleFeet = filteredINSiteTankVolumeDetails[j].MiddleFeet;
                                inSiteTankVolumeDetails.MiddleFuelDepth = filteredINSiteTankVolumeDetails[j].MiddleFuelDepth;
                                inSiteTankVolumeDetails.MiddleFuelDepthNumerator = filteredINSiteTankVolumeDetails[j].MiddleFuelDepthNumerator;
                                inSiteTankVolumeDetails.SBoardFeet = filteredINSiteTankVolumeDetails[j].SBoardFeet;
                                inSiteTankVolumeDetails.SBoardFuelDepth = filteredINSiteTankVolumeDetails[j].SBoardFuelDepth;
                                inSiteTankVolumeDetails.SBoardFuelDepthNumerator = filteredINSiteTankVolumeDetails[j].SBoardFuelDepthNumerator;
                                inSiteTankVolumeDetails.MeterReading = filteredINSiteTankVolumeDetails[j].MeterReading;
                                inSiteTankVolumeDetails.ClientID = filteredINSiteTankVolumeDetails[j].ClientID;
                                inSiteTankVolumeDetails.Denominator = filteredINSiteTankVolumeDetails[j].Denominator;
                                //inSiteTankVolumeUpdate.INSiteTankVolumeDetailList.Add(inSiteTankVolumeDetails);
                                inSiteTankVolumeJSONParam.INSiteTankVolumeReading.INSiteTankVolumeDetailList.Add(inSiteTankVolumeDetails);
                            }


                            //inSiteTankVolumeJSONParam.INSiteTankVolumeReading = inSiteTankVolumeUpdate;

                            string jsonIgnoreNullValues = JsonConvert.SerializeObject(inSiteTankVolumeJSONParam, Formatting.None, new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });

                            ParamList paramList = new ParamList();
                            parameter paramVal = new parameter();
                            paramVal.name = "JsonValue";
                            // paramVal.param_type = "IN";
                            paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");
                            paramList.Params.Add(paramVal);

                            var jsonVal = jsonSerialiser.Serialize(paramList);
                            jsonVal = jsonVal.Replace("Params", "params");

                            string url = ServiceURL.UpdateINSiteTankVolume + "&";
                            var request = (HttpWebRequest)HttpWebRequest.Create(url);
                            request.ContentType = "application/json; charset=utf-8";
                            request.Method = "POST";
                            request.Accept = "application/json; charset=utf-8";

                            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                            {
                                streamWriter.Write(jsonVal);
                            }

                            var httpResponse = (HttpWebResponse)request.GetResponse();
                            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                            {
                                var result = streamReader.ReadToEnd();
                                List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                                if (lsResult != null)
                                {
                                    if (lsResult.Count > 0)
                                    {
                                        if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                        {
                                            string INSiteTankVolumeIsUpdatedFlag = ServiceURL.UpdateINSiteTankIsUpdatedFlag + "(" + insiteTankVolumeID + "," + inSiteTankVolume.ReadingDateTime + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                                            string INSiteTankVolumeIsUpdatedFlagResult = new WebClient().DownloadString(INSiteTankVolumeIsUpdatedFlag);

                                        }
                                        else
                                        {
                                            Logging.WriteLog("Error in UpdateINSiteTankVolume - ID - " + ltINSiteTankVolume[i].INSiteTankVolumeID + ", Reason - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Logging.WriteLog("Error in UpdateINSiteTankVolume - " + ex.Message.ToString(), EventLogEntryType.Error);
                        }


                    }
                }

            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateINSiteTankVolume - " + ex.Message.ToString(), EventLogEntryType.Error);
            }
        }

        /// <summary>
        /// UpdateSyncDeletedTrx
        /// Function to update SyncDeleted
        /// </summary>
        public static void UpdateSyncDeletedTrx()
        {
            try
            {
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                string GetSyncDeletedTrx = new WebClient().DownloadString(ServiceURL.GetSyncDeletedTrx);
                List<SyncDeletedTrx> ltSyncDeletedTrx = JsonConvert.DeserializeObject<List<SyncDeletedTrx>>(GetSyncDeletedTrx);
                Logging.WriteToFileException("UpdateSyncDeletedTrx - " + ltSyncDeletedTrx.Count);
                if (ltSyncDeletedTrx != null && ltSyncDeletedTrx.Count > 0)
                {
                    SyncDeletedTrxUpdate SyncDeletedTrxUpdate = new SyncDeletedTrxUpdate();
                    SyncDeletedTrxJSONParam SyncDeletedTrxJSONParam = new SyncDeletedTrxJSONParam();

                    for (int i = 0; i < ltSyncDeletedTrx.Count; i++)
                    {
                        SyncDeletedTrx SyncDeletedTrx = new SyncDeletedTrx();

                        SyncDeletedTrx.ID = ltSyncDeletedTrx[i].ID;
                        SyncDeletedTrx.ColumnName = ltSyncDeletedTrx[i].ColumnName;
                        SyncDeletedTrx.TableName = ltSyncDeletedTrx[i].TableName;

                        SyncDeletedTrxUpdate.SyncDeletedTrxList.Add(SyncDeletedTrx);

                        SyncDeletedTrxJSONParam.SyncDeletedTrx = SyncDeletedTrxUpdate;
                    }
                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(SyncDeletedTrxJSONParam, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                    //ParamList paramList = new ParamList();
                    //parameter paramVal = new parameter();
                    //paramVal.name = "JsonValue";
                    ////  paramVal.param_type = "IN";
                    //paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");
                    //paramList.Params.Add(paramVal);

                    //var jsonVal = jsonSerialiser.Serialize(paramList);
                    //jsonVal = jsonVal.Replace("Params", "params");

                    parameterList paramList = new parameterList();
                    paramList.Params.Add(jsonIgnoreNullValues);

                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");



                    string url = ServiceURL.UpdateSyncDeletedTrx + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                    }

                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {
                                    for (var i = 0; i < ltSyncDeletedTrx.Count; i++)
                                    {
                                        string SyncDeletedTrxIsUpdatedFlag = ServiceURL.UpdateSyncDeletedTrxIsUpdatedFlag + "(" + ltSyncDeletedTrx[i].ID + "," + ltSyncDeletedTrx[i].TableName + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                                        string SyncDeletedTrxIsUpdatedFlagResult = new WebClient().DownloadString(SyncDeletedTrxIsUpdatedFlag);
                                    }

                                }
                                else
                                {
                                    Logging.WriteLog("Error in UpdateSyncDeletedTrx - " + lsResult[0].Reason.ToString(), EventLogEntryType.Error);
                                }
                            }
                        }
                    }
                }

                DeleteINSiteBillingItem();
                DeleteINSiteProdCont();
                DeletePersonPhone();
                DeleteSubstitutes();
                DeleteTankChartDetail();
                DeleteVehicleSubCompartments();
                DeleteMarineAppSalesPLUButtons();
                DeleteINSiteTankProducts();
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateSyncDeletedTrx - " + ex.Message.ToString(), EventLogEntryType.Error);
            }
        }

        public static void DeleteINSiteBillingItem()
        {
            try
            {
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                string GetDeletedINSiteBillingItem = new WebClient().DownloadString(ServiceURL.GetDeletedINSiteBillingItem);
                List<INSiteBillingItemDeletedTrx> ltDeletedINSiteBillingItem = JsonConvert.DeserializeObject<List<INSiteBillingItemDeletedTrx>>(GetDeletedINSiteBillingItem);
                Logging.WriteToFileException("DeleteINSiteBillingItem - " + ltDeletedINSiteBillingItem.Count);

                foreach (INSiteBillingItemDeletedTrx item in ltDeletedINSiteBillingItem)
                {
                    try
                    {
                        string DeleteINSiteBillingItem = ServiceURL.DeleteINSiteBillingItem + "(" + item.SiteID + "," + item.BillingItemID + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                        string INSiteTankVolumeIsUpdatedFlagResult = new WebClient().DownloadString(DeleteINSiteBillingItem);

                        List<Results> result = JsonConvert.DeserializeObject<List<Results>>(INSiteTankVolumeIsUpdatedFlagResult);

                        if (result[0].StatusNew == "Success")
                        {
                            string UpdateDeleteINSiteBillingItemSyncFlag = ServiceURL.UpdateDeletedINSiteBillingItemSyncFlag + "(" + item.SiteID + "," + item.BillingItemID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                            string UpdateDeleteINSiteBillingItemSyncFlagResult = new WebClient().DownloadString(UpdateDeleteINSiteBillingItemSyncFlag);
                        }
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteLog("Error in DeleteINSiteBillingItem - " + ex.Message.ToString(), EventLogEntryType.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in DeleteINSiteBillingItem - " + ex.Message.ToString(), EventLogEntryType.Error);
            }
        }

        public static void DeleteINSiteProdCont()
        {
            try
            {
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                string GetDeletedINSiteProdCont = new WebClient().DownloadString(ServiceURL.GetDeletedINSiteProdCont);
                List<INSiteProdContDeletedTrx> ltDeletedINSiteProdCont = JsonConvert.DeserializeObject<List<INSiteProdContDeletedTrx>>(GetDeletedINSiteProdCont);
                Logging.WriteToFileException("DeleteINSiteProdCont - " + ltDeletedINSiteProdCont.Count);

                foreach (INSiteProdContDeletedTrx item in ltDeletedINSiteProdCont)
                {
                    try
                    {
                        string DeleteINSiteProdCont = ServiceURL.DeleteINSiteProdCont + "(" + item.SiteID + "," + item.ProdContID + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                        string DeleteINSiteProdContResult = new WebClient().DownloadString(DeleteINSiteProdCont);

                        List<Results> result = JsonConvert.DeserializeObject<List<Results>>(DeleteINSiteProdContResult);

                        if (result[0].StatusNew == "Success")
                        {
                            string UpdateDeletedINSiteProdContSyncFlag = ServiceURL.UpdateINSiteProdContDeletedTrxSyncFlag + "(" + item.SiteID + "," + item.ProdContID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                            string UpdateDeletedINSiteBillingItemSyncFlagResult = new WebClient().DownloadString(UpdateDeletedINSiteProdContSyncFlag);
                        }
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteLog("Error in DeleteINSiteProdCont - " + ex.Message.ToString(), EventLogEntryType.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in DeleteINSiteProdCont - " + ex.Message.ToString(), EventLogEntryType.Error);
            }
        }

        public static void DeletePersonPhone()
        {
            try
            {
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                string GetDeletedPersonPhone = new WebClient().DownloadString(ServiceURL.GetDeletedPersonPhone);
                List<PersonPhoneDeletedTrx> ltDeletedPersonPhone = JsonConvert.DeserializeObject<List<PersonPhoneDeletedTrx>>(GetDeletedPersonPhone);
                Logging.WriteToFileException("DeletePersonPhone - " + ltDeletedPersonPhone.Count);

                foreach (PersonPhoneDeletedTrx item in ltDeletedPersonPhone)
                {
                    try
                    {
                        string DeletePersonPhone = ServiceURL.DeletePersonPhone + "(" + item.PhoneID + "," + item.PersonID + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                        string DeletePersonPhoneResult = new WebClient().DownloadString(DeletePersonPhone);

                        List<Results> result = JsonConvert.DeserializeObject<List<Results>>(DeletePersonPhoneResult);

                        if (result[0].StatusNew == "Success")
                        {
                            string UpdateDeletedPersonPhoneSyncFlag = ServiceURL.UpdatePersonPhoneDeletedTrxSyncFlag + "(" + item.PhoneID + "," + item.PersonID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                            string UpdateDeletedPersonPhoneSyncFlagResult = new WebClient().DownloadString(UpdateDeletedPersonPhoneSyncFlag);
                        }
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteLog("Error in DeletePersonPhone - " + ex.Message.ToString(), EventLogEntryType.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in DeletePersonPhone - " + ex.Message.ToString(), EventLogEntryType.Error);
            }
        }

        public static void DeleteSubstitutes()
        {
            try
            {
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                string GetDeletedSubstitutes = new WebClient().DownloadString(ServiceURL.GetDeletedSubstitutes);
                List<SubstitutesDeletedTrx> ltDeletedSubstitutes = JsonConvert.DeserializeObject<List<SubstitutesDeletedTrx>>(GetDeletedSubstitutes);
                Logging.WriteToFileException("DeleteSubstitutes - " + ltDeletedSubstitutes.Count);

                foreach (SubstitutesDeletedTrx item in ltDeletedSubstitutes)
                {
                    try
                    {
                        string DeleteSubstitutes = ServiceURL.DeleteSubstitutes + "(" + item.ProdContID + "," + item.SubProdContID + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                        string DeleteSubstitutesResult = new WebClient().DownloadString(DeleteSubstitutes);

                        List<Results> result = JsonConvert.DeserializeObject<List<Results>>(DeleteSubstitutesResult);

                        if (result[0].StatusNew == "Success")
                        {
                            string UpdateDeletedSubstitutesSyncFlag = ServiceURL.UpdateSubstitutesDeletedTrxSyncFlag + "(" + item.ProdContID + "," + item.SubProdContID + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                            string UpdateDeletedSubstitutesSyncFlagResult = new WebClient().DownloadString(UpdateDeletedSubstitutesSyncFlag);
                        }
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteLog("Error in DeleteSubstitutes - " + ex.Message.ToString(), EventLogEntryType.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in DeleteSubstitutes - " + ex.Message.ToString(), EventLogEntryType.Error);
            }
        }

        public static void DeleteTankChartDetail()
        {
            try
            {
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                string GetDeletedTankChartDetail = new WebClient().DownloadString(ServiceURL.GetDeletedTankChartDetail);
                List<TankChartDetailDeletedTrx> ltDeletedTankChartDetail = JsonConvert.DeserializeObject<List<TankChartDetailDeletedTrx>>(GetDeletedTankChartDetail);
                Logging.WriteToFileException("DeleteTankChartDetail - " + ltDeletedTankChartDetail.Count);

                foreach (TankChartDetailDeletedTrx item in ltDeletedTankChartDetail)
                {
                    try
                    {
                        string DeleteTankChartDetail = ServiceURL.DeleteTankChartDetail + "(" + item.TankChartID + "," + item.DepthFeet + "," + item.Depth + "," + item.DepthFraction + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                        string DeleteTankChartDetailResult = new WebClient().DownloadString(DeleteTankChartDetail);

                        List<Results> result = JsonConvert.DeserializeObject<List<Results>>(DeleteTankChartDetailResult);

                        if (result[0].StatusNew == "Success")
                        {
                            string UpdateDeletedTankChartDetailSyncFlag = ServiceURL.UpdateTankChartDetailDeletedTrxSyncFlag + "(" + item.TankChartID + "," + item.DepthFeet + "," + item.Depth + "," + item.DepthFraction + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                            string UpdateDeletedTankChartDetailSyncFlagResult = new WebClient().DownloadString(UpdateDeletedTankChartDetailSyncFlag);
                        }
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteLog("Error in DeleteTankChartDetail - " + ex.Message.ToString(), EventLogEntryType.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in DeleteSubstitutes - " + ex.Message.ToString(), EventLogEntryType.Error);
            }
        }

        public static void DeleteVehicleSubCompartments()
        {
            try
            {
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                string GetDeletedVehicleSubCompartments = new WebClient().DownloadString(ServiceURL.GetDeletedVehicleSubCompartments);
                List<VehicleSubCompartmentsDeletedTrx> ltDeletedVehicleSubCompartments = JsonConvert.DeserializeObject<List<VehicleSubCompartmentsDeletedTrx>>(GetDeletedVehicleSubCompartments);
                Logging.WriteToFileException("DeleteVehicleSubCompartments - " + ltDeletedVehicleSubCompartments.Count);

                foreach (VehicleSubCompartmentsDeletedTrx item in ltDeletedVehicleSubCompartments)
                {
                    try
                    {
                        string DeleteVehicleSubCompartments = ServiceURL.DeleteVehicleSubCompartments + "(" + item.CompartmentID + "," + item.TankChartID + "," + item.ReadingSide + ")?" + ConfigurationManager.AppSettings["CloudAPIKEY"].ToString();
                        string DeleteVehicleSubCompartmentsResult = new WebClient().DownloadString(DeleteVehicleSubCompartments);

                        List<Results> result = JsonConvert.DeserializeObject<List<Results>>(DeleteVehicleSubCompartmentsResult);

                        if (result[0].StatusNew == "Success")
                        {
                            string UpdateDeletedVehicleSubCompartmentsSyncFlag = ServiceURL.UpdateVehicleSubCompartmentsDeletedTrxSyncFlag + "(" + item.CompartmentID + "," + item.TankChartID + "," + item.ReadingSide + ")?" + ConfigurationManager.AppSettings["ClientAPIKEY"].ToString();
                            string UpdateDeletedVehicleSubCompartmentsSyncFlagResult = new WebClient().DownloadString(UpdateDeletedVehicleSubCompartmentsSyncFlag);
                        }
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteLog("Error in DeleteVehicleSubCompartments - " + ex.Message.ToString(), EventLogEntryType.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in DeleteVehicleSubCompartments - " + ex.Message.ToString(), EventLogEntryType.Error);
            }
        }

        private static Results UpdateSyncFlag(object obj, string url)
        {
            Results results = new Results();
            var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };

            string jsonIgnoreNullValues = JsonConvert.SerializeObject(obj, Formatting.None, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            //ParamList paramList = new ParamList();
            //parameter paramVal = new parameter();
            //paramVal.name = "JsonValue";
            //// paramVal.param_type = "IN";
            //paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");
            //paramList.Params.Add(paramVal);

            parameterList sync = new parameterList();
            sync.Params.Add(jsonIgnoreNullValues);

            var jsonVal = jsonSerialiser.Serialize(sync);
            jsonVal = jsonVal.Replace("Params", "params");

            //   string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

            //  string url = ServiceURL.UpdateINSiteTankVolume + "&";
            var request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.ContentType = "application/json; charset=utf-8";
            request.Method = "POST";
            request.Accept = "application/json; charset=utf-8";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(jsonVal);
            }

            var httpResponse = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                if (lsResult != null)
                {
                    if (lsResult.Count > 0)
                    {
                        results = lsResult[0];
                    }
                }
            }
            return results;
        }

        public static void UpdateTankChartNew()
        {
            try
            {
                Logging.WriteLog("UpdateTankChartNew is called", EventLogEntryType.Information);
                using (DataHandler dataHandler = new DataHandler(Common.ConnectionType.Ascend))
                {
                    ResultArgs resultArgs = dataHandler.Fetch(QueryCommands.Master.UpdateTankChartDetailsNew, Common.CommandType.StroeProcedure);
                    if (!resultArgs.Success)
                    {
                        Logging.WriteLog("Error in UpdateTankChartNew - " + resultArgs.Message, EventLogEntryType.Error);
                    }
                    else
                    {
                        if (resultArgs != null && resultArgs.AffectedRows > 0)
                        {
                            if (resultArgs.Source.Rows[0][Common.ResultStatus.StatusNew.ToString()].ToString().ToLower() != Common.Status.success.ToString())
                            {
                                Logging.WriteLog("UpdateTankChartNew - " + resultArgs.Source.Rows[0]["Reason"], EventLogEntryType.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateTankChartNew - " + ex.Message.ToString(), EventLogEntryType.Error);
            }
        }

        public static void UpdateINSiteProdContNew()
        {
            try
            {
                Logging.WriteLog("UpdateINSiteProdContNew is called", EventLogEntryType.Information);
                using (DataHandler dataHandler = new DataHandler(Common.ConnectionType.Ascend))
                {
                    ResultArgs resultArgs = dataHandler.Fetch(QueryCommands.Master.UpdateInSiteProdContNew, Common.CommandType.StroeProcedure);
                    if (!resultArgs.Success)
                    {
                        Logging.WriteLog("Error in UpdateINSiteProdContNew - " + resultArgs.Message, EventLogEntryType.Error);
                    }
                    else
                    {
                        if (resultArgs != null && resultArgs.AffectedRows > 0)
                        {
                            if (resultArgs.Source.Rows[0][Common.ResultStatus.StatusNew.ToString()].ToString().ToLower() != Common.Status.success.ToString())
                            {
                                Logging.WriteLog("UpdateINSiteProdContNew - " + resultArgs.Source.Rows[0]["Reason"], EventLogEntryType.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateINSiteProdContNew - " + ex.Message.ToString(), EventLogEntryType.Error);
            }
        }

        public static void UpdateOrderNotes()
        {
            try
            {
                string GetOrderNote = new WebClient().DownloadString(ServiceURL.GetOrderNote);
                List<OrderNote> lstOrderNote = JsonConvert.DeserializeObject<List<OrderNote>>(GetOrderNote);
                Logging.WriteLog("Function Called UpdateOrderNotes - Count " + lstOrderNote.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };

                if (lstOrderNote.Count > 0)
                {

                    OrderNoteUpdate orderNoteUpdate = new OrderNoteUpdate();
                    OrderNoteJSONParam orderNoteListJson = new OrderNoteJSONParam();
                    orderNoteUpdate.OderNoteList = (from o in lstOrderNote
                                                    select new OrderNote { SysTrxNo = o.SysTrxNo, NoteNo = o.NoteNo, NoteTypeID = o.NoteTypeID, Note = !string.IsNullOrEmpty(o.Note) ? o.Note.EncodeString().Trim() : o.Note, ClientID = o.ClientID, NoteID = o.NoteID, LastModifiedUserID = o.LastModifiedUserID, LastModifiedDateTime = o.LastModifiedDateTime }).ToList<OrderNote>();
                    orderNoteListJson.orderNoteUpdate = orderNoteUpdate;

                    //var jsonperVal = jsonSerialiser.Serialize(orderNoteListJson);

                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(orderNoteListJson, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                    ParamList paramList = new ParamList();
                    parameter paramVal = new parameter();
                    paramVal.name = "JsonValue";
                    //paramVal.param_type = "IN";
                    // paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");
                    paramVal.value = jsonIgnoreNullValues;
                    paramList.Params.Add(paramVal);

                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");

                    string url = ServiceURL.UpdateOrderNote + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {
                                    MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                    JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                    marineSyncFlagUpdate.marineSyncFlagUpdate = (from i in lstOrderNote
                                                                                 select new MarineSyncFlag { ID = i.SysTrxNo }).ToList<MarineSyncFlag>();

                                    jsonMarineSyncFlagUpdate.marineSyncFlag = marineSyncFlagUpdate;
                                    Results results = UpdateSyncFlag(jsonMarineSyncFlagUpdate, string.Format("{0}?{1}&", ServiceURL.UpdateOrderNoteSyncFlag, ConfigurationManager.AppSettings["ClientAPIKEY"].ToString()));

                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateSyncFlagInSite - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateOrderNotes - " + ex.Message.ToString(), EventLogEntryType.Error);
            }
        }

        public static void UpdateOrderNotesToClient()
        {
            try
            {
                string GetOrderNote = new WebClient().DownloadString(ServiceURL.GetCloudOrderNotes);
                List<OrderNote> lstOrderNote = JsonConvert.DeserializeObject<List<OrderNote>>(GetOrderNote);
                Logging.WriteLog("Function Called updateOrderNotesToClient - Count " + lstOrderNote.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstOrderNote.Count > 0)
                {
                    OrderNoteUpdate orderNoteUpdate = new OrderNoteUpdate();
                    OrderNoteJSONParam orderNoteListJson = new OrderNoteJSONParam();
                    orderNoteUpdate.OderNoteList = (from o in lstOrderNote
                                                    select new OrderNote { SysTrxNo = o.SysTrxNo, NoteNo = o.NoteNo, Note = !o.Note.IsStringEmpty() ? o.Note.EncodeString().Trim() : string.Empty, ClientID = o.ClientID, NoteID = o.NoteID, IsAppNote = o.IsAppNote, LastModifiedDateTime = o.LastModifiedDateTime, LastModifiedUserID = o.LastModifiedUserID, IsDeleted = o.IsDeleted }).ToList<OrderNote>();
                    orderNoteListJson.orderNoteUpdate = orderNoteUpdate;


                    string jsonIgnoreNullValues = JsonConvert.SerializeObject(orderNoteListJson, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                    ParamList paramList = new ParamList();
                    parameter paramVal = new parameter();
                    paramVal.name = "JsonValue";
                    // paramVal.param_type = "IN";
                    //paramVal.value = jsonIgnoreNullValues.ToString().Replace("\\\\", "");
                    paramVal.value = jsonIgnoreNullValues;
                    paramList.Params.Add(paramVal);


                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");


                    string url = ServiceURL.UpdateOrderNoteToClient + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {
                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {
                                    MarineSyncFlagUpdate marineSyncFlagUpdate = new MarineSyncFlagUpdate();
                                    JsonMarineSyncFlagUpdate jsonMarineSyncFlagUpdate = new JsonMarineSyncFlagUpdate();

                                    marineSyncFlagUpdate.marineSyncFlagUpdate = (from i in lstOrderNote
                                                                                 select new MarineSyncFlag { ID = i.NoteID }).ToList<MarineSyncFlag>();

                                    jsonMarineSyncFlagUpdate.marineSyncFlag = marineSyncFlagUpdate;
                                    Results results = UpdateSyncFlag(jsonMarineSyncFlagUpdate, string.Format("{0}?{1}&", ServiceURL.UpdateCloudOrderNoteSyncFlag, ConfigurationManager.AppSettings["CloudAPIKEY"].ToString()));

                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateSyncFlagInSite - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }

                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateOrderNotes - " + ex.Message.ToString(), EventLogEntryType.Error);
            }
        }

        public static void DeleteMarineAppSalesPLUButtons()
        {
            try
            {
                string GetMarineAppSalesPLUButtons = new WebClient().DownloadString(ServiceURL.GetDeleteSalesPLUButtons);
                List<MarineAppSalesPLUButtons> lstMarineAppSalesPLUButtons = JsonConvert.DeserializeObject<List<MarineAppSalesPLUButtons>>(GetMarineAppSalesPLUButtons);
                Logging.WriteLog("Function Called DeleteMarineAppSalesPLUButtons - Count " + lstMarineAppSalesPLUButtons.Count.ToString(), EventLogEntryType.Error);
                var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                if (lstMarineAppSalesPLUButtons.Count > 0)
                {
                    MarineAppSalesPLUButtonsJSONParam JsonParamValue = new MarineAppSalesPLUButtonsJSONParam();
                    MarineAppSalesPLUButtonsDetails MarineAppSalesPLUButtonsDetail = new MarineAppSalesPLUButtonsDetails();
                    for (var i = 0; i < lstMarineAppSalesPLUButtons.Count; i++)
                    {
                        MarineAppSalesPLUButtons MarineAppSalesPLUButtons = new MarineAppSalesPLUButtons();
                        MarineAppSalesPLUButtons.Position = lstMarineAppSalesPLUButtons[i].Position;
                        MarineAppSalesPLUButtons.SiteID = lstMarineAppSalesPLUButtons[i].SiteID;
                        MarineAppSalesPLUButtonsDetail.MarineAppSalesPLUButtonsList.Add(MarineAppSalesPLUButtons);
                    }
                    JsonParamValue.MarineAppSalesPLUButtons = MarineAppSalesPLUButtonsDetail;
                    var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);

                    ParamList paramList = new ParamList();
                    parameter paramVal = new parameter();
                    paramVal.name = "JsonValue";
                    // paramVal.param_type = "IN";
                    paramVal.value = jsonperVal.ToString().Replace("\\\\", "");
                    paramList.Params.Add(paramVal);


                    var jsonVal = jsonSerialiser.Serialize(paramList);
                    jsonVal = jsonVal.Replace("Params", "params");

                    string url = ServiceURL.DeleteSalesPLUButtons + "&";
                    var request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Method = "POST";
                    request.Accept = "application/json; charset=utf-8";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonVal);
                        //streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        List<Results> lsResult = JsonConvert.DeserializeObject<List<Results>>(result);
                        if (lsResult != null)
                        {
                            if (lsResult.Count > 0)
                            {

                                if (lsResult[0].StatusNew.ToString().ToLower() == "success")
                                {
                                    Results results = UpdateSyncFlag(JsonParamValue, string.Format("{0}?{1}&", ServiceURL.UpdateSalesPLUButtonsDeletedSyncFlag, ConfigurationManager.AppSettings["ClientAPIKEY"].ToString()));
                                    if (results.StatusNew.ToString().ToLower() != "success")
                                    {
                                        Logging.WriteLog("Error in UpdateSyncFlagInSite - " + results.Reason.ToString(), EventLogEntryType.Error);
                                    }
                                }
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in DeleteMarineAppSalesPLUButtons - " + ex.Message.ToString(), EventLogEntryType.Error);
            }
        }

        public static void UpdateOrderNoteAttachment()
        {
            ResultArgs resultArgs = new ResultArgs();
            try
            {
                Logging.WriteLog("UpdateOrderNoteAttachment is called", EventLogEntryType.Information);

                using (DataHandler dataHandler = new DataHandler(Common.ConnectionType.Ascend))
                {
                    resultArgs = dataHandler.Fetch(QueryCommands.Master.GetOrderAttachment, Common.CommandType.StroeProcedure);
                    Logging.WriteLog("UpdateOrderNoteAttachment - Count - " + resultArgs.AffectedRows, EventLogEntryType.Information);
                }
                if (resultArgs.Success && resultArgs.AffectedRows > 0)
                {
                    try
                    {

                        foreach (DataRow dr in resultArgs.Source.Rows)
                        {


                            string storageConnection = CloudConfigurationManager.GetSetting("StorageConnectionString");
                            CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse(storageConnection);

                            CloudBlobClient blobClient = cloudStorageAccount.CreateCloudBlobClient();

                            CloudBlobContainer blobContainer = blobClient.GetContainerReference("order-data");

                            blobContainer.CreateIfNotExists();
                            blobContainer.SetPermissions(
                            new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });

                            if (blobContainer.Exists())
                            {
                                CloudBlobDirectory directory = blobContainer.GetDirectoryReference(ConfigurationManager.AppSettings["Env"].ToString());
                                CloudBlobDirectory subDirectory = directory.GetDirectoryReference(dr["OrderNo"].ToString());


                                CloudBlockBlob blockBlob = subDirectory.GetBlockBlobReference(dr["FileDescr"].ToString());

                                using (var stream = new MemoryStream((byte[])dr["DataFile"], writable: true))
                                {
                                    blockBlob.UploadFromStream(stream);
                                }

                                if (!string.IsNullOrEmpty(blockBlob.StorageUri.ToString()))
                                {
                                    using (DataHandler MarineDataHandler = new DataHandler(Common.ConnectionType.MarineDelivery))
                                    {
                                        MarineDataHandler.AddParameter("SystrxNo", dr["SysTrxNo"].ToString().Trim());
                                        MarineDataHandler.AddParameter("OrderNo", dr["OrderNo"].ToString().Trim());
                                        MarineDataHandler.AddParameter("AttachmentID", dr["AttachmentID"].ToString().Trim());
                                        MarineDataHandler.AddParameter("CustomerID", dr["CustomerID"].ToString().Trim());
                                        MarineDataHandler.AddParameter("UserID", dr["LastModifiedUser"].ToString().Trim());
                                        MarineDataHandler.AddParameter("FileExt", dr["FileExt"].ToString().Trim());
                                        MarineDataHandler.AddParameter("FileName", dr["FileDescr"].ToString());
                                        MarineDataHandler.AddParameter("FilePath", blockBlob.StorageUri.PrimaryUri.ToString());
                                        //Logging.WriteLog("UpdateOrderNotesAttachment before update ", EventLogEntryType.Information);
                                        resultArgs = MarineDataHandler.Fetch(QueryCommands.Master.UpdateOrderAttachment, Common.CommandType.StroeProcedure);

                                        if (!resultArgs.Success)
                                        {
                                            Logging.WriteLog($"UpdateOrderNotesAttachment - {resultArgs.Source.Rows[0]["Reason"].ToString()} ", EventLogEntryType.Information);
                                        }

                                    }
                                }
                            }




                            //    OrderAttachmentJSONParam JsonParamValue = new OrderAttachmentJSONParam();
                            //    var jsonSerialiser = new JavaScriptSerializer() { MaxJsonLength = 999999999 };
                            //    OrderAttachment OrderAttachment = new OrderAttachment();
                            //    OrderAttachment.env = ConfigurationManager.AppSettings["Env"].ToString().Trim();
                            //    OrderAttachment.OrderNo = dr["OrderNo"].ToString().Trim();
                            //    //  OrderAttachment.attachementData = Convert.ToBase64String((byte[])dr["DataFile"]); //System.Text.Encoding.UTF8.GetString((byte[])dr["DataFile"]);
                            //    OrderAttachment.name = dr["FileDescr"].ToString();
                            //    OrderAttachment.type = dr["FileExt"].ToString().Trim();
                            //    JsonParamValue.OrderAttachmentList.Add(OrderAttachment);

                            //    var jsonperVal = jsonSerialiser.Serialize(JsonParamValue);
                            //    Logging.WriteLog("UpdateOrderNoteAttachment - AttachmentID - " + dr["AttachmentID"].ToString(), EventLogEntryType.Information);
                            //    Logging.WriteLog("UpdateOrderNoteAttachment - AttachmentID - " + dr["FileDescr"].ToString(), EventLogEntryType.Information);

                            //    //param paramVal = new param();
                            //    //paramVal.name = "JsonValue";
                            //    //paramVal.param_type = "IN";
                            //    //paramVal.value = jsonperVal.ToString().Replace("\\\\", "");

                            //    //var jsonVal = jsonSerialiser.Serialize(paramVal);

                            //    //string JsonStr = "{" + '"' + "params" + '"' + ":" + jsonVal.ToString() + "}";

                            //    //  Logging.WriteLog("UpdateOrderNoteAttachment - Json - " + Convert.ToBase64String((byte[])dr["DataFile"]), EventLogEntryType.Information);

                            //    // Logging.WriteLog(jsonperVal, EventLogEntryType.Information);

                            //    string url = ConfigurationManager.AppSettings["AzureUrl"].ToString().Trim();
                            //    HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                            //    request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                            //    request.ContentType = "application/json; charset=utf-8";
                            //    request.Method = "POST";
                            //    request.Accept = "application/json; charset=utf-8";

                            //    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                            //    {
                            //        //streamWriter.Write(JsonStr);
                            //        streamWriter.Write(jsonperVal);
                            //        //streamWriter.Close();
                            //    }

                            //    using (HttpWebResponse httpResponse = (HttpWebResponse)request.GetResponse())
                            //    {
                            //        //var httpResponse = (HttpWebResponse)request.GetResponse();
                            //        using (Stream streamResponse = httpResponse.GetResponseStream())
                            //        {
                            //            using (StreamReader streamReader = new StreamReader(streamResponse))
                            //            {
                            //                var result = streamReader.ReadToEnd();
                            //                Logging.WriteLog("UpdateOrderNoteAttachment - FilePath - " + result + "-" + result.Length, EventLogEntryType.Information);


                            //                // List<AttachmentResult> lsResult = JsonConvert.DeserializeObject<List<AttachmentResult>>(result);
                            //                if (!string.IsNullOrEmpty(result))
                            //                {

                            //                    //string filePath = result.Substring(7, result.Length - 10);
                            //                    //  Logging.WriteLog("UpdateOrderNoteAttachment - FilePath - " + filePath, EventLogEntryType.Information);
                            //                    using (DataHandler MarineDataHandler = new DataHandler(Common.ConnectionType.MarineDelivery))
                            //                    {
                            //                        MarineDataHandler.AddParameter("SystrxNo", dr["SysTrxNo"].ToString().Trim());
                            //                        MarineDataHandler.AddParameter("OrderNo", dr["OrderNo"].ToString().Trim());
                            //                        MarineDataHandler.AddParameter("AttachmentID", dr["AttachmentID"].ToString().Trim());
                            //                        MarineDataHandler.AddParameter("CustomerID", dr["CustomerID"].ToString().Trim());
                            //                        MarineDataHandler.AddParameter("UserID", dr["LastModifiedUser"].ToString().Trim());
                            //                        MarineDataHandler.AddParameter("FileExt", dr["FileExt"].ToString().Trim());
                            //                        MarineDataHandler.AddParameter("FileName", dr["FileDescr"].ToString());
                            //                        MarineDataHandler.AddParameter("FilePath", result);
                            //                        Logging.WriteLog("UpdateOrderNotesAttachment before update ", EventLogEntryType.Information);
                            //                        resultArgs = MarineDataHandler.Fetch(QueryCommands.Master.UpdateOrderAttachment, Common.CommandType.StroeProcedure);
                            //                        Logging.WriteLog("UpdateOrderNotesAttachment after update ", EventLogEntryType.Information);
                            //                    }

                            //                }
                            //            }
                            //        }
                            //    }
                        }
                    }
                    catch (Exception ex)
                    {
                        Logging.WriteLog("UpdateOrderNotesAttachment - " + ex.Message, EventLogEntryType.Error);
                    }
                }
                else
                {
                    if (resultArgs != null && resultArgs.AffectedRows > 0)
                    {
                        if (resultArgs.Source.Rows[0][Common.ResultStatus.StatusNew.ToString()].ToString().ToLower() != Common.Status.success.ToString())
                        {
                            Logging.WriteLog("UpdateOrderNotesAttachment - " + resultArgs.Message, EventLogEntryType.Error);
                        }
                    }
                }
            }


            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateOrderNoteAttachment - " + ex.Message.ToString(), EventLogEntryType.Error);
            }
        }

        public static void DeleteINSiteTankProducts()
        {
            try
            {
                Logging.WriteLog("DeleteINSiteTankProducts is called", EventLogEntryType.Information);
                ResultArgs result = new ResultArgs();
                using (DataHandler dataHandler = new DataHandler(Common.ConnectionType.MarineDelivery))
                {
                    result = dataHandler.Fetch(QueryCommands.Master.DeleteINSiteTankProducts, Common.CommandType.StroeProcedure);
                    if (!result.Success)
                    {
                        Logging.WriteLog("DeleteINSiteTankProducts - " + result.Message, EventLogEntryType.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in DeleteINSiteTankProducts - " + ex.Message.ToString(), EventLogEntryType.Error);
            }
        }

        public static void DeleteOrderAttachment()
        {
            try
            {
                Logging.WriteLog("DeleteOrderAttachment is called", EventLogEntryType.Information);
                ResultArgs result = new ResultArgs();
                using (DataHandler dataHandler = new DataHandler(Common.ConnectionType.MarineDelivery))
                {
                    result = dataHandler.Fetch(QueryCommands.Master.DeleteOrderAttachment, Common.CommandType.StroeProcedure);
                    if (!result.Success)
                    {
                        Logging.WriteLog("DeleteOrderAttachment - " + result.Message, EventLogEntryType.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in DeleteOrderAttachment - " + ex.Message.ToString(), EventLogEntryType.Error);
            }
        }

        public static void UpdateDocLogo()
        {
            try
            {
                Logging.WriteLog("UpdateDocLogo is called", EventLogEntryType.Information);
                ResultArgs result = new ResultArgs();
                using (DataHandler dataHandler = new DataHandler(Common.ConnectionType.Ascend))
                {

                    result = dataHandler.Fetch(QueryCommands.Master.UpdateDocLogo, Common.CommandType.StroeProcedure);
                    if (!result.Success)
                    {
                        Logging.WriteLog("UpdateDocLogo - " + result.Message, EventLogEntryType.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Error in UpdateDocMessage - " + ex.Message.ToString(), EventLogEntryType.Error);
            }
        }

    }


}
