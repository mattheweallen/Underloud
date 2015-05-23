#region Copyright
////////////////////////////////////////////////////////////////////////////////
// The following FIT Protocol software provided may be used with FIT protocol
// devices only and remains the copyrighted property of Dynastream Innovations Inc.
// The software is being provided on an "as-is" basis and as an accommodation,
// and therefore all warranties, representations, or guarantees of any kind
// (whether express, implied or statutory) including, without limitation,
// warranties of merchantability, non-infringement, or fitness for a particular
// purpose, are specifically disclaimed.
//
// Copyright 2015 Dynastream Innovations Inc.
////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 14.20Release
// Tag = development/akw/14.20.00
////////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;


namespace Underloud.Data.Entities.Fit
{
   /// <summary>
   /// Implements the BikeProfile profile message.
   /// </summary>  
   public class BikeProfileMesg : Mesg 
   {    
      #region Fields     
      #endregion

      #region Constructors                 
      public BikeProfileMesg() : base(Profile.mesgs[Profile.BikeProfileIndex])               
      {                 
      }
      
      public BikeProfileMesg(Mesg mesg) : base(mesg)
      {
      }
      #endregion // Constructors

      #region Methods    
      ///<summary>      
      /// Retrieves the MessageIndex field</summary>
      /// <returns>Returns nullable ushort representing the MessageIndex field</returns>      
      public ushort? GetMessageIndex()   
      {                
         return (ushort?)GetFieldValue(254, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set MessageIndex field</summary>
      /// <param name="messageIndex_">Nullable field value to be set</param>      
      public void SetMessageIndex(ushort? messageIndex_) 
      {  
         SetFieldValue(254, 0, messageIndex_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the Name field</summary>
      /// <returns>Returns byte[] representing the Name field</returns>      
      public byte[] GetName()   
      {                
         return (byte[])GetFieldValue(0, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set Name field</summary>
      /// <param name="name_">field value to be set</param>      
      public void SetName(byte[] name_) 
      {  
         SetFieldValue(0, 0, name_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the Sport field</summary>
      /// <returns>Returns nullable Sport enum representing the Sport field</returns>      
      public Sport? GetSport()   
      { 
         object obj = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
         Sport? value = obj == null ? (Sport?)null : (Sport)obj;
         return value;                     
      }

      /// <summary>        
      /// Set Sport field</summary>
      /// <param name="sport_">Nullable field value to be set</param>      
      public void SetSport(Sport? sport_) 
      {  
         SetFieldValue(1, 0, sport_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the SubSport field</summary>
      /// <returns>Returns nullable SubSport enum representing the SubSport field</returns>      
      public SubSport? GetSubSport()   
      { 
         object obj = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
         SubSport? value = obj == null ? (SubSport?)null : (SubSport)obj;
         return value;                     
      }

      /// <summary>        
      /// Set SubSport field</summary>
      /// <param name="subSport_">Nullable field value to be set</param>      
      public void SetSubSport(SubSport? subSport_) 
      {  
         SetFieldValue(2, 0, subSport_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the Odometer field
      /// Units: m</summary>
      /// <returns>Returns nullable float representing the Odometer field</returns>      
      public float? GetOdometer()   
      {                
         return (float?)GetFieldValue(3, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set Odometer field
      /// Units: m</summary>
      /// <param name="odometer_">Nullable field value to be set</param>      
      public void SetOdometer(float? odometer_) 
      {  
         SetFieldValue(3, 0, odometer_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the BikeSpdAntId field</summary>
      /// <returns>Returns nullable ushort representing the BikeSpdAntId field</returns>      
      public ushort? GetBikeSpdAntId()   
      {                
         return (ushort?)GetFieldValue(4, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set BikeSpdAntId field</summary>
      /// <param name="bikeSpdAntId_">Nullable field value to be set</param>      
      public void SetBikeSpdAntId(ushort? bikeSpdAntId_) 
      {  
         SetFieldValue(4, 0, bikeSpdAntId_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the BikeCadAntId field</summary>
      /// <returns>Returns nullable ushort representing the BikeCadAntId field</returns>      
      public ushort? GetBikeCadAntId()   
      {                
         return (ushort?)GetFieldValue(5, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set BikeCadAntId field</summary>
      /// <param name="bikeCadAntId_">Nullable field value to be set</param>      
      public void SetBikeCadAntId(ushort? bikeCadAntId_) 
      {  
         SetFieldValue(5, 0, bikeCadAntId_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the BikeSpdcadAntId field</summary>
      /// <returns>Returns nullable ushort representing the BikeSpdcadAntId field</returns>      
      public ushort? GetBikeSpdcadAntId()   
      {                
         return (ushort?)GetFieldValue(6, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set BikeSpdcadAntId field</summary>
      /// <param name="bikeSpdcadAntId_">Nullable field value to be set</param>      
      public void SetBikeSpdcadAntId(ushort? bikeSpdcadAntId_) 
      {  
         SetFieldValue(6, 0, bikeSpdcadAntId_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the BikePowerAntId field</summary>
      /// <returns>Returns nullable ushort representing the BikePowerAntId field</returns>      
      public ushort? GetBikePowerAntId()   
      {                
         return (ushort?)GetFieldValue(7, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set BikePowerAntId field</summary>
      /// <param name="bikePowerAntId_">Nullable field value to be set</param>      
      public void SetBikePowerAntId(ushort? bikePowerAntId_) 
      {  
         SetFieldValue(7, 0, bikePowerAntId_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the CustomWheelsize field
      /// Units: m</summary>
      /// <returns>Returns nullable float representing the CustomWheelsize field</returns>      
      public float? GetCustomWheelsize()   
      {                
         return (float?)GetFieldValue(8, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set CustomWheelsize field
      /// Units: m</summary>
      /// <param name="customWheelsize_">Nullable field value to be set</param>      
      public void SetCustomWheelsize(float? customWheelsize_) 
      {  
         SetFieldValue(8, 0, customWheelsize_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the AutoWheelsize field
      /// Units: m</summary>
      /// <returns>Returns nullable float representing the AutoWheelsize field</returns>      
      public float? GetAutoWheelsize()   
      {                
         return (float?)GetFieldValue(9, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set AutoWheelsize field
      /// Units: m</summary>
      /// <param name="autoWheelsize_">Nullable field value to be set</param>      
      public void SetAutoWheelsize(float? autoWheelsize_) 
      {  
         SetFieldValue(9, 0, autoWheelsize_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the BikeWeight field
      /// Units: kg</summary>
      /// <returns>Returns nullable float representing the BikeWeight field</returns>      
      public float? GetBikeWeight()   
      {                
         return (float?)GetFieldValue(10, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set BikeWeight field
      /// Units: kg</summary>
      /// <param name="bikeWeight_">Nullable field value to be set</param>      
      public void SetBikeWeight(float? bikeWeight_) 
      {  
         SetFieldValue(10, 0, bikeWeight_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the PowerCalFactor field
      /// Units: %</summary>
      /// <returns>Returns nullable float representing the PowerCalFactor field</returns>      
      public float? GetPowerCalFactor()   
      {                
         return (float?)GetFieldValue(11, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set PowerCalFactor field
      /// Units: %</summary>
      /// <param name="powerCalFactor_">Nullable field value to be set</param>      
      public void SetPowerCalFactor(float? powerCalFactor_) 
      {  
         SetFieldValue(11, 0, powerCalFactor_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the AutoWheelCal field</summary>
      /// <returns>Returns nullable Bool enum representing the AutoWheelCal field</returns>      
      public Bool? GetAutoWheelCal()   
      { 
         object obj = GetFieldValue(12, 0, Fit.SubfieldIndexMainField);
         Bool? value = obj == null ? (Bool?)null : (Bool)obj;
         return value;                     
      }

      /// <summary>        
      /// Set AutoWheelCal field</summary>
      /// <param name="autoWheelCal_">Nullable field value to be set</param>      
      public void SetAutoWheelCal(Bool? autoWheelCal_) 
      {  
         SetFieldValue(12, 0, autoWheelCal_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the AutoPowerZero field</summary>
      /// <returns>Returns nullable Bool enum representing the AutoPowerZero field</returns>      
      public Bool? GetAutoPowerZero()   
      { 
         object obj = GetFieldValue(13, 0, Fit.SubfieldIndexMainField);
         Bool? value = obj == null ? (Bool?)null : (Bool)obj;
         return value;                     
      }

      /// <summary>        
      /// Set AutoPowerZero field</summary>
      /// <param name="autoPowerZero_">Nullable field value to be set</param>      
      public void SetAutoPowerZero(Bool? autoPowerZero_) 
      {  
         SetFieldValue(13, 0, autoPowerZero_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the Id field</summary>
      /// <returns>Returns nullable byte representing the Id field</returns>      
      public byte? GetId()   
      {                
         return (byte?)GetFieldValue(14, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set Id field</summary>
      /// <param name="id_">Nullable field value to be set</param>      
      public void SetId(byte? id_) 
      {  
         SetFieldValue(14, 0, id_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the SpdEnabled field</summary>
      /// <returns>Returns nullable Bool enum representing the SpdEnabled field</returns>      
      public Bool? GetSpdEnabled()   
      { 
         object obj = GetFieldValue(15, 0, Fit.SubfieldIndexMainField);
         Bool? value = obj == null ? (Bool?)null : (Bool)obj;
         return value;                     
      }

      /// <summary>        
      /// Set SpdEnabled field</summary>
      /// <param name="spdEnabled_">Nullable field value to be set</param>      
      public void SetSpdEnabled(Bool? spdEnabled_) 
      {  
         SetFieldValue(15, 0, spdEnabled_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the CadEnabled field</summary>
      /// <returns>Returns nullable Bool enum representing the CadEnabled field</returns>      
      public Bool? GetCadEnabled()   
      { 
         object obj = GetFieldValue(16, 0, Fit.SubfieldIndexMainField);
         Bool? value = obj == null ? (Bool?)null : (Bool)obj;
         return value;                     
      }

      /// <summary>        
      /// Set CadEnabled field</summary>
      /// <param name="cadEnabled_">Nullable field value to be set</param>      
      public void SetCadEnabled(Bool? cadEnabled_) 
      {  
         SetFieldValue(16, 0, cadEnabled_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the SpdcadEnabled field</summary>
      /// <returns>Returns nullable Bool enum representing the SpdcadEnabled field</returns>      
      public Bool? GetSpdcadEnabled()   
      { 
         object obj = GetFieldValue(17, 0, Fit.SubfieldIndexMainField);
         Bool? value = obj == null ? (Bool?)null : (Bool)obj;
         return value;                     
      }

      /// <summary>        
      /// Set SpdcadEnabled field</summary>
      /// <param name="spdcadEnabled_">Nullable field value to be set</param>      
      public void SetSpdcadEnabled(Bool? spdcadEnabled_) 
      {  
         SetFieldValue(17, 0, spdcadEnabled_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the PowerEnabled field</summary>
      /// <returns>Returns nullable Bool enum representing the PowerEnabled field</returns>      
      public Bool? GetPowerEnabled()   
      { 
         object obj = GetFieldValue(18, 0, Fit.SubfieldIndexMainField);
         Bool? value = obj == null ? (Bool?)null : (Bool)obj;
         return value;                     
      }

      /// <summary>        
      /// Set PowerEnabled field</summary>
      /// <param name="powerEnabled_">Nullable field value to be set</param>      
      public void SetPowerEnabled(Bool? powerEnabled_) 
      {  
         SetFieldValue(18, 0, powerEnabled_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the CrankLength field
      /// Units: mm</summary>
      /// <returns>Returns nullable float representing the CrankLength field</returns>      
      public float? GetCrankLength()   
      {                
         return (float?)GetFieldValue(19, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set CrankLength field
      /// Units: mm</summary>
      /// <param name="crankLength_">Nullable field value to be set</param>      
      public void SetCrankLength(float? crankLength_) 
      {  
         SetFieldValue(19, 0, crankLength_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the Enabled field</summary>
      /// <returns>Returns nullable Bool enum representing the Enabled field</returns>      
      public Bool? GetEnabled()   
      { 
         object obj = GetFieldValue(20, 0, Fit.SubfieldIndexMainField);
         Bool? value = obj == null ? (Bool?)null : (Bool)obj;
         return value;                     
      }

      /// <summary>        
      /// Set Enabled field</summary>
      /// <param name="enabled_">Nullable field value to be set</param>      
      public void SetEnabled(Bool? enabled_) 
      {  
         SetFieldValue(20, 0, enabled_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the BikeSpdAntIdTransType field</summary>
      /// <returns>Returns nullable byte representing the BikeSpdAntIdTransType field</returns>      
      public byte? GetBikeSpdAntIdTransType()   
      {                
         return (byte?)GetFieldValue(21, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set BikeSpdAntIdTransType field</summary>
      /// <param name="bikeSpdAntIdTransType_">Nullable field value to be set</param>      
      public void SetBikeSpdAntIdTransType(byte? bikeSpdAntIdTransType_) 
      {  
         SetFieldValue(21, 0, bikeSpdAntIdTransType_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the BikeCadAntIdTransType field</summary>
      /// <returns>Returns nullable byte representing the BikeCadAntIdTransType field</returns>      
      public byte? GetBikeCadAntIdTransType()   
      {                
         return (byte?)GetFieldValue(22, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set BikeCadAntIdTransType field</summary>
      /// <param name="bikeCadAntIdTransType_">Nullable field value to be set</param>      
      public void SetBikeCadAntIdTransType(byte? bikeCadAntIdTransType_) 
      {  
         SetFieldValue(22, 0, bikeCadAntIdTransType_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the BikeSpdcadAntIdTransType field</summary>
      /// <returns>Returns nullable byte representing the BikeSpdcadAntIdTransType field</returns>      
      public byte? GetBikeSpdcadAntIdTransType()   
      {                
         return (byte?)GetFieldValue(23, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set BikeSpdcadAntIdTransType field</summary>
      /// <param name="bikeSpdcadAntIdTransType_">Nullable field value to be set</param>      
      public void SetBikeSpdcadAntIdTransType(byte? bikeSpdcadAntIdTransType_) 
      {  
         SetFieldValue(23, 0, bikeSpdcadAntIdTransType_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the BikePowerAntIdTransType field</summary>
      /// <returns>Returns nullable byte representing the BikePowerAntIdTransType field</returns>      
      public byte? GetBikePowerAntIdTransType()   
      {                
         return (byte?)GetFieldValue(24, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set BikePowerAntIdTransType field</summary>
      /// <param name="bikePowerAntIdTransType_">Nullable field value to be set</param>      
      public void SetBikePowerAntIdTransType(byte? bikePowerAntIdTransType_) 
      {  
         SetFieldValue(24, 0, bikePowerAntIdTransType_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the OdometerRollover field
      /// Comment: Rollover counter that can be used to extend the odometer</summary>
      /// <returns>Returns nullable byte representing the OdometerRollover field</returns>      
      public byte? GetOdometerRollover()   
      {                
         return (byte?)GetFieldValue(37, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set OdometerRollover field
      /// Comment: Rollover counter that can be used to extend the odometer</summary>
      /// <param name="odometerRollover_">Nullable field value to be set</param>      
      public void SetOdometerRollover(byte? odometerRollover_) 
      {  
         SetFieldValue(37, 0, odometerRollover_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the FrontGearNum field
      /// Comment: Number of front gears</summary>
      /// <returns>Returns nullable byte representing the FrontGearNum field</returns>      
      public byte? GetFrontGearNum()   
      {                
         return (byte?)GetFieldValue(38, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set FrontGearNum field
      /// Comment: Number of front gears</summary>
      /// <param name="frontGearNum_">Nullable field value to be set</param>      
      public void SetFrontGearNum(byte? frontGearNum_) 
      {  
         SetFieldValue(38, 0, frontGearNum_, Fit.SubfieldIndexMainField);
      }
          
      
      /// <summary>
      /// 
      /// </summary>  
      /// <returns>returns number of elements in field FrontGear</returns>      
      public int GetNumFrontGear() 
      {
         return GetNumFieldValues(39, Fit.SubfieldIndexMainField);
      }

      ///<summary>      
      /// Retrieves the FrontGear field
      /// Comment: Number of teeth on each gear 0 is innermost</summary>
      /// <param name="index">0 based index of FrontGear element to retrieve</param>
      /// <returns>Returns nullable byte representing the FrontGear field</returns>      
      public byte? GetFrontGear(int index)   
      {                
         return (byte?)GetFieldValue(39, index, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set FrontGear field
      /// Comment: Number of teeth on each gear 0 is innermost</summary>      
      /// <param name="index">0 based index of front_gear</param>
      /// <param name="frontGear_">Nullable field value to be set</param>      
      public void SetFrontGear(int index, byte? frontGear_) 
      {  
         SetFieldValue(39, index, frontGear_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the RearGearNum field
      /// Comment: Number of rear gears</summary>
      /// <returns>Returns nullable byte representing the RearGearNum field</returns>      
      public byte? GetRearGearNum()   
      {                
         return (byte?)GetFieldValue(40, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set RearGearNum field
      /// Comment: Number of rear gears</summary>
      /// <param name="rearGearNum_">Nullable field value to be set</param>      
      public void SetRearGearNum(byte? rearGearNum_) 
      {  
         SetFieldValue(40, 0, rearGearNum_, Fit.SubfieldIndexMainField);
      }
          
      
      /// <summary>
      /// 
      /// </summary>  
      /// <returns>returns number of elements in field RearGear</returns>      
      public int GetNumRearGear() 
      {
         return GetNumFieldValues(41, Fit.SubfieldIndexMainField);
      }

      ///<summary>      
      /// Retrieves the RearGear field
      /// Comment: Number of teeth on each gear 0 is innermost</summary>
      /// <param name="index">0 based index of RearGear element to retrieve</param>
      /// <returns>Returns nullable byte representing the RearGear field</returns>      
      public byte? GetRearGear(int index)   
      {                
         return (byte?)GetFieldValue(41, index, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set RearGear field
      /// Comment: Number of teeth on each gear 0 is innermost</summary>      
      /// <param name="index">0 based index of rear_gear</param>
      /// <param name="rearGear_">Nullable field value to be set</param>      
      public void SetRearGear(int index, byte? rearGear_) 
      {  
         SetFieldValue(41, index, rearGear_, Fit.SubfieldIndexMainField);
      }
                        
      #endregion // Methods
   } // Class
} // namespace
