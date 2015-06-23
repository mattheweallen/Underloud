using System;
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

      ///<summary>      
      /// Retrieves the VerticalOscillation field
      /// Units: mm</summary>
      /// <returns>Returns nullable float representing the VerticalOscillation field</returns>      
      public float? VerticalOscillation { get; set; }
      
      ///<summary>      
      /// Retrieves the StanceTimePercent field
      /// Units: percent</summary>
      /// <returns>Returns nullable float representing the StanceTimePercent field</returns>      
      public float? StanceTimePercent { get; set; }
      
      ///<summary>      
      /// Retrieves the StanceTime field
      /// Units: ms</summary>
      /// <returns>Returns nullable float representing the StanceTime field</returns>      
      public float? StanceTime { get; set; }
      
      ///<summary>      
      /// Retrieves the ActivityType field</summary>
      /// <returns>Returns nullable ActivityType enum representing the ActivityType field</returns>      
      public ActivityType? ActivityType { get; set; }
      
      ///<summary>      
      /// Retrieves the LeftTorqueEffectiveness field
      /// Units: percent</summary>
      /// <returns>Returns nullable float representing the LeftTorqueEffectiveness field</returns>      
      public float? LeftTorqueEffectiveness { get; set; }
      
      ///<summary>      
      /// Retrieves the RightTorqueEffectiveness field
      /// Units: percent</summary>
      /// <returns>Returns nullable float representing the RightTorqueEffectiveness field</returns>      
      public float? RightTorqueEffectiveness { get; set; }
      
      ///<summary>      
      /// Retrieves the LeftPedalSmoothness field
      /// Units: percent</summary>
      /// <returns>Returns nullable float representing the LeftPedalSmoothness field</returns>      
      public float? LeftPedalSmoothness { get; set; }
      
      ///<summary>      
      /// Retrieves the RightPedalSmoothness field
      /// Units: percent</summary>
      /// <returns>Returns nullable float representing the RightPedalSmoothness field</returns>      
      public float? RightPedalSmoothness { get; set; }
      
      ///<summary>      
      /// Retrieves the CombinedPedalSmoothness field
      /// Units: percent</summary>
      /// <returns>Returns nullable float representing the CombinedPedalSmoothness field</returns>      
      public float? CombinedPedalSmoothness { get; set; }
      
      ///<summary>      
      /// Retrieves the Time128 field
      /// Units: s</summary>
      /// <returns>Returns nullable float representing the Time128 field</returns>      
      public float? Time128 { get; set; }
      
      ///<summary>      
      /// Retrieves the StrokeType field</summary>
      /// <returns>Returns nullable StrokeType enum representing the StrokeType field</returns>      
      public StrokeType? StrokeType { get; set; }
      
      ///<summary>      
      /// Retrieves the Zone field</summary>
      /// <returns>Returns nullable byte representing the Zone field</returns>      
      public byte? Zone { get; set; }
     
      ///<summary>      
      /// Retrieves the BallSpeed field
      /// Units: m/s</summary>
      /// <returns>Returns nullable float representing the BallSpeed field</returns>      
      public float? BallSpeed { get; set; }
     
      ///<summary>      
      /// Retrieves the Cadence256 field
      /// Units: rpm
      /// Comment: Log cadence and fractional cadence for backwards compatability</summary>
      /// <returns>Returns nullable float representing the Cadence256 field</returns>      
      public float? Cadence256 { get; set; }
     
      ///<summary>      
      /// Retrieves the FractionalCadence field
      /// Units: rpm</summary>
      /// <returns>Returns nullable float representing the FractionalCadence field</returns>      
      public float? FractionalCadence { get; set; }
     
      ///<summary>      
      /// Retrieves the TotalHemoglobinConc field
      /// Units: g/dL
      /// Comment: Total saturated and unsaturated hemoglobin</summary>
      /// <returns>Returns nullable float representing the TotalHemoglobinConc field</returns>      
      public float? TotalHemoglobinConc { get; set; }
     
      ///<summary>      
      /// Retrieves the TotalHemoglobinConcMin field
      /// Units: g/dL
      /// Comment: Min saturated and unsaturated hemoglobin</summary>
      /// <returns>Returns nullable float representing the TotalHemoglobinConcMin field</returns>      
      public float? TotalHemoglobinConcMin { get; set; }
     
      ///<summary>      
      /// Retrieves the TotalHemoglobinConcMax field
      /// Units: g/dL
      /// Comment: Max saturated and unsaturated hemoglobin</summary>
      /// <returns>Returns nullable float representing the TotalHemoglobinConcMax field</returns>      
      public float? TotalHemoglobinConcMax { get; set; }
     
      ///<summary>      
      /// Retrieves the SaturatedHemoglobinPercent field
      /// Units: %
      /// Comment: Percentage of hemoglobin saturated with oxygen</summary>
      /// <returns>Returns nullable float representing the SaturatedHemoglobinPercent field</returns>      
      public float? SaturatedHemoglobinPercent { get; set; }
     
      ///<summary>      
      /// Retrieves the SaturatedHemoglobinPercentMin field
      /// Units: %
      /// Comment: Min percentage of hemoglobin saturated with oxygen</summary>
      /// <returns>Returns nullable float representing the SaturatedHemoglobinPercentMin field</returns>      
      public float? SaturatedHemoglobinPercentMin { get; set; }
     
      ///<summary>      
      /// Retrieves the SaturatedHemoglobinPercentMax field
      /// Units: %
      /// Comment: Max percentage of hemoglobin saturated with oxygen</summary>
      /// <returns>Returns nullable float representing the SaturatedHemoglobinPercentMax field</returns>      
      public float? SaturatedHemoglobinPercentMax { get; set; }
     
      ///<summary>      
      /// Retrieves the DeviceIndex field</summary>
      /// <returns>Returns nullable byte representing the DeviceIndex field</returns>      
      public byte? DeviceIndex { get; set; }
     
      ///<summary>      
      /// Retrieves the LeftPco field
      /// Units: mm
      /// Comment: Left platform center offset</summary>
      /// <returns>Returns nullable sbyte representing the LeftPco field</returns>      
      public sbyte? LeftPco { get; set; }
     
      ///<summary>      
      /// Retrieves the RightPco field
      /// Units: mm
      /// Comment: Right platform center offset</summary>
      /// <returns>Returns nullable sbyte representing the RightPco field</returns>      
      public sbyte? RightPco { get; set; }    
   } 
} 
