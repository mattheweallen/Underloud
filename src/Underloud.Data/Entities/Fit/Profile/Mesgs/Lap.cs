using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Underloud.Data.Entities.Fit.Profile.Mesgs
{
    public class Lap
    {
        public ushort? MessageIndex { get; set; }
        
        ///<summary>      
        /// Retrieves the Timestamp field
        /// Units: s
        /// Comment: Lap end time.</summary>
        /// <returns>Returns DateTime representing the Timestamp field</returns>      
        public DateTime Timestamp { get; set; }
        
        ///<summary>      
        /// Retrieves the Event field</summary>
        /// <returns>Returns nullable Event enum representing the Event field</returns>      
        public Event? Event { get; set; }
        
        ///<summary>      
        /// Retrieves the EventType field</summary>
        /// <returns>Returns nullable EventType enum representing the EventType field</returns>      
        public EventType? EventType { get; set; }
        
        ///<summary>      
        /// Retrieves the StartTime field</summary>
        /// <returns>Returns DateTime representing the StartTime field</returns>      
        public DateTime StartTime { get; set; }
        
        ///<summary>      
        /// Retrieves the StartPositionLat field
        /// Units: semicircles</summary>
        /// <returns>Returns nullable int representing the StartPositionLat field</returns>      
        public int? StartPositionLat { get; set; }
        
        ///<summary>      
        /// Retrieves the StartPositionLong field
        /// Units: semicircles</summary>
        /// <returns>Returns nullable int representing the StartPositionLong field</returns>      
        public int? StartPositionLong { get; set; }
        
        ///<summary>      
        /// Retrieves the EndPositionLat field
        /// Units: semicircles</summary>
        /// <returns>Returns nullable int representing the EndPositionLat field</returns>      
        public int? EndPositionLat { get; set; }
        
        ///<summary>      
        /// Retrieves the EndPositionLong field
        /// Units: semicircles</summary>
        /// <returns>Returns nullable int representing the EndPositionLong field</returns>      
        public int? EndPositionLong { get; set; }
        
        ///<summary>      
        /// Retrieves the TotalElapsedTime field
        /// Units: s
        /// Comment: Time (includes pauses)</summary>
        /// <returns>Returns nullable float representing the TotalElapsedTime field</returns>      
        public float? TotalElapsedTime { get; set; }
        
        ///<summary>      
        /// Retrieves the TotalTimerTime field
        /// Units: s
        /// Comment: Timer Time (excludes pauses)</summary>
        /// <returns>Returns nullable float representing the TotalTimerTime field</returns>      
        public float? TotalTimerTime { get; set; }
        
        ///<summary>      
        /// Retrieves the TotalDistance field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the TotalDistance field</returns>      
        public float? TotalDistance { get; set; }
        
        ///<summary>      
        /// Retrieves the TotalCycles field
        /// Units: cycles</summary>
        /// <returns>Returns nullable uint representing the TotalCycles field</returns>      
        public uint? TotalCycles { get; set; }
        
        /// <summary>       
        /// Retrieves the TotalStrides subfield
        /// Units: strides</summary>      
        /// <returns>Nullable uint representing the TotalStrides subfield</returns>      
        public uint? TotalStrides { get; set; }
        
        ///<summary>      
        /// Retrieves the TotalCalories field
        /// Units: kcal</summary>
        /// <returns>Returns nullable ushort representing the TotalCalories field</returns>      
        public ushort? TotalCalories { get; set; }
        
        ///<summary>      
        /// Retrieves the TotalFatCalories field
        /// Units: kcal
        /// Comment: If New Leaf</summary>
        /// <returns>Returns nullable ushort representing the TotalFatCalories field</returns>      
        public ushort? TotalFatCalories { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgSpeed field
        /// Units: m/s</summary>
        /// <returns>Returns nullable float representing the AvgSpeed field</returns>      
        public float? AvgSpeed { get; set; }
        
        ///<summary>      
        /// Retrieves the MaxSpeed field
        /// Units: m/s</summary>
        /// <returns>Returns nullable float representing the MaxSpeed field</returns>      
        public float? MaxSpeed { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgHeartRate field
        /// Units: bpm</summary>
        /// <returns>Returns nullable byte representing the AvgHeartRate field</returns>      
        public byte? AvgHeartRate { get; set; }
        
        ///<summary>      
        /// Retrieves the MaxHeartRate field
        /// Units: bpm</summary>
        /// <returns>Returns nullable byte representing the MaxHeartRate field</returns>      
        public byte? MaxHeartRate { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgCadence field
        /// Units: rpm
        /// Comment: total_cycles / total_timer_time if non_zero_avg_cadence otherwise total_cycles / total_elapsed_time</summary>
        /// <returns>Returns nullable byte representing the AvgCadence field</returns>      
        public byte? AvgCadence { get; set; }
        
        /// <summary>       
        /// Retrieves the AvgRunningCadence subfield
        /// Units: strides/min</summary>      
        /// <returns>Nullable byte representing the AvgRunningCadence subfield</returns>      
        public byte? AvgRunningCadence { get; set; }
        
        ///<summary>      
        /// Retrieves the MaxCadence field
        /// Units: rpm</summary>
        /// <returns>Returns nullable byte representing the MaxCadence field</returns>      
        public byte? MaxCadence { get; set; }
        
        /// <summary>       
        /// Retrieves the MaxRunningCadence subfield
        /// Units: strides/min</summary>      
        /// <returns>Nullable byte representing the MaxRunningCadence subfield</returns>      
        public byte? MaxRunningCadence { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgPower field
        /// Units: watts
        /// Comment: total_power / total_timer_time if non_zero_avg_power otherwise total_power / total_elapsed_time</summary>
        /// <returns>Returns nullable ushort representing the AvgPower field</returns>      
        public ushort? AvgPower { get; set; }
        
        ///<summary>      
        /// Retrieves the MaxPower field
        /// Units: watts</summary>
        /// <returns>Returns nullable ushort representing the MaxPower field</returns>      
        public ushort? MaxPower { get; set; }
        
        ///<summary>      
        /// Retrieves the TotalAscent field
        /// Units: m</summary>
        /// <returns>Returns nullable ushort representing the TotalAscent field</returns>      
        public ushort? TotalAscent { get; set; }
        
        ///<summary>      
        /// Retrieves the TotalDescent field
        /// Units: m</summary>
        /// <returns>Returns nullable ushort representing the TotalDescent field</returns>      
        public ushort? TotalDescent { get; set; }
        
        ///<summary>      
        /// Retrieves the Intensity field</summary>
        /// <returns>Returns nullable Intensity enum representing the Intensity field</returns>      
        public Intensity? Intensity { get; set; }
        
        ///<summary>      
        /// Retrieves the LapTrigger field</summary>
        /// <returns>Returns nullable LapTrigger enum representing the LapTrigger field</returns>      
        public LapTrigger? LapTrigger { get; set; }
        
        ///<summary>      
        /// Retrieves the Sport field</summary>
        /// <returns>Returns nullable Sport enum representing the Sport field</returns>      
        public Sport? Sport { get; set; }
        
        ///<summary>      
        /// Retrieves the EventGroup field</summary>
        /// <returns>Returns nullable byte representing the EventGroup field</returns>      
        public byte? EventGroup { get; set; }
        
        ///<summary>      
        /// Retrieves the NumLengths field
        /// Units: lengths
        /// Comment: # of lengths of swim pool</summary>
        /// <returns>Returns nullable ushort representing the NumLengths field</returns>      
        public ushort? NumLengths { get; set; }
        
        ///<summary>      
        /// Retrieves the NormalizedPower field
        /// Units: watts</summary>
        /// <returns>Returns nullable ushort representing the NormalizedPower field</returns>      
        public ushort? NormalizedPower { get; set; }
        
        ///<summary>      
        /// Retrieves the LeftRightBalance field</summary>
        /// <returns>Returns nullable ushort representing the LeftRightBalance field</returns>      
        public ushort? LeftRightBalance { get; set; }
        
        ///<summary>      
        /// Retrieves the FirstLengthIndex field</summary>
        /// <returns>Returns nullable ushort representing the FirstLengthIndex field</returns>      
        public ushort? FirstLengthIndex { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgStrokeDistance field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the AvgStrokeDistance field</returns>      
        public float? AvgStrokeDistance { get; set; }
        
        ///<summary>      
        /// Retrieves the SwimStroke field</summary>
        /// <returns>Returns nullable SwimStroke enum representing the SwimStroke field</returns>      
        public SwimStroke? SwimStroke { get; set; }
        
        ///<summary>      
        /// Retrieves the SubSport field</summary>
        /// <returns>Returns nullable SubSport enum representing the SubSport field</returns>      
        public SubSport? SubSport { get; set; }
        
        ///<summary>      
        /// Retrieves the NumActiveLengths field
        /// Units: lengths
        /// Comment: # of active lengths of swim pool</summary>
        /// <returns>Returns nullable ushort representing the NumActiveLengths field</returns>      
        public ushort? NumActiveLengths { get; set; }
        
        ///<summary>      
        /// Retrieves the TotalWork field
        /// Units: J</summary>
        /// <returns>Returns nullable uint representing the TotalWork field</returns>      
        public uint? TotalWork { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgAltitude field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the AvgAltitude field</returns>      
        public float? AvgAltitude { get; set; }
        
        ///<summary>      
        /// Retrieves the MaxAltitude field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the MaxAltitude field</returns>      
        public float? MaxAltitude { get; set; }
        
        ///<summary>      
        /// Retrieves the GpsAccuracy field
        /// Units: m</summary>
        /// <returns>Returns nullable byte representing the GpsAccuracy field</returns>      
        public byte? GpsAccuracy { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgGrade field
        /// Units: %</summary>
        /// <returns>Returns nullable float representing the AvgGrade field</returns>      
        public float? AvgGrade { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgPosGrade field
        /// Units: %</summary>
        /// <returns>Returns nullable float representing the AvgPosGrade field</returns>      
        public float? AvgPosGrade { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgNegGrade field
        /// Units: %</summary>
        /// <returns>Returns nullable float representing the AvgNegGrade field</returns>      
        public float? AvgNegGrade { get; set; }
        
        ///<summary>      
        /// Retrieves the MaxPosGrade field
        /// Units: %</summary>
        /// <returns>Returns nullable float representing the MaxPosGrade field</returns>      
        public float? MaxPosGrade { get; set; }
        
        ///<summary>      
        /// Retrieves the MaxNegGrade field
        /// Units: %</summary>
        /// <returns>Returns nullable float representing the MaxNegGrade field</returns>      
        public float? MaxNegGrade { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgTemperature field
        /// Units: C</summary>
        /// <returns>Returns nullable sbyte representing the AvgTemperature field</returns>      
        public sbyte? AvgTemperature { get; set; }
        
        ///<summary>      
        /// Retrieves the MaxTemperature field
        /// Units: C</summary>
        /// <returns>Returns nullable sbyte representing the MaxTemperature field</returns>      
        public sbyte? MaxTemperature { get; set; }
        
        ///<summary>      
        /// Retrieves the TotalMovingTime field
        /// Units: s</summary>
        /// <returns>Returns nullable float representing the TotalMovingTime field</returns>      
        public float? TotalMovingTime { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgPosVerticalSpeed field
        /// Units: m/s</summary>
        /// <returns>Returns nullable float representing the AvgPosVerticalSpeed field</returns>      
        public float? AvgPosVerticalSpeed { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgNegVerticalSpeed field
        /// Units: m/s</summary>
        /// <returns>Returns nullable float representing the AvgNegVerticalSpeed field</returns>      
        public float? AvgNegVerticalSpeed { get; set; }
        
        ///<summary>      
        /// Retrieves the MaxPosVerticalSpeed field
        /// Units: m/s</summary>
        /// <returns>Returns nullable float representing the MaxPosVerticalSpeed field</returns>      
        public float? MaxPosVerticalSpeed { get; set; }
        
        ///<summary>      
        /// Retrieves the MaxNegVerticalSpeed field
        /// Units: m/s</summary>
        /// <returns>Returns nullable float representing the MaxNegVerticalSpeed field</returns>      
        public float? MaxNegVerticalSpeed { get; set; }
        
        ///<summary>      
        /// Retrieves the RepetitionNum field</summary>
        /// <returns>Returns nullable ushort representing the RepetitionNum field</returns>      
        public ushort? RepetitionNum { get; set; }
        
        ///<summary>      
        /// Retrieves the MinAltitude field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the MinAltitude field</returns>      
        public float? MinAltitude { get; set; }
        
        ///<summary>      
        /// Retrieves the MinHeartRate field
        /// Units: bpm</summary>
        /// <returns>Returns nullable byte representing the MinHeartRate field</returns>      
        public byte? MinHeartRate { get; set; }
        
        ///<summary>      
        /// Retrieves the WktStepIndex field</summary>
        /// <returns>Returns nullable ushort representing the WktStepIndex field</returns>      
        public ushort? WktStepIndex { get; set; }
        
        ///<summary>      
        /// Retrieves the OpponentScore field</summary>
        /// <returns>Returns nullable ushort representing the OpponentScore field</returns>      
        public ushort? OpponentScore { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgVerticalOscillation field
        /// Units: mm</summary>
        /// <returns>Returns nullable float representing the AvgVerticalOscillation field</returns>      
        public float? AvgVerticalOscillation { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgStanceTimePercent field
        /// Units: percent</summary>
        /// <returns>Returns nullable float representing the AvgStanceTimePercent field</returns>      
        public float? AvgStanceTimePercent { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgStanceTime field
        /// Units: ms</summary>
        /// <returns>Returns nullable float representing the AvgStanceTime field</returns>      
        public float? AvgStanceTime { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgFractionalCadence field
        /// Units: rpm
        /// Comment: fractional part of the avg_cadence</summary>
        /// <returns>Returns nullable float representing the AvgFractionalCadence field</returns>      
        public float? AvgFractionalCadence { get; set; }
        
        ///<summary>      
        /// Retrieves the MaxFractionalCadence field
        /// Units: rpm
        /// Comment: fractional part of the max_cadence</summary>
        /// <returns>Returns nullable float representing the MaxFractionalCadence field</returns>      
        public float? MaxFractionalCadence { get; set; }
        
        ///<summary>      
        /// Retrieves the TotalFractionalCycles field
        /// Units: cycles
        /// Comment: fractional part of the total_cycles</summary>
        /// <returns>Returns nullable float representing the TotalFractionalCycles field</returns>      
        public float? TotalFractionalCycles { get; set; }
        
        ///<summary>      
        /// Retrieves the PlayerScore field</summary>
        /// <returns>Returns nullable ushort representing the PlayerScore field</returns>      
        public ushort? PlayerScore { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgLeftTorqueEffectiveness field
        /// Units: percent</summary>
        /// <returns>Returns nullable float representing the AvgLeftTorqueEffectiveness field</returns>      
        public float? AvgLeftTorqueEffectiveness { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgRightTorqueEffectiveness field
        /// Units: percent</summary>
        /// <returns>Returns nullable float representing the AvgRightTorqueEffectiveness field</returns>      
        public float? AvgRightTorqueEffectiveness { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgLeftPedalSmoothness field
        /// Units: percent</summary>
        /// <returns>Returns nullable float representing the AvgLeftPedalSmoothness field</returns>      
        public float? AvgLeftPedalSmoothness { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgRightPedalSmoothness field
        /// Units: percent</summary>
        /// <returns>Returns nullable float representing the AvgRightPedalSmoothness field</returns>      
        public float? AvgRightPedalSmoothness { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgCombinedPedalSmoothness field
        /// Units: percent</summary>
        /// <returns>Returns nullable float representing the AvgCombinedPedalSmoothness field</returns>      
        public float? AvgCombinedPedalSmoothness { get; set; }
        
        ///<summary>      
        /// Retrieves the TimeStanding field
        /// Units: s
        /// Comment: Total time spent in the standing position</summary>
        /// <returns>Returns nullable float representing the TimeStanding field</returns>      
        public float? TimeStanding { get; set; }
        
        ///<summary>      
        /// Retrieves the StandCount field
        /// Comment: Number of transitions to the standing state</summary>
        /// <returns>Returns nullable ushort representing the StandCount field</returns>      
        public ushort? StandCount { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgLeftPco field
        /// Units: mm
        /// Comment: Average left platform center offset</summary>
        /// <returns>Returns nullable sbyte representing the AvgLeftPco field</returns>      
        public sbyte? AvgLeftPco { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgRightPco field
        /// Units: mm
        /// Comment: Average right platform center offset</summary>
        /// <returns>Returns nullable sbyte representing the AvgRightPco field</returns>      
        public sbyte? AvgRightPco { get; set; }
        
        ///<summary>      
        /// Retrieves the EnhancedAvgSpeed field
        /// Units: m/s</summary>
        /// <returns>Returns nullable float representing the EnhancedAvgSpeed field</returns>      
        public float? EnhancedAvgSpeed { get; set; }
        
        ///<summary>      
        /// Retrieves the EnhancedMaxSpeed field
        /// Units: m/s</summary>
        /// <returns>Returns nullable float representing the EnhancedMaxSpeed field</returns>      
        public float? EnhancedMaxSpeed { get; set; }
        
        ///<summary>      
        /// Retrieves the EnhancedAvgAltitude field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the EnhancedAvgAltitude field</returns>      
        public float? EnhancedAvgAltitude { get; set; }
        
        ///<summary>      
        /// Retrieves the EnhancedMinAltitude field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the EnhancedMinAltitude field</returns>      
        public float? EnhancedMinAltitude { get; set; }
        
        ///<summary>      
        /// Retrieves the EnhancedMaxAltitude field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the EnhancedMaxAltitude field</returns>      
        public float? EnhancedMaxAltitude { get; set; }
        
        ///<summary>      
        /// Retrieves the AvgLevMotorPower field
        /// Units: watts
        /// Comment: lev average motor power during lap</summary>
        /// <returns>Returns nullable ushort representing the AvgLevMotorPower field</returns>      
        public ushort? AvgLevMotorPower { get; set; }
        
        ///<summary>      
        /// Retrieves the MaxLevMotorPower field
        /// Units: watts
        /// Comment: lev maximum motor power during lap</summary>
        /// <returns>Returns nullable ushort representing the MaxLevMotorPower field</returns>      
        public ushort? MaxLevMotorPower { get; set; }
        
        ///<summary>      
        /// Retrieves the LevBatteryConsumption field
        /// Units: percent
        /// Comment: lev battery consumption during lap</summary>
        /// <returns>Returns nullable float representing the LevBatteryConsumption field</returns>      
        public float? LevBatteryConsumption { get; set; }
    }
}
