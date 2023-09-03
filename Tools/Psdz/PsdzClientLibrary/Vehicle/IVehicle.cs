﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PsdzClient.Contracts;
using PsdzClient.Core;

namespace BMW.Rheingold.CoreFramework.Contracts.Vehicle
{
    [AuthorAPI(SelectableTypeDeclaration = true)]
    public enum BNMixed
    {
        HETEROGENEOUS,
        HOMOGENEOUS,
        SEPARATED,
        UNKNOWN
    }

    // ToDo: Check on update
    [AuthorAPI(SelectableTypeDeclaration = true)]
    public enum BNType
    {
        BN2000,
        BN2020,
        IBUS,
        BN2000_MOTORBIKE,
        BN2020_MOTORBIKE,
        BNK01X_MOTORBIKE,
        BEV2010,
        UNKNOWN
    }

    // ToDo: Check on update
    [AuthorAPI(SelectableTypeDeclaration = true)]
    public enum BrandName
    {
        [XmlEnum("BMW PKW")]
        BMWPKW,
        [XmlEnum("MINI PKW")]
        MINIPKW,
        [XmlEnum("ROLLS-ROYCE PKW")]
        ROLLSROYCEPKW,
        [XmlEnum("BMW MOTORRAD")]
        BMWMOTORRAD,
        [XmlEnum("BMW M GmbH PKW")]
        BMWMGmbHPKW,
        [XmlEnum("BMW USA PKW")]
        BMWUSAPKW,
        [XmlEnum("BMW i")]
        BMWi,
        TOYOTA
    }

    [AuthorAPI(SelectableTypeDeclaration = true)]
    //[Obsolete("Legacy Property, the ChassisType is retrieved from the Database and not used in test modules, thus it can be deleted.")]
    public enum ChassisType
    {
        LIM,
        TOU,
        COU,
        SAV,
        ROA,
        SH,
        CAB,
        SAT,
        HC,
        NONE,
        SAC,
        COM,
        CLU,
        HAT,
        SHA,
        UNKNOWN
    }

    public enum VisibilityType
    {
        Hidden,
        Collapsed,
        Visible
    }

    [AuthorAPI(SelectableTypeDeclaration = true)]
    public enum GwszUnitType
    {
        km,
        miles
    }

    [AuthorAPI(SelectableTypeDeclaration = true)]
    public enum IdentificationLevel
    {
        None,
        BasicFeatures,
        ReopenedOperation,
        VINOnly,
        VINBasedFeatures,
        VINBasedOnlineUpdated,
        VINVehicleReadout,
        VINVehicleReadoutOnlineUpdated,
        VehicleTypeNotLicensed
    }

    [AuthorAPI(SelectableTypeDeclaration = true)]
    public interface IVehicle : INotifyPropertyChanged
    {
        string AEKurzbezeichnung { get; }

        string AELeistungsklasse { get; }

        string AEUeberarbeitung { get; }

        string Abgas { get; set; }

        string Antrieb { get; set; }

        string ApplicationVersion { get; }

        BNMixed BNMixed { get; set; }

        BNType BNType { get; set; }

        string BasicType { get; }

        string Baureihe { get; set; }

        string Baureihenverbund { get; set; }

        string BaustandsJahr { get; }

        string BaustandsMonat { get; }

        BrandName? BrandName { get; }

        //IEnumerable<ICbsInfo> CBS { get; }

        bool CVDRequestFailed { get; set; }

        bool CvsRequestFailed { get; set; }

        ChassisType ChassisType { get; }

        //IEnumerable<IDtc> CombinedFaults { get; }

        VisibilityType ConnectIMIBIPState { get; }

        string ConnectIMIBImage { get; }

        string EMotBaureihe { get; }

        VisibilityType ConnectIMIBState { get; }

        VisibilityType ConnectIPState { get; }

        string ConnectImage { get; }

        VisibilityType ConnectState { get; }

        bool DOMRequestFailed { get; set; }

        //IEnumerable<IDiagCode> DiagCodes { get; }

        ObservableCollection<string> DiagCodesProgramming { get; }

        string Drehmoment { get; }

        string DriveType { get; }

        string ECTypeApproval { get; }

        IEnumerable<IEcu> ECU { get; }

        string Ereihe { get; set; }

        IFa FA { get; }

        bool FASTAAlreadyDone { get; }

        IEnumerable<IFfmResult> FFM { get; }

        DateTime? FirstRegistration { get; }

        string GMType { get; }

        string Getriebe { get; set; }

        string CountryOfAssembly { get; }

        string BaseVersion { get; }

        string Gsgbd { get; }

        string MainSeriesSgbd { get; }

        string MainSeriesSgbdAdditional { get; }

        decimal? Gwsz { get; }

        GwszUnitType? GwszUnit { get; }

        string Hubraum { get; set; }

        string Hybridkennzeichen { get; }

        string ILevel { get; set; }

        string ILevelBackup { get; set; }

        string ILevelWerk { get; }

        IEnumerable<decimal> InstalledAdapters { get; }

        bool KL15FaultILevelAlreadyAlerted { get; }

        bool KL15OverrideVoltageCheck { get; }

        string Karosserie { get; set; }

        string Kl15Voltage { get; }

        string Kl30Voltage { get; }

        DateTime KlVoltageLastMessageTime { get; }

        bool KlVoltageLastMessageTimeSpecified { get; }

        string Kraftstoffart { get; }

        string Land { get; set; }

        DateTime LastChangeDate { get; }

        DateTime LastSaveDate { get; }

        string Leistung { get; set; }

        string Leistungsklasse { get; }

        string Lenkung { get; set; }

        //IVciDevice MIB { get; }

        string MOTBezeichnung { get; set; }

        string MOTEinbaulage { get; }

        string MOTKraftstoffart { get; }

        string Marke { get; }

        string Modelljahr { get; }

        string Modellmonat { get; }

        string Modelltag { get; }

        string Motor { get; set; }

        string Motorarbeitsverfahren { get; }

        bool PADVehicle { get; set; }

        bool Pannenfall { get; }

        string Prodart { get; }

        DateTime ProductionDate { get; }

        bool ProductionDateSpecified { get; }

        string ProgmanVersion { get; }

        int PwfState { get; }

        bool RepHistoryRequestFailed { get; }

        int SelectedDiagBUS { get; }

        IEcu SelectedECU { get; }

        string SerialBodyShell { get; }

        string SerialEngine { get; }

        List<DealerSessionProperty> DealerSessionProperties { get; }

        string SerialGearBox { get; }

        //IEnumerable<IServiceHistoryEntry> ServiceHistory { get; }

        bool SimulatedParts { get; }

        string Status_FunctionName { get; }

        double Status_FunctionProgress { get; }

        StateType Status_FunctionState { get; }

        DateTime Status_FunctionStateLastChangeTime { get; }

        bool Status_FunctionStateLastChangeTimeSpecified { get; }

        bool TecCampaignsRequestFailed { get; }

        //IEnumerable<ITechnicalCampaign> TechnicalCampaigns { get; }

        string Typ { get; set; }

        string Ueberarbeitung { get; set; }

        IVciDevice VCI { get; }

        string VIN17 { get; set; }

        bool IsSendFastaDataForbidden { get; set; }

        bool IsSendFastaDataForbiddenBitsQueueFull { get; set; }

        string VIN17_OEM { get; }

        string VIN7 { get; }

        string VINType { get; }

        bool VehicleIdentAlreadyDone { get; }

        IdentificationLevel VehicleIdentLevel { get; }

        string VerkaufsBezeichnung { get; set; }

        string RoadMap { get; }

        string WarrentyType { get; }

        string ZCS { get; }

        //IEnumerable<IZfsResult> ZFS { get; }

        bool ZFS_SUCCESSFULLY { get; }

        string refSchema { get; }

        string version { get; }

        bool IsPowerSafeModeActive { get; }

        bool IsPowerSafeModeActiveByOldEcus { get; set; }

        bool IsPowerSafeModeActiveByNewEcus { get; set; }

        bool IsVehicleBreakdownAlreadyShown { get; set; }

        string ChassisCode { get; set; }

        bool OrderDataRequestFailed { get; set; }

        ITransmissionDataType TransmissionDataType { get; }

        string Produktlinie { get; set; }

        bool Sp2021Enabled { get; set; }

        DateTime? C_DATETIME { get; }

        DateTime VehicleLifeStartDate { get; set; }

        bool IsEcuIdentSuccessfull { get; set; }

        bool IsMotorcycle();

        IEcu getECU(long? sgAdr);

        IEcu getECU(long? sgAdr, long? subAddress);

        IEcu getECUbyECU_GRUPPE(string ECU_GRUPPE);

        IEcu getECUbyECU_SGBD(string ECU_SGBD);

        bool AddEcu(IEcu ecu);

        bool RemoveEcu(IEcu ecu);

        bool hasSA(string checkSA);

        bool IsProgrammingSupported(bool considerLogisticBase);

        bool IsVehicleWithOnlyVin7();

        bool IsEreiheValid();

        bool hasBusType(BusType bus);
    }
}
