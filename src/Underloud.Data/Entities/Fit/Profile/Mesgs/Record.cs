﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Underloud.Data.Entities.Fit.Profile.Mesgs
{
    public class Record
    {   
        ///<summary>      
        /// Retrieves and Sets the Timestamp field
        /// Units: s</summary>
        /// <returns>Returns DateTime representing the Timestamp field</returns>     
        /// <param name="timestamp_">Nullable field value to be set</param>
        public DateTime Timestamp { get; set; }

        ///<summary>      
        /// Retrieves and Sets the PositionLat field
        /// Units: semicircles</summary>
        /// <returns>Returns nullable int representing the PositionLat field</returns>  
        /// <param name="positionLat_">Nullable field value to be set</param>   
        public int? PositionLat { get; set; }   
      
          
        ///<summary>      
        /// Retrieves and Sets the PositionLong field
        /// Units: semicircles</summary>
        /// <returns>Returns nullable int representing the PositionLong field</returns>      
        /// <param name="positionLong_">Nullable field value to be set</param>      
        public int? PositionLong { get; set; }
          
        ///<summary>      
        /// Retrieves and Sets the Altitude field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the Altitude field</returns>  
        /// <param name="altitude_">Nullable field value to be set</param>
        public float? Altitude { get; set; }
          
        ///<summary>      
        /// Retrieves the HeartRate field
        /// Units: bpm</summary>
        /// <returns>Returns nullable byte representing the HeartRate field</returns>
        /// <param name="heartRate_">Nullable field value to be set</param>
        public byte? HeartRate { get; set; }   
          
        ///<summary>      
        /// Retrieves the Cadence field
        /// Units: rpm</summary>
        /// <returns>Returns nullable byte representing the Cadence field</returns>      
        /// <param name="cadence_">Nullable field value to be set</param>
        public byte? Cadence { get; set; }
          
        ///<summary>      
        /// Retrieves the Distance field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the Distance field</returns>      
        /// <param name="distance_">Nullable field value to be set</param>
        public float? Distance { get; set; }
       
          
        ///<summary>      
        /// Retrieves the Speed field
        /// Units: m/s</summary>
        /// <returns>Returns nullable float representing the Speed field</returns>
        /// <param name="speed_">Nullable field value to be set</param>
        public float? Speed { get; set; }
          
        ///<summary>      
        /// Retrieves the Power field
        /// Units: watts</summary>
        /// <returns>Returns nullable ushort representing the Power field</returns>  
        /// <param name="power_">Nullable field value to be set</param>
        public ushort? Power { get; set; }
          
        ///<summary>      
        /// Retrieves the Grade field
        /// Units: %</summary>
        /// <returns>Returns nullable float representing the Grade field</returns>      
        /// <param name="grade_">Nullable field value to be set</param>
        public float? Grade { get; set; }
          
        ///<summary>      
        /// Retrieves the Resistance field
        /// Comment: Relative. 0 is none  254 is Max.</summary>
        /// <returns>Returns nullable byte representing the Resistance field</returns>      
        /// <param name="resistance_">Nullable field value to be set</param>    
        public byte? Resistance { get; set; }
  
        ///<summary>      
        /// Retrieves the TimeFromCourse field
        /// Units: s</summary>
        /// <returns>Returns nullable float representing the TimeFromCourse field</returns>  
        /// <param name="timeFromCourse_">Nullable field value to be set</param>
        public float? TimeFromCourse { get; set; }
          
        ///<summary>      
        /// Retrieves the CycleLength field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the CycleLength field</returns> 
        /// <param name="cycleLength_">Nullable field value to be set</param>
        public float? CycleLength { get; set; }
          
        ///<summary>      
        /// Retrieves the Temperature field
        /// Units: C</summary>
        /// <returns>Returns nullable sbyte representing the Temperature field</returns>  
        /// <param name="temperature_">Nullable field value to be set</param>
        public sbyte? Temperature { get; set; }

        ///<summary>      
        /// Retrieves the EnhancedSpeed field
        /// Units: m/s</summary>
        /// <returns>Returns nullable float representing the EnhancedSpeed field</returns> 
        /// <param name="enhancedSpeed_">Nullable field value to be set</param>
        public float? EnhancedSpeed { get; set; }

        ///<summary>      
        /// Retrieves the EnhancedAltitude field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the EnhancedAltitude field</returns> 
        /// <param name="enhancedAltitude_">Nullable field value to be set</param>
        public float? EnhancedAltitude { get; set; }

        ///<summary>      
        /// Retrieves the BatterySoc field
        /// Units: percent
        /// Comment: lev battery state of charge</summary>
        /// <returns>Returns nullable float representing the BatterySoc field</returns>  
        /// <param name="batterySoc_">Nullable field value to be set</param>
        public float? BatterySoc { get; set; }

        ///<summary>      
        /// Retrieves the MotorPower field
        /// Units: watts
        /// Comment: lev motor power</summary>
        /// <returns>Returns nullable ushort representing the MotorPower field</returns>
        /// <param name="motorPower_">Nullable field value to be set</param>  
        public ushort? MotorPower { get; set; }

      ///// <summary>
      ///// 
      ///// </summary>  
      ///// <returns>returns number of elements in field Speed1s</returns>      
      //public int GetNumSpeed1s()
      //{
      //    return GetNumFieldValues(17, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the Speed1s field
      ///// Units: m/s
      ///// Comment: Speed at 1s intervals.  Timestamp field indicates time of last array element.</summary>
      ///// <param name="index">0 based index of Speed1s element to retrieve</param>
      ///// <returns>Returns nullable float representing the Speed1s field</returns>      
      //public float? GetSpeed1s(int index)
      //{
      //    return (float?)GetFieldValue(17, index, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set Speed1s field
      ///// Units: m/s
      ///// Comment: Speed at 1s intervals.  Timestamp field indicates time of last array element.</summary>      
      ///// <param name="index">0 based index of speed_1s</param>
      ///// <param name="speed1s_">Nullable field value to be set</param>      
      //public void SetSpeed1s(int index, float? speed1s_)
      //{
      //    SetFieldValue(17, index, speed1s_, Fit.SubfieldIndexMainField);
      //}

        ///<summary>      
        /// Retrieves the Cycles field
        /// Units: cycles</summary>
        /// <returns>Returns nullable byte representing the Cycles field</returns>   
        /// <param name="cycles_">Nullable field value to be set</param> 
        public byte? Cycles { get; set; }

        ///<summary>      
        /// Retrieves the TotalCycles field
        /// Units: cycles</summary>
        /// <returns>Returns nullable uint representing the TotalCycles field</returns> 
        /// <param name="totalCycles_">Nullable field value to be set</param>
        public uint? TotalCycles { get; set; }
          
      /////<summary>      
      ///// Retrieves the CompressedAccumulatedPower field
      ///// Units: watts</summary>
      ///// <returns>Returns nullable ushort representing the CompressedAccumulatedPower field</returns>      
      //public ushort? GetCompressedAccumulatedPower()   
      //{                
      //   return (ushort?)GetFieldValue(28, 0, Fit.SubfieldIndexMainField);                     
      //}

      ///// <summary>        
      ///// Set CompressedAccumulatedPower field
      ///// Units: watts</summary>
      ///// <param name="compressedAccumulatedPower_">Nullable field value to be set</param>      
      //public void SetCompressedAccumulatedPower(ushort? compressedAccumulatedPower_) 
      //{  
      //   SetFieldValue(28, 0, compressedAccumulatedPower_, Fit.SubfieldIndexMainField);
      //}

      ///<summary>      
      /// Retrieves the AccumulatedPower field
      /// Units: watts</summary>
      /// <returns>Returns nullable uint representing the AccumulatedPower field</returns>  
      /// <param name="accumulatedPower_">Nullable field value to be set</param> 
      public uint? AccumulatedPower { get; set; }


      ///<summary>      
      /// Retrieves the LeftRightBalance field</summary>
      /// <returns>Returns nullable byte representing the LeftRightBalance field</returns> 
      /// <param name="leftRightBalance_">Nullable field value to be set</param>
      public byte? LeftRightBalance { get; set; }

      ///<summary>      
      /// Retrieves the GpsAccuracy field
      /// Units: m</summary>
      /// <returns>Returns nullable byte representing the GpsAccuracy field</returns>
      /// <param name="gpsAccuracy_">Nullable field value to be set</param>
      public byte? GpsAccuracy { get; set; }

      ///<summary>      
      /// Retrieves the VerticalSpeed field
      /// Units: m/s</summary>
      /// <returns>Returns nullable float representing the VerticalSpeed field</returns> 
      /// <param name="verticalSpeed_">Nullable field value to be set</param>
      public float? VerticalSpeed { get; set; }

      ///<summary>      
      /// Retrieves the Calories field
      /// Units: kcal</summary>
      /// <returns>Returns nullable ushort representing the Calories field</returns>
      /// <param name="calories_">Nullable field value to be set</param>
      public ushort? Calories { get; set; }

      /////<summary>      
      ///// Retrieves the VerticalOscillation field
      ///// Units: mm</summary>
      ///// <returns>Returns nullable float representing the VerticalOscillation field</returns>      
      //public float? GetVerticalOscillation()
      //{
      //    return (float?)GetFieldValue(39, 0, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set VerticalOscillation field
      ///// Units: mm</summary>
      ///// <param name="verticalOscillation_">Nullable field value to be set</param>      
      //public void SetVerticalOscillation(float? verticalOscillation_)
      //{
      //    SetFieldValue(39, 0, verticalOscillation_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the StanceTimePercent field
      ///// Units: percent</summary>
      ///// <returns>Returns nullable float representing the StanceTimePercent field</returns>      
      //public float? GetStanceTimePercent()
      //{
      //    return (float?)GetFieldValue(40, 0, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set StanceTimePercent field
      ///// Units: percent</summary>
      ///// <param name="stanceTimePercent_">Nullable field value to be set</param>      
      //public void SetStanceTimePercent(float? stanceTimePercent_)
      //{
      //    SetFieldValue(40, 0, stanceTimePercent_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the StanceTime field
      ///// Units: ms</summary>
      ///// <returns>Returns nullable float representing the StanceTime field</returns>      
      //public float? GetStanceTime()
      //{
      //    return (float?)GetFieldValue(41, 0, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set StanceTime field
      ///// Units: ms</summary>
      ///// <param name="stanceTime_">Nullable field value to be set</param>      
      //public void SetStanceTime(float? stanceTime_)
      //{
      //    SetFieldValue(41, 0, stanceTime_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the ActivityType field</summary>
      ///// <returns>Returns nullable ActivityType enum representing the ActivityType field</returns>      
      //public ActivityType? GetActivityType()
      //{
      //    object obj = GetFieldValue(42, 0, Fit.SubfieldIndexMainField);
      //    ActivityType? value = obj == null ? (ActivityType?)null : (ActivityType)obj;
      //    return value;
      //}

      ///// <summary>        
      ///// Set ActivityType field</summary>
      ///// <param name="activityType_">Nullable field value to be set</param>      
      //public void SetActivityType(ActivityType? activityType_)
      //{
      //    SetFieldValue(42, 0, activityType_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the LeftTorqueEffectiveness field
      ///// Units: percent</summary>
      ///// <returns>Returns nullable float representing the LeftTorqueEffectiveness field</returns>      
      //public float? GetLeftTorqueEffectiveness()
      //{
      //    return (float?)GetFieldValue(43, 0, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set LeftTorqueEffectiveness field
      ///// Units: percent</summary>
      ///// <param name="leftTorqueEffectiveness_">Nullable field value to be set</param>      
      //public void SetLeftTorqueEffectiveness(float? leftTorqueEffectiveness_)
      //{
      //    SetFieldValue(43, 0, leftTorqueEffectiveness_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the RightTorqueEffectiveness field
      ///// Units: percent</summary>
      ///// <returns>Returns nullable float representing the RightTorqueEffectiveness field</returns>      
      //public float? GetRightTorqueEffectiveness()
      //{
      //    return (float?)GetFieldValue(44, 0, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set RightTorqueEffectiveness field
      ///// Units: percent</summary>
      ///// <param name="rightTorqueEffectiveness_">Nullable field value to be set</param>      
      //public void SetRightTorqueEffectiveness(float? rightTorqueEffectiveness_)
      //{
      //    SetFieldValue(44, 0, rightTorqueEffectiveness_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the LeftPedalSmoothness field
      ///// Units: percent</summary>
      ///// <returns>Returns nullable float representing the LeftPedalSmoothness field</returns>      
      //public float? GetLeftPedalSmoothness()
      //{
      //    return (float?)GetFieldValue(45, 0, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set LeftPedalSmoothness field
      ///// Units: percent</summary>
      ///// <param name="leftPedalSmoothness_">Nullable field value to be set</param>      
      //public void SetLeftPedalSmoothness(float? leftPedalSmoothness_)
      //{
      //    SetFieldValue(45, 0, leftPedalSmoothness_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the RightPedalSmoothness field
      ///// Units: percent</summary>
      ///// <returns>Returns nullable float representing the RightPedalSmoothness field</returns>      
      //public float? GetRightPedalSmoothness()
      //{
      //    return (float?)GetFieldValue(46, 0, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set RightPedalSmoothness field
      ///// Units: percent</summary>
      ///// <param name="rightPedalSmoothness_">Nullable field value to be set</param>      
      //public void SetRightPedalSmoothness(float? rightPedalSmoothness_)
      //{
      //    SetFieldValue(46, 0, rightPedalSmoothness_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the CombinedPedalSmoothness field
      ///// Units: percent</summary>
      ///// <returns>Returns nullable float representing the CombinedPedalSmoothness field</returns>      
      //public float? GetCombinedPedalSmoothness()
      //{
      //    return (float?)GetFieldValue(47, 0, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set CombinedPedalSmoothness field
      ///// Units: percent</summary>
      ///// <param name="combinedPedalSmoothness_">Nullable field value to be set</param>      
      //public void SetCombinedPedalSmoothness(float? combinedPedalSmoothness_)
      //{
      //    SetFieldValue(47, 0, combinedPedalSmoothness_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the Time128 field
      ///// Units: s</summary>
      ///// <returns>Returns nullable float representing the Time128 field</returns>      
      //public float? GetTime128()
      //{
      //    return (float?)GetFieldValue(48, 0, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set Time128 field
      ///// Units: s</summary>
      ///// <param name="time128_">Nullable field value to be set</param>      
      //public void SetTime128(float? time128_)
      //{
      //    SetFieldValue(48, 0, time128_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the StrokeType field</summary>
      ///// <returns>Returns nullable StrokeType enum representing the StrokeType field</returns>      
      //public StrokeType? GetStrokeType()
      //{
      //    object obj = GetFieldValue(49, 0, Fit.SubfieldIndexMainField);
      //    StrokeType? value = obj == null ? (StrokeType?)null : (StrokeType)obj;
      //    return value;
      //}

      ///// <summary>        
      ///// Set StrokeType field</summary>
      ///// <param name="strokeType_">Nullable field value to be set</param>      
      //public void SetStrokeType(StrokeType? strokeType_)
      //{
      //    SetFieldValue(49, 0, strokeType_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the Zone field</summary>
      ///// <returns>Returns nullable byte representing the Zone field</returns>      
      //public byte? GetZone()
      //{
      //    return (byte?)GetFieldValue(50, 0, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set Zone field</summary>
      ///// <param name="zone_">Nullable field value to be set</param>      
      //public void SetZone(byte? zone_)
      //{
      //    SetFieldValue(50, 0, zone_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the BallSpeed field
      ///// Units: m/s</summary>
      ///// <returns>Returns nullable float representing the BallSpeed field</returns>      
      //public float? GetBallSpeed()
      //{
      //    return (float?)GetFieldValue(51, 0, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set BallSpeed field
      ///// Units: m/s</summary>
      ///// <param name="ballSpeed_">Nullable field value to be set</param>      
      //public void SetBallSpeed(float? ballSpeed_)
      //{
      //    SetFieldValue(51, 0, ballSpeed_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the Cadence256 field
      ///// Units: rpm
      ///// Comment: Log cadence and fractional cadence for backwards compatability</summary>
      ///// <returns>Returns nullable float representing the Cadence256 field</returns>      
      //public float? GetCadence256()
      //{
      //    return (float?)GetFieldValue(52, 0, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set Cadence256 field
      ///// Units: rpm
      ///// Comment: Log cadence and fractional cadence for backwards compatability</summary>
      ///// <param name="cadence256_">Nullable field value to be set</param>      
      //public void SetCadence256(float? cadence256_)
      //{
      //    SetFieldValue(52, 0, cadence256_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the FractionalCadence field
      ///// Units: rpm</summary>
      ///// <returns>Returns nullable float representing the FractionalCadence field</returns>      
      //public float? GetFractionalCadence()
      //{
      //    return (float?)GetFieldValue(53, 0, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set FractionalCadence field
      ///// Units: rpm</summary>
      ///// <param name="fractionalCadence_">Nullable field value to be set</param>      
      //public void SetFractionalCadence(float? fractionalCadence_)
      //{
      //    SetFieldValue(53, 0, fractionalCadence_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the TotalHemoglobinConc field
      ///// Units: g/dL
      ///// Comment: Total saturated and unsaturated hemoglobin</summary>
      ///// <returns>Returns nullable float representing the TotalHemoglobinConc field</returns>      
      //public float? GetTotalHemoglobinConc()
      //{
      //    return (float?)GetFieldValue(54, 0, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set TotalHemoglobinConc field
      ///// Units: g/dL
      ///// Comment: Total saturated and unsaturated hemoglobin</summary>
      ///// <param name="totalHemoglobinConc_">Nullable field value to be set</param>      
      //public void SetTotalHemoglobinConc(float? totalHemoglobinConc_)
      //{
      //    SetFieldValue(54, 0, totalHemoglobinConc_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the TotalHemoglobinConcMin field
      ///// Units: g/dL
      ///// Comment: Min saturated and unsaturated hemoglobin</summary>
      ///// <returns>Returns nullable float representing the TotalHemoglobinConcMin field</returns>      
      //public float? GetTotalHemoglobinConcMin()
      //{
      //    return (float?)GetFieldValue(55, 0, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set TotalHemoglobinConcMin field
      ///// Units: g/dL
      ///// Comment: Min saturated and unsaturated hemoglobin</summary>
      ///// <param name="totalHemoglobinConcMin_">Nullable field value to be set</param>      
      //public void SetTotalHemoglobinConcMin(float? totalHemoglobinConcMin_)
      //{
      //    SetFieldValue(55, 0, totalHemoglobinConcMin_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the TotalHemoglobinConcMax field
      ///// Units: g/dL
      ///// Comment: Max saturated and unsaturated hemoglobin</summary>
      ///// <returns>Returns nullable float representing the TotalHemoglobinConcMax field</returns>      
      //public float? GetTotalHemoglobinConcMax()
      //{
      //    return (float?)GetFieldValue(56, 0, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set TotalHemoglobinConcMax field
      ///// Units: g/dL
      ///// Comment: Max saturated and unsaturated hemoglobin</summary>
      ///// <param name="totalHemoglobinConcMax_">Nullable field value to be set</param>      
      //public void SetTotalHemoglobinConcMax(float? totalHemoglobinConcMax_)
      //{
      //    SetFieldValue(56, 0, totalHemoglobinConcMax_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the SaturatedHemoglobinPercent field
      ///// Units: %
      ///// Comment: Percentage of hemoglobin saturated with oxygen</summary>
      ///// <returns>Returns nullable float representing the SaturatedHemoglobinPercent field</returns>      
      //public float? GetSaturatedHemoglobinPercent()
      //{
      //    return (float?)GetFieldValue(57, 0, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set SaturatedHemoglobinPercent field
      ///// Units: %
      ///// Comment: Percentage of hemoglobin saturated with oxygen</summary>
      ///// <param name="saturatedHemoglobinPercent_">Nullable field value to be set</param>      
      //public void SetSaturatedHemoglobinPercent(float? saturatedHemoglobinPercent_)
      //{
      //    SetFieldValue(57, 0, saturatedHemoglobinPercent_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the SaturatedHemoglobinPercentMin field
      ///// Units: %
      ///// Comment: Min percentage of hemoglobin saturated with oxygen</summary>
      ///// <returns>Returns nullable float representing the SaturatedHemoglobinPercentMin field</returns>      
      //public float? GetSaturatedHemoglobinPercentMin()
      //{
      //    return (float?)GetFieldValue(58, 0, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set SaturatedHemoglobinPercentMin field
      ///// Units: %
      ///// Comment: Min percentage of hemoglobin saturated with oxygen</summary>
      ///// <param name="saturatedHemoglobinPercentMin_">Nullable field value to be set</param>      
      //public void SetSaturatedHemoglobinPercentMin(float? saturatedHemoglobinPercentMin_)
      //{
      //    SetFieldValue(58, 0, saturatedHemoglobinPercentMin_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the SaturatedHemoglobinPercentMax field
      ///// Units: %
      ///// Comment: Max percentage of hemoglobin saturated with oxygen</summary>
      ///// <returns>Returns nullable float representing the SaturatedHemoglobinPercentMax field</returns>      
      //public float? GetSaturatedHemoglobinPercentMax()
      //{
      //    return (float?)GetFieldValue(59, 0, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set SaturatedHemoglobinPercentMax field
      ///// Units: %
      ///// Comment: Max percentage of hemoglobin saturated with oxygen</summary>
      ///// <param name="saturatedHemoglobinPercentMax_">Nullable field value to be set</param>      
      //public void SetSaturatedHemoglobinPercentMax(float? saturatedHemoglobinPercentMax_)
      //{
      //    SetFieldValue(59, 0, saturatedHemoglobinPercentMax_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the DeviceIndex field</summary>
      ///// <returns>Returns nullable byte representing the DeviceIndex field</returns>      
      //public byte? GetDeviceIndex()
      //{
      //    return (byte?)GetFieldValue(62, 0, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set DeviceIndex field</summary>
      ///// <param name="deviceIndex_">Nullable field value to be set</param>      
      //public void SetDeviceIndex(byte? deviceIndex_)
      //{
      //    SetFieldValue(62, 0, deviceIndex_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the LeftPco field
      ///// Units: mm
      ///// Comment: Left platform center offset</summary>
      ///// <returns>Returns nullable sbyte representing the LeftPco field</returns>      
      //public sbyte? GetLeftPco()
      //{
      //    return (sbyte?)GetFieldValue(67, 0, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set LeftPco field
      ///// Units: mm
      ///// Comment: Left platform center offset</summary>
      ///// <param name="leftPco_">Nullable field value to be set</param>      
      //public void SetLeftPco(sbyte? leftPco_)
      //{
      //    SetFieldValue(67, 0, leftPco_, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the RightPco field
      ///// Units: mm
      ///// Comment: Right platform center offset</summary>
      ///// <returns>Returns nullable sbyte representing the RightPco field</returns>      
      //public sbyte? GetRightPco()
      //{
      //    return (sbyte?)GetFieldValue(68, 0, Fit.SubfieldIndexMainField);
      //}

      ///// <summary>        
      ///// Set RightPco field
      ///// Units: mm
      ///// Comment: Right platform center offset</summary>
      ///// <param name="rightPco_">Nullable field value to be set</param>      
      //public void SetRightPco(sbyte? rightPco_)
      //{
      //    SetFieldValue(68, 0, rightPco_, Fit.SubfieldIndexMainField);
      //}
          
      
      ///// <summary>
      ///// 
      ///// </summary>  
      ///// <returns>returns number of elements in field LeftPowerPhase</returns>      
      //public int GetNumLeftPowerPhase() 
      //{
      //   return GetNumFieldValues(69, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the LeftPowerPhase field
      ///// Units: degrees
      ///// Comment: Left power phase angles. Data value indexes defined by power_phase_type.</summary>
      ///// <param name="index">0 based index of LeftPowerPhase element to retrieve</param>
      ///// <returns>Returns nullable float representing the LeftPowerPhase field</returns>      
      //public float? GetLeftPowerPhase(int index)   
      //{                
      //   return (float?)GetFieldValue(69, index, Fit.SubfieldIndexMainField);                     
      //}

      ///// <summary>        
      ///// Set LeftPowerPhase field
      ///// Units: degrees
      ///// Comment: Left power phase angles. Data value indexes defined by power_phase_type.</summary>      
      ///// <param name="index">0 based index of left_power_phase</param>
      ///// <param name="leftPowerPhase_">Nullable field value to be set</param>      
      //public void SetLeftPowerPhase(int index, float? leftPowerPhase_) 
      //{  
      //   SetFieldValue(69, index, leftPowerPhase_, Fit.SubfieldIndexMainField);
      //}
          
      
      ///// <summary>
      ///// 
      ///// </summary>  
      ///// <returns>returns number of elements in field LeftPowerPhasePeak</returns>      
      //public int GetNumLeftPowerPhasePeak() 
      //{
      //   return GetNumFieldValues(70, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the LeftPowerPhasePeak field
      ///// Units: degrees
      ///// Comment: Left power phase peak angles. Data value indexes defined by power_phase_type.</summary>
      ///// <param name="index">0 based index of LeftPowerPhasePeak element to retrieve</param>
      ///// <returns>Returns nullable float representing the LeftPowerPhasePeak field</returns>      
      //public float? GetLeftPowerPhasePeak(int index)   
      //{                
      //   return (float?)GetFieldValue(70, index, Fit.SubfieldIndexMainField);                     
      //}

      ///// <summary>        
      ///// Set LeftPowerPhasePeak field
      ///// Units: degrees
      ///// Comment: Left power phase peak angles. Data value indexes defined by power_phase_type.</summary>      
      ///// <param name="index">0 based index of left_power_phase_peak</param>
      ///// <param name="leftPowerPhasePeak_">Nullable field value to be set</param>      
      //public void SetLeftPowerPhasePeak(int index, float? leftPowerPhasePeak_) 
      //{  
      //   SetFieldValue(70, index, leftPowerPhasePeak_, Fit.SubfieldIndexMainField);
      //}
          
      
      ///// <summary>
      ///// 
      ///// </summary>  
      ///// <returns>returns number of elements in field RightPowerPhase</returns>      
      //public int GetNumRightPowerPhase() 
      //{
      //   return GetNumFieldValues(71, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the RightPowerPhase field
      ///// Units: degrees
      ///// Comment: Right power phase angles. Data value indexes defined by power_phase_type.</summary>
      ///// <param name="index">0 based index of RightPowerPhase element to retrieve</param>
      ///// <returns>Returns nullable float representing the RightPowerPhase field</returns>      
      //public float? GetRightPowerPhase(int index)   
      //{                
      //   return (float?)GetFieldValue(71, index, Fit.SubfieldIndexMainField);                     
      //}

      ///// <summary>        
      ///// Set RightPowerPhase field
      ///// Units: degrees
      ///// Comment: Right power phase angles. Data value indexes defined by power_phase_type.</summary>      
      ///// <param name="index">0 based index of right_power_phase</param>
      ///// <param name="rightPowerPhase_">Nullable field value to be set</param>      
      //public void SetRightPowerPhase(int index, float? rightPowerPhase_) 
      //{  
      //   SetFieldValue(71, index, rightPowerPhase_, Fit.SubfieldIndexMainField);
      //}
          
      
      ///// <summary>
      ///// 
      ///// </summary>  
      ///// <returns>returns number of elements in field RightPowerPhasePeak</returns>      
      //public int GetNumRightPowerPhasePeak() 
      //{
      //   return GetNumFieldValues(72, Fit.SubfieldIndexMainField);
      //}

      /////<summary>      
      ///// Retrieves the RightPowerPhasePeak field
      ///// Units: degrees
      ///// Comment: Right power phase peak angles. Data value indexes defined by power_phase_type.</summary>
      ///// <param name="index">0 based index of RightPowerPhasePeak element to retrieve</param>
      ///// <returns>Returns nullable float representing the RightPowerPhasePeak field</returns>      
      //public float? GetRightPowerPhasePeak(int index)   
      //{                
      //   return (float?)GetFieldValue(72, index, Fit.SubfieldIndexMainField);                     
      //}

      ///// <summary>        
      ///// Set RightPowerPhasePeak field
      ///// Units: degrees
      ///// Comment: Right power phase peak angles. Data value indexes defined by power_phase_type.</summary>      
      ///// <param name="index">0 based index of right_power_phase_peak</param>
      ///// <param name="rightPowerPhasePeak_">Nullable field value to be set</param>      
      //public void SetRightPowerPhasePeak(int index, float? rightPowerPhasePeak_) 
      //{  
      //   SetFieldValue(72, index, rightPowerPhasePeak_, Fit.SubfieldIndexMainField);
      //}    
   } 
} 
