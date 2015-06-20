﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Underloud.Data.Entities.Fit.Profile.Mesgs
{
    public class Session
    {
        //#region Methods
        /////<summary>      
        ///// Retrieves the MessageIndex field
        ///// Comment: Selected bit is set for the current session.</summary>
        ///// <returns>Returns nullable ushort representing the MessageIndex field</returns>   
        ///// <param name="messageIndex_">Nullable field value to be set</param>
        //public ushort? GetMessageIndex()
        //{
        //    return (ushort?)GetFieldValue(254, 0, Fit.SubfieldIndexMainField);
        //}

        ///// <summary>        
        ///// Set MessageIndex field
        ///// Comment: Selected bit is set for the current session.</summary>
        /////       
        //public void SetMessageIndex(ushort? messageIndex_)
        //{
        //    SetFieldValue(254, 0, messageIndex_, Fit.SubfieldIndexMainField);
        //}

        ///<summary>      
        /// Retrieves the Timestamp field
        /// Units: s
        /// Comment: Sesson end time.</summary>
        /// <returns>Returns DateTime representing the Timestamp field</returns> 
        /// <param name="timestamp_">Nullable field value to be set</param> 
        public DateTime Timestamp { get; set; }

        /////<summary>      
        ///// Retrieves the Event field
        ///// Comment: session</summary>
        ///// <returns>Returns nullable Event enum representing the Event field</returns>      
        //public Event? GetEvent()
        //{
        //    object obj = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
        //    Event? value = obj == null ? (Event?)null : (Event)obj;
        //    return value;
        //}

        ///// <summary>        
        ///// Set Event field
        ///// Comment: session</summary>
        ///// <param name="event_">Nullable field value to be set</param>      
        //public void SetEvent(Event? event_)
        //{
        //    SetFieldValue(0, 0, event_, Fit.SubfieldIndexMainField);
        //}

        /////<summary>      
        ///// Retrieves the EventType field
        ///// Comment: stop</summary>
        ///// <returns>Returns nullable EventType enum representing the EventType field</returns>      
        //public EventType? GetEventType()
        //{
        //    object obj = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
        //    EventType? value = obj == null ? (EventType?)null : (EventType)obj;
        //    return value;
        //}

        ///// <summary>        
        ///// Set EventType field
        ///// Comment: stop</summary>
        ///// <param name="eventType_">Nullable field value to be set</param>      
        //public void SetEventType(EventType? eventType_)
        //{
        //    SetFieldValue(1, 0, eventType_, Fit.SubfieldIndexMainField);
        //}

        ///<summary>      
        /// Retrieves the StartTime field</summary>
        /// <returns>Returns DateTime representing the StartTime field</returns> 
        /// <param name="startTime_">Nullable field value to be set</param>
        public DateTime StartTime { get; set; }


        ///<summary>      
        /// Retrieves the StartPositionLat field
        /// Units: semicircles</summary>
        /// <returns>Returns nullable int representing the StartPositionLat field</returns>      
        /// <param name="startPositionLat_">Nullable field value to be set</param>   
        public int? StartPositionLat { get; set; }

        ///<summary>      
        /// Retrieves the StartPositionLong field
        /// Units: semicircles</summary>
        /// <returns>Returns nullable int representing the StartPositionLong field</returns>  
        /// <param name="startPositionLong_">Nullable field value to be set</param>
        public int? StartPositionLong { get; set; }

        /////<summary>      
        ///// Retrieves the Sport field</summary>
        ///// <returns>Returns nullable Sport enum representing the Sport field</returns>      
        //public Sport? GetSport()
        //{
        //    object obj = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
        //    Sport? value = obj == null ? (Sport?)null : (Sport)obj;
        //    return value;
        //}

        ///// <summary>        
        ///// Set Sport field</summary>
        ///// <param name="sport_">Nullable field value to be set</param>      
        //public void SetSport(Sport? sport_)
        //{
        //    SetFieldValue(5, 0, sport_, Fit.SubfieldIndexMainField);
        //}

        /////<summary>      
        ///// Retrieves the SubSport field</summary>
        ///// <returns>Returns nullable SubSport enum representing the SubSport field</returns>      
        //public SubSport? GetSubSport()
        //{
        //    object obj = GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
        //    SubSport? value = obj == null ? (SubSport?)null : (SubSport)obj;
        //    return value;
        //}

        ///// <summary>        
        ///// Set SubSport field</summary>
        ///// <param name="subSport_">Nullable field value to be set</param>      
        //public void SetSubSport(SubSport? subSport_)
        //{
        //    SetFieldValue(6, 0, subSport_, Fit.SubfieldIndexMainField);
        //}

        ///<summary>      
        /// Retrieves the TotalElapsedTime field
        /// Units: s
        /// Comment: Time (includes pauses)</summary>
        /// <returns>Returns nullable float representing the TotalElapsedTime field</returns> 
        /// <param name="totalElapsedTime_">Nullable field value to be set</param>
        public float? TotalElapsedTime { get; set; }

        ///<summary>      
        /// Retrieves the TotalTimerTime field
        /// Units: s
        /// Comment: Timer Time (excludes pauses)</summary>
        /// <returns>Returns nullable float representing the TotalTimerTime field</returns>    
        /// <param name="totalTimerTime_">Nullable field value to be set</param>
        public float? TotalTimerTime { get; set; }

        ///<summary>      
        /// Retrieves the TotalDistance field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the TotalDistance field</returns>      
        public float? GetTotalDistance()
        {
            return (float?)GetFieldValue(9, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set TotalDistance field
        /// Units: m</summary>
        /// <param name="totalDistance_">Nullable field value to be set</param>      
        public void SetTotalDistance(float? totalDistance_)
        {
            SetFieldValue(9, 0, totalDistance_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the TotalCycles field
        /// Units: cycles</summary>
        /// <returns>Returns nullable uint representing the TotalCycles field</returns>      
        public uint? GetTotalCycles()
        {
            return (uint?)GetFieldValue(10, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set TotalCycles field
        /// Units: cycles</summary>
        /// <param name="totalCycles_">Nullable field value to be set</param>      
        public void SetTotalCycles(uint? totalCycles_)
        {
            SetFieldValue(10, 0, totalCycles_, Fit.SubfieldIndexMainField);
        }


        /// <summary>       
        /// Retrieves the TotalStrides subfield
        /// Units: strides</summary>      
        /// <returns>Nullable uint representing the TotalStrides subfield</returns>      
        public uint? GetTotalStrides()
        {
            return (uint?)GetFieldValue(10, 0, TotalCyclesSubfield.TotalStrides);
        }

        /// <summary> 
        /// 
        /// Set TotalStrides subfield
        /// Units: strides</summary>
        /// <param name="totalStrides">Subfield value to be set</param>      
        public void SetTotalStrides(uint? totalStrides)
        {
            SetFieldValue(10, 0, totalStrides, TotalCyclesSubfield.TotalStrides);
        }
        ///<summary>      
        /// Retrieves the TotalCalories field
        /// Units: kcal</summary>
        /// <returns>Returns nullable ushort representing the TotalCalories field</returns>      
        public ushort? GetTotalCalories()
        {
            return (ushort?)GetFieldValue(11, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set TotalCalories field
        /// Units: kcal</summary>
        /// <param name="totalCalories_">Nullable field value to be set</param>      
        public void SetTotalCalories(ushort? totalCalories_)
        {
            SetFieldValue(11, 0, totalCalories_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the TotalFatCalories field
        /// Units: kcal</summary>
        /// <returns>Returns nullable ushort representing the TotalFatCalories field</returns>      
        public ushort? GetTotalFatCalories()
        {
            return (ushort?)GetFieldValue(13, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set TotalFatCalories field
        /// Units: kcal</summary>
        /// <param name="totalFatCalories_">Nullable field value to be set</param>      
        public void SetTotalFatCalories(ushort? totalFatCalories_)
        {
            SetFieldValue(13, 0, totalFatCalories_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgSpeed field
        /// Units: m/s
        /// Comment: total_distance / total_timer_time</summary>
        /// <returns>Returns nullable float representing the AvgSpeed field</returns>      
        public float? GetAvgSpeed()
        {
            return (float?)GetFieldValue(14, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgSpeed field
        /// Units: m/s
        /// Comment: total_distance / total_timer_time</summary>
        /// <param name="avgSpeed_">Nullable field value to be set</param>      
        public void SetAvgSpeed(float? avgSpeed_)
        {
            SetFieldValue(14, 0, avgSpeed_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the MaxSpeed field
        /// Units: m/s</summary>
        /// <returns>Returns nullable float representing the MaxSpeed field</returns>      
        public float? GetMaxSpeed()
        {
            return (float?)GetFieldValue(15, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set MaxSpeed field
        /// Units: m/s</summary>
        /// <param name="maxSpeed_">Nullable field value to be set</param>      
        public void SetMaxSpeed(float? maxSpeed_)
        {
            SetFieldValue(15, 0, maxSpeed_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgHeartRate field
        /// Units: bpm
        /// Comment: average heart rate (excludes pause time)</summary>
        /// <returns>Returns nullable byte representing the AvgHeartRate field</returns>      
        public byte? GetAvgHeartRate()
        {
            return (byte?)GetFieldValue(16, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgHeartRate field
        /// Units: bpm
        /// Comment: average heart rate (excludes pause time)</summary>
        /// <param name="avgHeartRate_">Nullable field value to be set</param>      
        public void SetAvgHeartRate(byte? avgHeartRate_)
        {
            SetFieldValue(16, 0, avgHeartRate_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the MaxHeartRate field
        /// Units: bpm</summary>
        /// <returns>Returns nullable byte representing the MaxHeartRate field</returns>      
        public byte? GetMaxHeartRate()
        {
            return (byte?)GetFieldValue(17, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set MaxHeartRate field
        /// Units: bpm</summary>
        /// <param name="maxHeartRate_">Nullable field value to be set</param>      
        public void SetMaxHeartRate(byte? maxHeartRate_)
        {
            SetFieldValue(17, 0, maxHeartRate_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgCadence field
        /// Units: rpm
        /// Comment: total_cycles / total_timer_time if non_zero_avg_cadence otherwise total_cycles / total_elapsed_time</summary>
        /// <returns>Returns nullable byte representing the AvgCadence field</returns>      
        public byte? GetAvgCadence()
        {
            return (byte?)GetFieldValue(18, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgCadence field
        /// Units: rpm
        /// Comment: total_cycles / total_timer_time if non_zero_avg_cadence otherwise total_cycles / total_elapsed_time</summary>
        /// <param name="avgCadence_">Nullable field value to be set</param>      
        public void SetAvgCadence(byte? avgCadence_)
        {
            SetFieldValue(18, 0, avgCadence_, Fit.SubfieldIndexMainField);
        }


        /// <summary>       
        /// Retrieves the AvgRunningCadence subfield
        /// Units: strides/min</summary>      
        /// <returns>Nullable byte representing the AvgRunningCadence subfield</returns>      
        public byte? GetAvgRunningCadence()
        {
            return (byte?)GetFieldValue(18, 0, AvgCadenceSubfield.AvgRunningCadence);
        }

        /// <summary> 
        /// 
        /// Set AvgRunningCadence subfield
        /// Units: strides/min</summary>
        /// <param name="avgRunningCadence">Subfield value to be set</param>      
        public void SetAvgRunningCadence(byte? avgRunningCadence)
        {
            SetFieldValue(18, 0, avgRunningCadence, AvgCadenceSubfield.AvgRunningCadence);
        }
        ///<summary>      
        /// Retrieves the MaxCadence field
        /// Units: rpm</summary>
        /// <returns>Returns nullable byte representing the MaxCadence field</returns>      
        public byte? GetMaxCadence()
        {
            return (byte?)GetFieldValue(19, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set MaxCadence field
        /// Units: rpm</summary>
        /// <param name="maxCadence_">Nullable field value to be set</param>      
        public void SetMaxCadence(byte? maxCadence_)
        {
            SetFieldValue(19, 0, maxCadence_, Fit.SubfieldIndexMainField);
        }


        /// <summary>       
        /// Retrieves the MaxRunningCadence subfield
        /// Units: strides/min</summary>      
        /// <returns>Nullable byte representing the MaxRunningCadence subfield</returns>      
        public byte? GetMaxRunningCadence()
        {
            return (byte?)GetFieldValue(19, 0, MaxCadenceSubfield.MaxRunningCadence);
        }

        /// <summary> 
        /// 
        /// Set MaxRunningCadence subfield
        /// Units: strides/min</summary>
        /// <param name="maxRunningCadence">Subfield value to be set</param>      
        public void SetMaxRunningCadence(byte? maxRunningCadence)
        {
            SetFieldValue(19, 0, maxRunningCadence, MaxCadenceSubfield.MaxRunningCadence);
        }
        ///<summary>      
        /// Retrieves the AvgPower field
        /// Units: watts
        /// Comment: total_power / total_timer_time if non_zero_avg_power otherwise total_power / total_elapsed_time</summary>
        /// <returns>Returns nullable ushort representing the AvgPower field</returns>      
        public ushort? GetAvgPower()
        {
            return (ushort?)GetFieldValue(20, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgPower field
        /// Units: watts
        /// Comment: total_power / total_timer_time if non_zero_avg_power otherwise total_power / total_elapsed_time</summary>
        /// <param name="avgPower_">Nullable field value to be set</param>      
        public void SetAvgPower(ushort? avgPower_)
        {
            SetFieldValue(20, 0, avgPower_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the MaxPower field
        /// Units: watts</summary>
        /// <returns>Returns nullable ushort representing the MaxPower field</returns>      
        public ushort? GetMaxPower()
        {
            return (ushort?)GetFieldValue(21, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set MaxPower field
        /// Units: watts</summary>
        /// <param name="maxPower_">Nullable field value to be set</param>      
        public void SetMaxPower(ushort? maxPower_)
        {
            SetFieldValue(21, 0, maxPower_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the TotalAscent field
        /// Units: m</summary>
        /// <returns>Returns nullable ushort representing the TotalAscent field</returns>      
        public ushort? GetTotalAscent()
        {
            return (ushort?)GetFieldValue(22, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set TotalAscent field
        /// Units: m</summary>
        /// <param name="totalAscent_">Nullable field value to be set</param>      
        public void SetTotalAscent(ushort? totalAscent_)
        {
            SetFieldValue(22, 0, totalAscent_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the TotalDescent field
        /// Units: m</summary>
        /// <returns>Returns nullable ushort representing the TotalDescent field</returns>      
        public ushort? GetTotalDescent()
        {
            return (ushort?)GetFieldValue(23, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set TotalDescent field
        /// Units: m</summary>
        /// <param name="totalDescent_">Nullable field value to be set</param>      
        public void SetTotalDescent(ushort? totalDescent_)
        {
            SetFieldValue(23, 0, totalDescent_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the TotalTrainingEffect field</summary>
        /// <returns>Returns nullable float representing the TotalTrainingEffect field</returns>      
        public float? GetTotalTrainingEffect()
        {
            return (float?)GetFieldValue(24, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set TotalTrainingEffect field</summary>
        /// <param name="totalTrainingEffect_">Nullable field value to be set</param>      
        public void SetTotalTrainingEffect(float? totalTrainingEffect_)
        {
            SetFieldValue(24, 0, totalTrainingEffect_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the FirstLapIndex field</summary>
        /// <returns>Returns nullable ushort representing the FirstLapIndex field</returns>      
        public ushort? GetFirstLapIndex()
        {
            return (ushort?)GetFieldValue(25, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set FirstLapIndex field</summary>
        /// <param name="firstLapIndex_">Nullable field value to be set</param>      
        public void SetFirstLapIndex(ushort? firstLapIndex_)
        {
            SetFieldValue(25, 0, firstLapIndex_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the NumLaps field</summary>
        /// <returns>Returns nullable ushort representing the NumLaps field</returns>      
        public ushort? GetNumLaps()
        {
            return (ushort?)GetFieldValue(26, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set NumLaps field</summary>
        /// <param name="numLaps_">Nullable field value to be set</param>      
        public void SetNumLaps(ushort? numLaps_)
        {
            SetFieldValue(26, 0, numLaps_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the EventGroup field</summary>
        /// <returns>Returns nullable byte representing the EventGroup field</returns>      
        public byte? GetEventGroup()
        {
            return (byte?)GetFieldValue(27, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set EventGroup field</summary>
        /// <param name="eventGroup_">Nullable field value to be set</param>      
        public void SetEventGroup(byte? eventGroup_)
        {
            SetFieldValue(27, 0, eventGroup_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the Trigger field</summary>
        /// <returns>Returns nullable SessionTrigger enum representing the Trigger field</returns>      
        public SessionTrigger? GetTrigger()
        {
            object obj = GetFieldValue(28, 0, Fit.SubfieldIndexMainField);
            SessionTrigger? value = obj == null ? (SessionTrigger?)null : (SessionTrigger)obj;
            return value;
        }

        /// <summary>        
        /// Set Trigger field</summary>
        /// <param name="trigger_">Nullable field value to be set</param>      
        public void SetTrigger(SessionTrigger? trigger_)
        {
            SetFieldValue(28, 0, trigger_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the NecLat field
        /// Units: semicircles</summary>
        /// <returns>Returns nullable int representing the NecLat field</returns>      
        public int? GetNecLat()
        {
            return (int?)GetFieldValue(29, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set NecLat field
        /// Units: semicircles</summary>
        /// <param name="necLat_">Nullable field value to be set</param>      
        public void SetNecLat(int? necLat_)
        {
            SetFieldValue(29, 0, necLat_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the NecLong field
        /// Units: semicircles</summary>
        /// <returns>Returns nullable int representing the NecLong field</returns>      
        public int? GetNecLong()
        {
            return (int?)GetFieldValue(30, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set NecLong field
        /// Units: semicircles</summary>
        /// <param name="necLong_">Nullable field value to be set</param>      
        public void SetNecLong(int? necLong_)
        {
            SetFieldValue(30, 0, necLong_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the SwcLat field
        /// Units: semicircles</summary>
        /// <returns>Returns nullable int representing the SwcLat field</returns>      
        public int? GetSwcLat()
        {
            return (int?)GetFieldValue(31, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set SwcLat field
        /// Units: semicircles</summary>
        /// <param name="swcLat_">Nullable field value to be set</param>      
        public void SetSwcLat(int? swcLat_)
        {
            SetFieldValue(31, 0, swcLat_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the SwcLong field
        /// Units: semicircles</summary>
        /// <returns>Returns nullable int representing the SwcLong field</returns>      
        public int? GetSwcLong()
        {
            return (int?)GetFieldValue(32, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set SwcLong field
        /// Units: semicircles</summary>
        /// <param name="swcLong_">Nullable field value to be set</param>      
        public void SetSwcLong(int? swcLong_)
        {
            SetFieldValue(32, 0, swcLong_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the NormalizedPower field
        /// Units: watts</summary>
        /// <returns>Returns nullable ushort representing the NormalizedPower field</returns>      
        public ushort? GetNormalizedPower()
        {
            return (ushort?)GetFieldValue(34, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set NormalizedPower field
        /// Units: watts</summary>
        /// <param name="normalizedPower_">Nullable field value to be set</param>      
        public void SetNormalizedPower(ushort? normalizedPower_)
        {
            SetFieldValue(34, 0, normalizedPower_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the TrainingStressScore field
        /// Units: tss</summary>
        /// <returns>Returns nullable float representing the TrainingStressScore field</returns>      
        public float? GetTrainingStressScore()
        {
            return (float?)GetFieldValue(35, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set TrainingStressScore field
        /// Units: tss</summary>
        /// <param name="trainingStressScore_">Nullable field value to be set</param>      
        public void SetTrainingStressScore(float? trainingStressScore_)
        {
            SetFieldValue(35, 0, trainingStressScore_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the IntensityFactor field
        /// Units: if</summary>
        /// <returns>Returns nullable float representing the IntensityFactor field</returns>      
        public float? GetIntensityFactor()
        {
            return (float?)GetFieldValue(36, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set IntensityFactor field
        /// Units: if</summary>
        /// <param name="intensityFactor_">Nullable field value to be set</param>      
        public void SetIntensityFactor(float? intensityFactor_)
        {
            SetFieldValue(36, 0, intensityFactor_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the LeftRightBalance field</summary>
        /// <returns>Returns nullable ushort representing the LeftRightBalance field</returns>      
        public ushort? GetLeftRightBalance()
        {
            return (ushort?)GetFieldValue(37, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set LeftRightBalance field</summary>
        /// <param name="leftRightBalance_">Nullable field value to be set</param>      
        public void SetLeftRightBalance(ushort? leftRightBalance_)
        {
            SetFieldValue(37, 0, leftRightBalance_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgStrokeCount field
        /// Units: strokes/lap</summary>
        /// <returns>Returns nullable float representing the AvgStrokeCount field</returns>      
        public float? GetAvgStrokeCount()
        {
            return (float?)GetFieldValue(41, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgStrokeCount field
        /// Units: strokes/lap</summary>
        /// <param name="avgStrokeCount_">Nullable field value to be set</param>      
        public void SetAvgStrokeCount(float? avgStrokeCount_)
        {
            SetFieldValue(41, 0, avgStrokeCount_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgStrokeDistance field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the AvgStrokeDistance field</returns>      
        public float? GetAvgStrokeDistance()
        {
            return (float?)GetFieldValue(42, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgStrokeDistance field
        /// Units: m</summary>
        /// <param name="avgStrokeDistance_">Nullable field value to be set</param>      
        public void SetAvgStrokeDistance(float? avgStrokeDistance_)
        {
            SetFieldValue(42, 0, avgStrokeDistance_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the SwimStroke field
        /// Units: swim_stroke</summary>
        /// <returns>Returns nullable SwimStroke enum representing the SwimStroke field</returns>      
        public SwimStroke? GetSwimStroke()
        {
            object obj = GetFieldValue(43, 0, Fit.SubfieldIndexMainField);
            SwimStroke? value = obj == null ? (SwimStroke?)null : (SwimStroke)obj;
            return value;
        }

        /// <summary>        
        /// Set SwimStroke field
        /// Units: swim_stroke</summary>
        /// <param name="swimStroke_">Nullable field value to be set</param>      
        public void SetSwimStroke(SwimStroke? swimStroke_)
        {
            SetFieldValue(43, 0, swimStroke_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the PoolLength field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the PoolLength field</returns>      
        public float? GetPoolLength()
        {
            return (float?)GetFieldValue(44, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set PoolLength field
        /// Units: m</summary>
        /// <param name="poolLength_">Nullable field value to be set</param>      
        public void SetPoolLength(float? poolLength_)
        {
            SetFieldValue(44, 0, poolLength_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the ThresholdPower field
        /// Units: watts</summary>
        /// <returns>Returns nullable ushort representing the ThresholdPower field</returns>      
        public ushort? GetThresholdPower()
        {
            return (ushort?)GetFieldValue(45, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set ThresholdPower field
        /// Units: watts</summary>
        /// <param name="thresholdPower_">Nullable field value to be set</param>      
        public void SetThresholdPower(ushort? thresholdPower_)
        {
            SetFieldValue(45, 0, thresholdPower_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the PoolLengthUnit field</summary>
        /// <returns>Returns nullable DisplayMeasure enum representing the PoolLengthUnit field</returns>      
        public DisplayMeasure? GetPoolLengthUnit()
        {
            object obj = GetFieldValue(46, 0, Fit.SubfieldIndexMainField);
            DisplayMeasure? value = obj == null ? (DisplayMeasure?)null : (DisplayMeasure)obj;
            return value;
        }

        /// <summary>        
        /// Set PoolLengthUnit field</summary>
        /// <param name="poolLengthUnit_">Nullable field value to be set</param>      
        public void SetPoolLengthUnit(DisplayMeasure? poolLengthUnit_)
        {
            SetFieldValue(46, 0, poolLengthUnit_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the NumActiveLengths field
        /// Units: lengths
        /// Comment: # of active lengths of swim pool</summary>
        /// <returns>Returns nullable ushort representing the NumActiveLengths field</returns>      
        public ushort? GetNumActiveLengths()
        {
            return (ushort?)GetFieldValue(47, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set NumActiveLengths field
        /// Units: lengths
        /// Comment: # of active lengths of swim pool</summary>
        /// <param name="numActiveLengths_">Nullable field value to be set</param>      
        public void SetNumActiveLengths(ushort? numActiveLengths_)
        {
            SetFieldValue(47, 0, numActiveLengths_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the TotalWork field
        /// Units: J</summary>
        /// <returns>Returns nullable uint representing the TotalWork field</returns>      
        public uint? GetTotalWork()
        {
            return (uint?)GetFieldValue(48, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set TotalWork field
        /// Units: J</summary>
        /// <param name="totalWork_">Nullable field value to be set</param>      
        public void SetTotalWork(uint? totalWork_)
        {
            SetFieldValue(48, 0, totalWork_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgAltitude field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the AvgAltitude field</returns>      
        public float? GetAvgAltitude()
        {
            return (float?)GetFieldValue(49, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgAltitude field
        /// Units: m</summary>
        /// <param name="avgAltitude_">Nullable field value to be set</param>      
        public void SetAvgAltitude(float? avgAltitude_)
        {
            SetFieldValue(49, 0, avgAltitude_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the MaxAltitude field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the MaxAltitude field</returns>      
        public float? GetMaxAltitude()
        {
            return (float?)GetFieldValue(50, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set MaxAltitude field
        /// Units: m</summary>
        /// <param name="maxAltitude_">Nullable field value to be set</param>      
        public void SetMaxAltitude(float? maxAltitude_)
        {
            SetFieldValue(50, 0, maxAltitude_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the GpsAccuracy field
        /// Units: m</summary>
        /// <returns>Returns nullable byte representing the GpsAccuracy field</returns>      
        public byte? GetGpsAccuracy()
        {
            return (byte?)GetFieldValue(51, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set GpsAccuracy field
        /// Units: m</summary>
        /// <param name="gpsAccuracy_">Nullable field value to be set</param>      
        public void SetGpsAccuracy(byte? gpsAccuracy_)
        {
            SetFieldValue(51, 0, gpsAccuracy_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgGrade field
        /// Units: %</summary>
        /// <returns>Returns nullable float representing the AvgGrade field</returns>      
        public float? GetAvgGrade()
        {
            return (float?)GetFieldValue(52, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgGrade field
        /// Units: %</summary>
        /// <param name="avgGrade_">Nullable field value to be set</param>      
        public void SetAvgGrade(float? avgGrade_)
        {
            SetFieldValue(52, 0, avgGrade_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgPosGrade field
        /// Units: %</summary>
        /// <returns>Returns nullable float representing the AvgPosGrade field</returns>      
        public float? GetAvgPosGrade()
        {
            return (float?)GetFieldValue(53, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgPosGrade field
        /// Units: %</summary>
        /// <param name="avgPosGrade_">Nullable field value to be set</param>      
        public void SetAvgPosGrade(float? avgPosGrade_)
        {
            SetFieldValue(53, 0, avgPosGrade_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgNegGrade field
        /// Units: %</summary>
        /// <returns>Returns nullable float representing the AvgNegGrade field</returns>      
        public float? GetAvgNegGrade()
        {
            return (float?)GetFieldValue(54, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgNegGrade field
        /// Units: %</summary>
        /// <param name="avgNegGrade_">Nullable field value to be set</param>      
        public void SetAvgNegGrade(float? avgNegGrade_)
        {
            SetFieldValue(54, 0, avgNegGrade_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the MaxPosGrade field
        /// Units: %</summary>
        /// <returns>Returns nullable float representing the MaxPosGrade field</returns>      
        public float? GetMaxPosGrade()
        {
            return (float?)GetFieldValue(55, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set MaxPosGrade field
        /// Units: %</summary>
        /// <param name="maxPosGrade_">Nullable field value to be set</param>      
        public void SetMaxPosGrade(float? maxPosGrade_)
        {
            SetFieldValue(55, 0, maxPosGrade_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the MaxNegGrade field
        /// Units: %</summary>
        /// <returns>Returns nullable float representing the MaxNegGrade field</returns>      
        public float? GetMaxNegGrade()
        {
            return (float?)GetFieldValue(56, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set MaxNegGrade field
        /// Units: %</summary>
        /// <param name="maxNegGrade_">Nullable field value to be set</param>      
        public void SetMaxNegGrade(float? maxNegGrade_)
        {
            SetFieldValue(56, 0, maxNegGrade_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgTemperature field
        /// Units: C</summary>
        /// <returns>Returns nullable sbyte representing the AvgTemperature field</returns>      
        public sbyte? GetAvgTemperature()
        {
            return (sbyte?)GetFieldValue(57, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgTemperature field
        /// Units: C</summary>
        /// <param name="avgTemperature_">Nullable field value to be set</param>      
        public void SetAvgTemperature(sbyte? avgTemperature_)
        {
            SetFieldValue(57, 0, avgTemperature_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the MaxTemperature field
        /// Units: C</summary>
        /// <returns>Returns nullable sbyte representing the MaxTemperature field</returns>      
        public sbyte? GetMaxTemperature()
        {
            return (sbyte?)GetFieldValue(58, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set MaxTemperature field
        /// Units: C</summary>
        /// <param name="maxTemperature_">Nullable field value to be set</param>      
        public void SetMaxTemperature(sbyte? maxTemperature_)
        {
            SetFieldValue(58, 0, maxTemperature_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the TotalMovingTime field
        /// Units: s</summary>
        /// <returns>Returns nullable float representing the TotalMovingTime field</returns>      
        public float? GetTotalMovingTime()
        {
            return (float?)GetFieldValue(59, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set TotalMovingTime field
        /// Units: s</summary>
        /// <param name="totalMovingTime_">Nullable field value to be set</param>      
        public void SetTotalMovingTime(float? totalMovingTime_)
        {
            SetFieldValue(59, 0, totalMovingTime_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgPosVerticalSpeed field
        /// Units: m/s</summary>
        /// <returns>Returns nullable float representing the AvgPosVerticalSpeed field</returns>      
        public float? GetAvgPosVerticalSpeed()
        {
            return (float?)GetFieldValue(60, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgPosVerticalSpeed field
        /// Units: m/s</summary>
        /// <param name="avgPosVerticalSpeed_">Nullable field value to be set</param>      
        public void SetAvgPosVerticalSpeed(float? avgPosVerticalSpeed_)
        {
            SetFieldValue(60, 0, avgPosVerticalSpeed_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgNegVerticalSpeed field
        /// Units: m/s</summary>
        /// <returns>Returns nullable float representing the AvgNegVerticalSpeed field</returns>      
        public float? GetAvgNegVerticalSpeed()
        {
            return (float?)GetFieldValue(61, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgNegVerticalSpeed field
        /// Units: m/s</summary>
        /// <param name="avgNegVerticalSpeed_">Nullable field value to be set</param>      
        public void SetAvgNegVerticalSpeed(float? avgNegVerticalSpeed_)
        {
            SetFieldValue(61, 0, avgNegVerticalSpeed_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the MaxPosVerticalSpeed field
        /// Units: m/s</summary>
        /// <returns>Returns nullable float representing the MaxPosVerticalSpeed field</returns>      
        public float? GetMaxPosVerticalSpeed()
        {
            return (float?)GetFieldValue(62, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set MaxPosVerticalSpeed field
        /// Units: m/s</summary>
        /// <param name="maxPosVerticalSpeed_">Nullable field value to be set</param>      
        public void SetMaxPosVerticalSpeed(float? maxPosVerticalSpeed_)
        {
            SetFieldValue(62, 0, maxPosVerticalSpeed_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the MaxNegVerticalSpeed field
        /// Units: m/s</summary>
        /// <returns>Returns nullable float representing the MaxNegVerticalSpeed field</returns>      
        public float? GetMaxNegVerticalSpeed()
        {
            return (float?)GetFieldValue(63, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set MaxNegVerticalSpeed field
        /// Units: m/s</summary>
        /// <param name="maxNegVerticalSpeed_">Nullable field value to be set</param>      
        public void SetMaxNegVerticalSpeed(float? maxNegVerticalSpeed_)
        {
            SetFieldValue(63, 0, maxNegVerticalSpeed_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the MinHeartRate field
        /// Units: bpm</summary>
        /// <returns>Returns nullable byte representing the MinHeartRate field</returns>      
        public byte? GetMinHeartRate()
        {
            return (byte?)GetFieldValue(64, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set MinHeartRate field
        /// Units: bpm</summary>
        /// <param name="minHeartRate_">Nullable field value to be set</param>      
        public void SetMinHeartRate(byte? minHeartRate_)
        {
            SetFieldValue(64, 0, minHeartRate_, Fit.SubfieldIndexMainField);
        }


        /// <summary>
        /// 
        /// </summary>  
        /// <returns>returns number of elements in field TimeInHrZone</returns>      
        public int GetNumTimeInHrZone()
        {
            return GetNumFieldValues(65, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the TimeInHrZone field
        /// Units: s</summary>
        /// <param name="index">0 based index of TimeInHrZone element to retrieve</param>
        /// <returns>Returns nullable float representing the TimeInHrZone field</returns>      
        public float? GetTimeInHrZone(int index)
        {
            return (float?)GetFieldValue(65, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set TimeInHrZone field
        /// Units: s</summary>      
        /// <param name="index">0 based index of time_in_hr_zone</param>
        /// <param name="timeInHrZone_">Nullable field value to be set</param>      
        public void SetTimeInHrZone(int index, float? timeInHrZone_)
        {
            SetFieldValue(65, index, timeInHrZone_, Fit.SubfieldIndexMainField);
        }


        /// <summary>
        /// 
        /// </summary>  
        /// <returns>returns number of elements in field TimeInSpeedZone</returns>      
        public int GetNumTimeInSpeedZone()
        {
            return GetNumFieldValues(66, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the TimeInSpeedZone field
        /// Units: s</summary>
        /// <param name="index">0 based index of TimeInSpeedZone element to retrieve</param>
        /// <returns>Returns nullable float representing the TimeInSpeedZone field</returns>      
        public float? GetTimeInSpeedZone(int index)
        {
            return (float?)GetFieldValue(66, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set TimeInSpeedZone field
        /// Units: s</summary>      
        /// <param name="index">0 based index of time_in_speed_zone</param>
        /// <param name="timeInSpeedZone_">Nullable field value to be set</param>      
        public void SetTimeInSpeedZone(int index, float? timeInSpeedZone_)
        {
            SetFieldValue(66, index, timeInSpeedZone_, Fit.SubfieldIndexMainField);
        }


        /// <summary>
        /// 
        /// </summary>  
        /// <returns>returns number of elements in field TimeInCadenceZone</returns>      
        public int GetNumTimeInCadenceZone()
        {
            return GetNumFieldValues(67, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the TimeInCadenceZone field
        /// Units: s</summary>
        /// <param name="index">0 based index of TimeInCadenceZone element to retrieve</param>
        /// <returns>Returns nullable float representing the TimeInCadenceZone field</returns>      
        public float? GetTimeInCadenceZone(int index)
        {
            return (float?)GetFieldValue(67, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set TimeInCadenceZone field
        /// Units: s</summary>      
        /// <param name="index">0 based index of time_in_cadence_zone</param>
        /// <param name="timeInCadenceZone_">Nullable field value to be set</param>      
        public void SetTimeInCadenceZone(int index, float? timeInCadenceZone_)
        {
            SetFieldValue(67, index, timeInCadenceZone_, Fit.SubfieldIndexMainField);
        }


        /// <summary>
        /// 
        /// </summary>  
        /// <returns>returns number of elements in field TimeInPowerZone</returns>      
        public int GetNumTimeInPowerZone()
        {
            return GetNumFieldValues(68, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the TimeInPowerZone field
        /// Units: s</summary>
        /// <param name="index">0 based index of TimeInPowerZone element to retrieve</param>
        /// <returns>Returns nullable float representing the TimeInPowerZone field</returns>      
        public float? GetTimeInPowerZone(int index)
        {
            return (float?)GetFieldValue(68, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set TimeInPowerZone field
        /// Units: s</summary>      
        /// <param name="index">0 based index of time_in_power_zone</param>
        /// <param name="timeInPowerZone_">Nullable field value to be set</param>      
        public void SetTimeInPowerZone(int index, float? timeInPowerZone_)
        {
            SetFieldValue(68, index, timeInPowerZone_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgLapTime field
        /// Units: s</summary>
        /// <returns>Returns nullable float representing the AvgLapTime field</returns>      
        public float? GetAvgLapTime()
        {
            return (float?)GetFieldValue(69, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgLapTime field
        /// Units: s</summary>
        /// <param name="avgLapTime_">Nullable field value to be set</param>      
        public void SetAvgLapTime(float? avgLapTime_)
        {
            SetFieldValue(69, 0, avgLapTime_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the BestLapIndex field</summary>
        /// <returns>Returns nullable ushort representing the BestLapIndex field</returns>      
        public ushort? GetBestLapIndex()
        {
            return (ushort?)GetFieldValue(70, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set BestLapIndex field</summary>
        /// <param name="bestLapIndex_">Nullable field value to be set</param>      
        public void SetBestLapIndex(ushort? bestLapIndex_)
        {
            SetFieldValue(70, 0, bestLapIndex_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the MinAltitude field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the MinAltitude field</returns>      
        public float? GetMinAltitude()
        {
            return (float?)GetFieldValue(71, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set MinAltitude field
        /// Units: m</summary>
        /// <param name="minAltitude_">Nullable field value to be set</param>      
        public void SetMinAltitude(float? minAltitude_)
        {
            SetFieldValue(71, 0, minAltitude_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the PlayerScore field</summary>
        /// <returns>Returns nullable ushort representing the PlayerScore field</returns>      
        public ushort? GetPlayerScore()
        {
            return (ushort?)GetFieldValue(82, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set PlayerScore field</summary>
        /// <param name="playerScore_">Nullable field value to be set</param>      
        public void SetPlayerScore(ushort? playerScore_)
        {
            SetFieldValue(82, 0, playerScore_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the OpponentScore field</summary>
        /// <returns>Returns nullable ushort representing the OpponentScore field</returns>      
        public ushort? GetOpponentScore()
        {
            return (ushort?)GetFieldValue(83, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set OpponentScore field</summary>
        /// <param name="opponentScore_">Nullable field value to be set</param>      
        public void SetOpponentScore(ushort? opponentScore_)
        {
            SetFieldValue(83, 0, opponentScore_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the OpponentName field</summary>
        /// <returns>Returns byte[] representing the OpponentName field</returns>      
        public byte[] GetOpponentName()
        {
            return (byte[])GetFieldValue(84, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set OpponentName field</summary>
        /// <param name="opponentName_">field value to be set</param>      
        public void SetOpponentName(byte[] opponentName_)
        {
            SetFieldValue(84, 0, opponentName_, Fit.SubfieldIndexMainField);
        }


        /// <summary>
        /// 
        /// </summary>  
        /// <returns>returns number of elements in field StrokeCount</returns>      
        public int GetNumStrokeCount()
        {
            return GetNumFieldValues(85, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the StrokeCount field
        /// Units: counts
        /// Comment: stroke_type enum used as the index</summary>
        /// <param name="index">0 based index of StrokeCount element to retrieve</param>
        /// <returns>Returns nullable ushort representing the StrokeCount field</returns>      
        public ushort? GetStrokeCount(int index)
        {
            return (ushort?)GetFieldValue(85, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set StrokeCount field
        /// Units: counts
        /// Comment: stroke_type enum used as the index</summary>      
        /// <param name="index">0 based index of stroke_count</param>
        /// <param name="strokeCount_">Nullable field value to be set</param>      
        public void SetStrokeCount(int index, ushort? strokeCount_)
        {
            SetFieldValue(85, index, strokeCount_, Fit.SubfieldIndexMainField);
        }


        /// <summary>
        /// 
        /// </summary>  
        /// <returns>returns number of elements in field ZoneCount</returns>      
        public int GetNumZoneCount()
        {
            return GetNumFieldValues(86, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the ZoneCount field
        /// Units: counts
        /// Comment: zone number used as the index</summary>
        /// <param name="index">0 based index of ZoneCount element to retrieve</param>
        /// <returns>Returns nullable ushort representing the ZoneCount field</returns>      
        public ushort? GetZoneCount(int index)
        {
            return (ushort?)GetFieldValue(86, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set ZoneCount field
        /// Units: counts
        /// Comment: zone number used as the index</summary>      
        /// <param name="index">0 based index of zone_count</param>
        /// <param name="zoneCount_">Nullable field value to be set</param>      
        public void SetZoneCount(int index, ushort? zoneCount_)
        {
            SetFieldValue(86, index, zoneCount_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the MaxBallSpeed field
        /// Units: m/s</summary>
        /// <returns>Returns nullable float representing the MaxBallSpeed field</returns>      
        public float? GetMaxBallSpeed()
        {
            return (float?)GetFieldValue(87, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set MaxBallSpeed field
        /// Units: m/s</summary>
        /// <param name="maxBallSpeed_">Nullable field value to be set</param>      
        public void SetMaxBallSpeed(float? maxBallSpeed_)
        {
            SetFieldValue(87, 0, maxBallSpeed_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgBallSpeed field
        /// Units: m/s</summary>
        /// <returns>Returns nullable float representing the AvgBallSpeed field</returns>      
        public float? GetAvgBallSpeed()
        {
            return (float?)GetFieldValue(88, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgBallSpeed field
        /// Units: m/s</summary>
        /// <param name="avgBallSpeed_">Nullable field value to be set</param>      
        public void SetAvgBallSpeed(float? avgBallSpeed_)
        {
            SetFieldValue(88, 0, avgBallSpeed_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgVerticalOscillation field
        /// Units: mm</summary>
        /// <returns>Returns nullable float representing the AvgVerticalOscillation field</returns>      
        public float? GetAvgVerticalOscillation()
        {
            return (float?)GetFieldValue(89, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgVerticalOscillation field
        /// Units: mm</summary>
        /// <param name="avgVerticalOscillation_">Nullable field value to be set</param>      
        public void SetAvgVerticalOscillation(float? avgVerticalOscillation_)
        {
            SetFieldValue(89, 0, avgVerticalOscillation_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgStanceTimePercent field
        /// Units: percent</summary>
        /// <returns>Returns nullable float representing the AvgStanceTimePercent field</returns>      
        public float? GetAvgStanceTimePercent()
        {
            return (float?)GetFieldValue(90, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgStanceTimePercent field
        /// Units: percent</summary>
        /// <param name="avgStanceTimePercent_">Nullable field value to be set</param>      
        public void SetAvgStanceTimePercent(float? avgStanceTimePercent_)
        {
            SetFieldValue(90, 0, avgStanceTimePercent_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgStanceTime field
        /// Units: ms</summary>
        /// <returns>Returns nullable float representing the AvgStanceTime field</returns>      
        public float? GetAvgStanceTime()
        {
            return (float?)GetFieldValue(91, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgStanceTime field
        /// Units: ms</summary>
        /// <param name="avgStanceTime_">Nullable field value to be set</param>      
        public void SetAvgStanceTime(float? avgStanceTime_)
        {
            SetFieldValue(91, 0, avgStanceTime_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgFractionalCadence field
        /// Units: rpm
        /// Comment: fractional part of the avg_cadence</summary>
        /// <returns>Returns nullable float representing the AvgFractionalCadence field</returns>      
        public float? GetAvgFractionalCadence()
        {
            return (float?)GetFieldValue(92, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgFractionalCadence field
        /// Units: rpm
        /// Comment: fractional part of the avg_cadence</summary>
        /// <param name="avgFractionalCadence_">Nullable field value to be set</param>      
        public void SetAvgFractionalCadence(float? avgFractionalCadence_)
        {
            SetFieldValue(92, 0, avgFractionalCadence_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the MaxFractionalCadence field
        /// Units: rpm
        /// Comment: fractional part of the max_cadence</summary>
        /// <returns>Returns nullable float representing the MaxFractionalCadence field</returns>      
        public float? GetMaxFractionalCadence()
        {
            return (float?)GetFieldValue(93, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set MaxFractionalCadence field
        /// Units: rpm
        /// Comment: fractional part of the max_cadence</summary>
        /// <param name="maxFractionalCadence_">Nullable field value to be set</param>      
        public void SetMaxFractionalCadence(float? maxFractionalCadence_)
        {
            SetFieldValue(93, 0, maxFractionalCadence_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the TotalFractionalCycles field
        /// Units: cycles
        /// Comment: fractional part of the total_cycles</summary>
        /// <returns>Returns nullable float representing the TotalFractionalCycles field</returns>      
        public float? GetTotalFractionalCycles()
        {
            return (float?)GetFieldValue(94, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set TotalFractionalCycles field
        /// Units: cycles
        /// Comment: fractional part of the total_cycles</summary>
        /// <param name="totalFractionalCycles_">Nullable field value to be set</param>      
        public void SetTotalFractionalCycles(float? totalFractionalCycles_)
        {
            SetFieldValue(94, 0, totalFractionalCycles_, Fit.SubfieldIndexMainField);
        }


        /// <summary>
        /// 
        /// </summary>  
        /// <returns>returns number of elements in field AvgTotalHemoglobinConc</returns>      
        public int GetNumAvgTotalHemoglobinConc()
        {
            return GetNumFieldValues(95, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgTotalHemoglobinConc field
        /// Units: g/dL
        /// Comment: Avg saturated and unsaturated hemoglobin</summary>
        /// <param name="index">0 based index of AvgTotalHemoglobinConc element to retrieve</param>
        /// <returns>Returns nullable float representing the AvgTotalHemoglobinConc field</returns>      
        public float? GetAvgTotalHemoglobinConc(int index)
        {
            return (float?)GetFieldValue(95, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgTotalHemoglobinConc field
        /// Units: g/dL
        /// Comment: Avg saturated and unsaturated hemoglobin</summary>      
        /// <param name="index">0 based index of avg_total_hemoglobin_conc</param>
        /// <param name="avgTotalHemoglobinConc_">Nullable field value to be set</param>      
        public void SetAvgTotalHemoglobinConc(int index, float? avgTotalHemoglobinConc_)
        {
            SetFieldValue(95, index, avgTotalHemoglobinConc_, Fit.SubfieldIndexMainField);
        }


        /// <summary>
        /// 
        /// </summary>  
        /// <returns>returns number of elements in field MinTotalHemoglobinConc</returns>      
        public int GetNumMinTotalHemoglobinConc()
        {
            return GetNumFieldValues(96, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the MinTotalHemoglobinConc field
        /// Units: g/dL
        /// Comment: Min saturated and unsaturated hemoglobin</summary>
        /// <param name="index">0 based index of MinTotalHemoglobinConc element to retrieve</param>
        /// <returns>Returns nullable float representing the MinTotalHemoglobinConc field</returns>      
        public float? GetMinTotalHemoglobinConc(int index)
        {
            return (float?)GetFieldValue(96, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set MinTotalHemoglobinConc field
        /// Units: g/dL
        /// Comment: Min saturated and unsaturated hemoglobin</summary>      
        /// <param name="index">0 based index of min_total_hemoglobin_conc</param>
        /// <param name="minTotalHemoglobinConc_">Nullable field value to be set</param>      
        public void SetMinTotalHemoglobinConc(int index, float? minTotalHemoglobinConc_)
        {
            SetFieldValue(96, index, minTotalHemoglobinConc_, Fit.SubfieldIndexMainField);
        }


        /// <summary>
        /// 
        /// </summary>  
        /// <returns>returns number of elements in field MaxTotalHemoglobinConc</returns>      
        public int GetNumMaxTotalHemoglobinConc()
        {
            return GetNumFieldValues(97, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the MaxTotalHemoglobinConc field
        /// Units: g/dL
        /// Comment: Max saturated and unsaturated hemoglobin</summary>
        /// <param name="index">0 based index of MaxTotalHemoglobinConc element to retrieve</param>
        /// <returns>Returns nullable float representing the MaxTotalHemoglobinConc field</returns>      
        public float? GetMaxTotalHemoglobinConc(int index)
        {
            return (float?)GetFieldValue(97, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set MaxTotalHemoglobinConc field
        /// Units: g/dL
        /// Comment: Max saturated and unsaturated hemoglobin</summary>      
        /// <param name="index">0 based index of max_total_hemoglobin_conc</param>
        /// <param name="maxTotalHemoglobinConc_">Nullable field value to be set</param>      
        public void SetMaxTotalHemoglobinConc(int index, float? maxTotalHemoglobinConc_)
        {
            SetFieldValue(97, index, maxTotalHemoglobinConc_, Fit.SubfieldIndexMainField);
        }


        /// <summary>
        /// 
        /// </summary>  
        /// <returns>returns number of elements in field AvgSaturatedHemoglobinPercent</returns>      
        public int GetNumAvgSaturatedHemoglobinPercent()
        {
            return GetNumFieldValues(98, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgSaturatedHemoglobinPercent field
        /// Units: %
        /// Comment: Avg percentage of hemoglobin saturated with oxygen</summary>
        /// <param name="index">0 based index of AvgSaturatedHemoglobinPercent element to retrieve</param>
        /// <returns>Returns nullable float representing the AvgSaturatedHemoglobinPercent field</returns>      
        public float? GetAvgSaturatedHemoglobinPercent(int index)
        {
            return (float?)GetFieldValue(98, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgSaturatedHemoglobinPercent field
        /// Units: %
        /// Comment: Avg percentage of hemoglobin saturated with oxygen</summary>      
        /// <param name="index">0 based index of avg_saturated_hemoglobin_percent</param>
        /// <param name="avgSaturatedHemoglobinPercent_">Nullable field value to be set</param>      
        public void SetAvgSaturatedHemoglobinPercent(int index, float? avgSaturatedHemoglobinPercent_)
        {
            SetFieldValue(98, index, avgSaturatedHemoglobinPercent_, Fit.SubfieldIndexMainField);
        }


        /// <summary>
        /// 
        /// </summary>  
        /// <returns>returns number of elements in field MinSaturatedHemoglobinPercent</returns>      
        public int GetNumMinSaturatedHemoglobinPercent()
        {
            return GetNumFieldValues(99, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the MinSaturatedHemoglobinPercent field
        /// Units: %
        /// Comment: Min percentage of hemoglobin saturated with oxygen</summary>
        /// <param name="index">0 based index of MinSaturatedHemoglobinPercent element to retrieve</param>
        /// <returns>Returns nullable float representing the MinSaturatedHemoglobinPercent field</returns>      
        public float? GetMinSaturatedHemoglobinPercent(int index)
        {
            return (float?)GetFieldValue(99, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set MinSaturatedHemoglobinPercent field
        /// Units: %
        /// Comment: Min percentage of hemoglobin saturated with oxygen</summary>      
        /// <param name="index">0 based index of min_saturated_hemoglobin_percent</param>
        /// <param name="minSaturatedHemoglobinPercent_">Nullable field value to be set</param>      
        public void SetMinSaturatedHemoglobinPercent(int index, float? minSaturatedHemoglobinPercent_)
        {
            SetFieldValue(99, index, minSaturatedHemoglobinPercent_, Fit.SubfieldIndexMainField);
        }


        /// <summary>
        /// 
        /// </summary>  
        /// <returns>returns number of elements in field MaxSaturatedHemoglobinPercent</returns>      
        public int GetNumMaxSaturatedHemoglobinPercent()
        {
            return GetNumFieldValues(100, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the MaxSaturatedHemoglobinPercent field
        /// Units: %
        /// Comment: Max percentage of hemoglobin saturated with oxygen</summary>
        /// <param name="index">0 based index of MaxSaturatedHemoglobinPercent element to retrieve</param>
        /// <returns>Returns nullable float representing the MaxSaturatedHemoglobinPercent field</returns>      
        public float? GetMaxSaturatedHemoglobinPercent(int index)
        {
            return (float?)GetFieldValue(100, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set MaxSaturatedHemoglobinPercent field
        /// Units: %
        /// Comment: Max percentage of hemoglobin saturated with oxygen</summary>      
        /// <param name="index">0 based index of max_saturated_hemoglobin_percent</param>
        /// <param name="maxSaturatedHemoglobinPercent_">Nullable field value to be set</param>      
        public void SetMaxSaturatedHemoglobinPercent(int index, float? maxSaturatedHemoglobinPercent_)
        {
            SetFieldValue(100, index, maxSaturatedHemoglobinPercent_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgLeftTorqueEffectiveness field
        /// Units: percent</summary>
        /// <returns>Returns nullable float representing the AvgLeftTorqueEffectiveness field</returns>      
        public float? GetAvgLeftTorqueEffectiveness()
        {
            return (float?)GetFieldValue(101, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgLeftTorqueEffectiveness field
        /// Units: percent</summary>
        /// <param name="avgLeftTorqueEffectiveness_">Nullable field value to be set</param>      
        public void SetAvgLeftTorqueEffectiveness(float? avgLeftTorqueEffectiveness_)
        {
            SetFieldValue(101, 0, avgLeftTorqueEffectiveness_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgRightTorqueEffectiveness field
        /// Units: percent</summary>
        /// <returns>Returns nullable float representing the AvgRightTorqueEffectiveness field</returns>      
        public float? GetAvgRightTorqueEffectiveness()
        {
            return (float?)GetFieldValue(102, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgRightTorqueEffectiveness field
        /// Units: percent</summary>
        /// <param name="avgRightTorqueEffectiveness_">Nullable field value to be set</param>      
        public void SetAvgRightTorqueEffectiveness(float? avgRightTorqueEffectiveness_)
        {
            SetFieldValue(102, 0, avgRightTorqueEffectiveness_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgLeftPedalSmoothness field
        /// Units: percent</summary>
        /// <returns>Returns nullable float representing the AvgLeftPedalSmoothness field</returns>      
        public float? GetAvgLeftPedalSmoothness()
        {
            return (float?)GetFieldValue(103, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgLeftPedalSmoothness field
        /// Units: percent</summary>
        /// <param name="avgLeftPedalSmoothness_">Nullable field value to be set</param>      
        public void SetAvgLeftPedalSmoothness(float? avgLeftPedalSmoothness_)
        {
            SetFieldValue(103, 0, avgLeftPedalSmoothness_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgRightPedalSmoothness field
        /// Units: percent</summary>
        /// <returns>Returns nullable float representing the AvgRightPedalSmoothness field</returns>      
        public float? GetAvgRightPedalSmoothness()
        {
            return (float?)GetFieldValue(104, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgRightPedalSmoothness field
        /// Units: percent</summary>
        /// <param name="avgRightPedalSmoothness_">Nullable field value to be set</param>      
        public void SetAvgRightPedalSmoothness(float? avgRightPedalSmoothness_)
        {
            SetFieldValue(104, 0, avgRightPedalSmoothness_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgCombinedPedalSmoothness field
        /// Units: percent</summary>
        /// <returns>Returns nullable float representing the AvgCombinedPedalSmoothness field</returns>      
        public float? GetAvgCombinedPedalSmoothness()
        {
            return (float?)GetFieldValue(105, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgCombinedPedalSmoothness field
        /// Units: percent</summary>
        /// <param name="avgCombinedPedalSmoothness_">Nullable field value to be set</param>      
        public void SetAvgCombinedPedalSmoothness(float? avgCombinedPedalSmoothness_)
        {
            SetFieldValue(105, 0, avgCombinedPedalSmoothness_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the SportIndex field</summary>
        /// <returns>Returns nullable byte representing the SportIndex field</returns>      
        public byte? GetSportIndex()
        {
            return (byte?)GetFieldValue(111, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set SportIndex field</summary>
        /// <param name="sportIndex_">Nullable field value to be set</param>      
        public void SetSportIndex(byte? sportIndex_)
        {
            SetFieldValue(111, 0, sportIndex_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the TimeStanding field
        /// Units: s
        /// Comment: Total time spend in the standing position</summary>
        /// <returns>Returns nullable float representing the TimeStanding field</returns>      
        public float? GetTimeStanding()
        {
            return (float?)GetFieldValue(112, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set TimeStanding field
        /// Units: s
        /// Comment: Total time spend in the standing position</summary>
        /// <param name="timeStanding_">Nullable field value to be set</param>      
        public void SetTimeStanding(float? timeStanding_)
        {
            SetFieldValue(112, 0, timeStanding_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the StandCount field
        /// Comment: Number of transitions to the standing state</summary>
        /// <returns>Returns nullable ushort representing the StandCount field</returns>      
        public ushort? GetStandCount()
        {
            return (ushort?)GetFieldValue(113, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set StandCount field
        /// Comment: Number of transitions to the standing state</summary>
        /// <param name="standCount_">Nullable field value to be set</param>      
        public void SetStandCount(ushort? standCount_)
        {
            SetFieldValue(113, 0, standCount_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgLeftPco field
        /// Units: mm
        /// Comment: Average platform center offset Left</summary>
        /// <returns>Returns nullable sbyte representing the AvgLeftPco field</returns>      
        public sbyte? GetAvgLeftPco()
        {
            return (sbyte?)GetFieldValue(114, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgLeftPco field
        /// Units: mm
        /// Comment: Average platform center offset Left</summary>
        /// <param name="avgLeftPco_">Nullable field value to be set</param>      
        public void SetAvgLeftPco(sbyte? avgLeftPco_)
        {
            SetFieldValue(114, 0, avgLeftPco_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgRightPco field
        /// Units: mm
        /// Comment: Average platform center offset Right</summary>
        /// <returns>Returns nullable sbyte representing the AvgRightPco field</returns>      
        public sbyte? GetAvgRightPco()
        {
            return (sbyte?)GetFieldValue(115, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgRightPco field
        /// Units: mm
        /// Comment: Average platform center offset Right</summary>
        /// <param name="avgRightPco_">Nullable field value to be set</param>      
        public void SetAvgRightPco(sbyte? avgRightPco_)
        {
            SetFieldValue(115, 0, avgRightPco_, Fit.SubfieldIndexMainField);
        }


        /// <summary>
        /// 
        /// </summary>  
        /// <returns>returns number of elements in field AvgLeftPowerPhase</returns>      
        public int GetNumAvgLeftPowerPhase()
        {
            return GetNumFieldValues(116, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgLeftPowerPhase field
        /// Units: degrees
        /// Comment: Average left power phase angles. Indexes defined by power_phase_type.</summary>
        /// <param name="index">0 based index of AvgLeftPowerPhase element to retrieve</param>
        /// <returns>Returns nullable float representing the AvgLeftPowerPhase field</returns>      
        public float? GetAvgLeftPowerPhase(int index)
        {
            return (float?)GetFieldValue(116, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgLeftPowerPhase field
        /// Units: degrees
        /// Comment: Average left power phase angles. Indexes defined by power_phase_type.</summary>      
        /// <param name="index">0 based index of avg_left_power_phase</param>
        /// <param name="avgLeftPowerPhase_">Nullable field value to be set</param>      
        public void SetAvgLeftPowerPhase(int index, float? avgLeftPowerPhase_)
        {
            SetFieldValue(116, index, avgLeftPowerPhase_, Fit.SubfieldIndexMainField);
        }


        /// <summary>
        /// 
        /// </summary>  
        /// <returns>returns number of elements in field AvgLeftPowerPhasePeak</returns>      
        public int GetNumAvgLeftPowerPhasePeak()
        {
            return GetNumFieldValues(117, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgLeftPowerPhasePeak field
        /// Units: degrees
        /// Comment: Average left power phase peak angles. Data value indexes defined by power_phase_type.</summary>
        /// <param name="index">0 based index of AvgLeftPowerPhasePeak element to retrieve</param>
        /// <returns>Returns nullable float representing the AvgLeftPowerPhasePeak field</returns>      
        public float? GetAvgLeftPowerPhasePeak(int index)
        {
            return (float?)GetFieldValue(117, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgLeftPowerPhasePeak field
        /// Units: degrees
        /// Comment: Average left power phase peak angles. Data value indexes defined by power_phase_type.</summary>      
        /// <param name="index">0 based index of avg_left_power_phase_peak</param>
        /// <param name="avgLeftPowerPhasePeak_">Nullable field value to be set</param>      
        public void SetAvgLeftPowerPhasePeak(int index, float? avgLeftPowerPhasePeak_)
        {
            SetFieldValue(117, index, avgLeftPowerPhasePeak_, Fit.SubfieldIndexMainField);
        }


        /// <summary>
        /// 
        /// </summary>  
        /// <returns>returns number of elements in field AvgRightPowerPhase</returns>      
        public int GetNumAvgRightPowerPhase()
        {
            return GetNumFieldValues(118, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgRightPowerPhase field
        /// Units: degrees
        /// Comment: Average right power phase angles. Data value indexes defined by power_phase_type.</summary>
        /// <param name="index">0 based index of AvgRightPowerPhase element to retrieve</param>
        /// <returns>Returns nullable float representing the AvgRightPowerPhase field</returns>      
        public float? GetAvgRightPowerPhase(int index)
        {
            return (float?)GetFieldValue(118, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgRightPowerPhase field
        /// Units: degrees
        /// Comment: Average right power phase angles. Data value indexes defined by power_phase_type.</summary>      
        /// <param name="index">0 based index of avg_right_power_phase</param>
        /// <param name="avgRightPowerPhase_">Nullable field value to be set</param>      
        public void SetAvgRightPowerPhase(int index, float? avgRightPowerPhase_)
        {
            SetFieldValue(118, index, avgRightPowerPhase_, Fit.SubfieldIndexMainField);
        }


        /// <summary>
        /// 
        /// </summary>  
        /// <returns>returns number of elements in field AvgRightPowerPhasePeak</returns>      
        public int GetNumAvgRightPowerPhasePeak()
        {
            return GetNumFieldValues(119, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgRightPowerPhasePeak field
        /// Units: degrees
        /// Comment: Average right power phase peak angles data value indexes  defined by power_phase_type.</summary>
        /// <param name="index">0 based index of AvgRightPowerPhasePeak element to retrieve</param>
        /// <returns>Returns nullable float representing the AvgRightPowerPhasePeak field</returns>      
        public float? GetAvgRightPowerPhasePeak(int index)
        {
            return (float?)GetFieldValue(119, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgRightPowerPhasePeak field
        /// Units: degrees
        /// Comment: Average right power phase peak angles data value indexes  defined by power_phase_type.</summary>      
        /// <param name="index">0 based index of avg_right_power_phase_peak</param>
        /// <param name="avgRightPowerPhasePeak_">Nullable field value to be set</param>      
        public void SetAvgRightPowerPhasePeak(int index, float? avgRightPowerPhasePeak_)
        {
            SetFieldValue(119, index, avgRightPowerPhasePeak_, Fit.SubfieldIndexMainField);
        }


        /// <summary>
        /// 
        /// </summary>  
        /// <returns>returns number of elements in field AvgPowerPosition</returns>      
        public int GetNumAvgPowerPosition()
        {
            return GetNumFieldValues(120, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgPowerPosition field
        /// Units: watts
        /// Comment: Average power by position. Data value indexes defined by rider_position_type.</summary>
        /// <param name="index">0 based index of AvgPowerPosition element to retrieve</param>
        /// <returns>Returns nullable ushort representing the AvgPowerPosition field</returns>      
        public ushort? GetAvgPowerPosition(int index)
        {
            return (ushort?)GetFieldValue(120, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgPowerPosition field
        /// Units: watts
        /// Comment: Average power by position. Data value indexes defined by rider_position_type.</summary>      
        /// <param name="index">0 based index of avg_power_position</param>
        /// <param name="avgPowerPosition_">Nullable field value to be set</param>      
        public void SetAvgPowerPosition(int index, ushort? avgPowerPosition_)
        {
            SetFieldValue(120, index, avgPowerPosition_, Fit.SubfieldIndexMainField);
        }


        /// <summary>
        /// 
        /// </summary>  
        /// <returns>returns number of elements in field MaxPowerPosition</returns>      
        public int GetNumMaxPowerPosition()
        {
            return GetNumFieldValues(121, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the MaxPowerPosition field
        /// Units: watts
        /// Comment: Maximum power by position. Data value indexes defined by rider_position_type.</summary>
        /// <param name="index">0 based index of MaxPowerPosition element to retrieve</param>
        /// <returns>Returns nullable ushort representing the MaxPowerPosition field</returns>      
        public ushort? GetMaxPowerPosition(int index)
        {
            return (ushort?)GetFieldValue(121, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set MaxPowerPosition field
        /// Units: watts
        /// Comment: Maximum power by position. Data value indexes defined by rider_position_type.</summary>      
        /// <param name="index">0 based index of max_power_position</param>
        /// <param name="maxPowerPosition_">Nullable field value to be set</param>      
        public void SetMaxPowerPosition(int index, ushort? maxPowerPosition_)
        {
            SetFieldValue(121, index, maxPowerPosition_, Fit.SubfieldIndexMainField);
        }


        /// <summary>
        /// 
        /// </summary>  
        /// <returns>returns number of elements in field AvgCadencePosition</returns>      
        public int GetNumAvgCadencePosition()
        {
            return GetNumFieldValues(122, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgCadencePosition field
        /// Units: rpm
        /// Comment: Average cadence by position. Data value indexes defined by rider_position_type.</summary>
        /// <param name="index">0 based index of AvgCadencePosition element to retrieve</param>
        /// <returns>Returns nullable byte representing the AvgCadencePosition field</returns>      
        public byte? GetAvgCadencePosition(int index)
        {
            return (byte?)GetFieldValue(122, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgCadencePosition field
        /// Units: rpm
        /// Comment: Average cadence by position. Data value indexes defined by rider_position_type.</summary>      
        /// <param name="index">0 based index of avg_cadence_position</param>
        /// <param name="avgCadencePosition_">Nullable field value to be set</param>      
        public void SetAvgCadencePosition(int index, byte? avgCadencePosition_)
        {
            SetFieldValue(122, index, avgCadencePosition_, Fit.SubfieldIndexMainField);
        }


        /// <summary>
        /// 
        /// </summary>  
        /// <returns>returns number of elements in field MaxCadencePosition</returns>      
        public int GetNumMaxCadencePosition()
        {
            return GetNumFieldValues(123, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the MaxCadencePosition field
        /// Units: rpm
        /// Comment: Maximum cadence by position. Data value indexes defined by rider_position_type.</summary>
        /// <param name="index">0 based index of MaxCadencePosition element to retrieve</param>
        /// <returns>Returns nullable byte representing the MaxCadencePosition field</returns>      
        public byte? GetMaxCadencePosition(int index)
        {
            return (byte?)GetFieldValue(123, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set MaxCadencePosition field
        /// Units: rpm
        /// Comment: Maximum cadence by position. Data value indexes defined by rider_position_type.</summary>      
        /// <param name="index">0 based index of max_cadence_position</param>
        /// <param name="maxCadencePosition_">Nullable field value to be set</param>      
        public void SetMaxCadencePosition(int index, byte? maxCadencePosition_)
        {
            SetFieldValue(123, index, maxCadencePosition_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the EnhancedAvgSpeed field
        /// Units: m/s
        /// Comment: total_distance / total_timer_time</summary>
        /// <returns>Returns nullable float representing the EnhancedAvgSpeed field</returns>      
        public float? GetEnhancedAvgSpeed()
        {
            return (float?)GetFieldValue(124, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set EnhancedAvgSpeed field
        /// Units: m/s
        /// Comment: total_distance / total_timer_time</summary>
        /// <param name="enhancedAvgSpeed_">Nullable field value to be set</param>      
        public void SetEnhancedAvgSpeed(float? enhancedAvgSpeed_)
        {
            SetFieldValue(124, 0, enhancedAvgSpeed_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the EnhancedMaxSpeed field
        /// Units: m/s</summary>
        /// <returns>Returns nullable float representing the EnhancedMaxSpeed field</returns>      
        public float? GetEnhancedMaxSpeed()
        {
            return (float?)GetFieldValue(125, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set EnhancedMaxSpeed field
        /// Units: m/s</summary>
        /// <param name="enhancedMaxSpeed_">Nullable field value to be set</param>      
        public void SetEnhancedMaxSpeed(float? enhancedMaxSpeed_)
        {
            SetFieldValue(125, 0, enhancedMaxSpeed_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the EnhancedAvgAltitude field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the EnhancedAvgAltitude field</returns>      
        public float? GetEnhancedAvgAltitude()
        {
            return (float?)GetFieldValue(126, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set EnhancedAvgAltitude field
        /// Units: m</summary>
        /// <param name="enhancedAvgAltitude_">Nullable field value to be set</param>      
        public void SetEnhancedAvgAltitude(float? enhancedAvgAltitude_)
        {
            SetFieldValue(126, 0, enhancedAvgAltitude_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the EnhancedMinAltitude field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the EnhancedMinAltitude field</returns>      
        public float? GetEnhancedMinAltitude()
        {
            return (float?)GetFieldValue(127, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set EnhancedMinAltitude field
        /// Units: m</summary>
        /// <param name="enhancedMinAltitude_">Nullable field value to be set</param>      
        public void SetEnhancedMinAltitude(float? enhancedMinAltitude_)
        {
            SetFieldValue(127, 0, enhancedMinAltitude_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the EnhancedMaxAltitude field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the EnhancedMaxAltitude field</returns>      
        public float? GetEnhancedMaxAltitude()
        {
            return (float?)GetFieldValue(128, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set EnhancedMaxAltitude field
        /// Units: m</summary>
        /// <param name="enhancedMaxAltitude_">Nullable field value to be set</param>      
        public void SetEnhancedMaxAltitude(float? enhancedMaxAltitude_)
        {
            SetFieldValue(128, 0, enhancedMaxAltitude_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the AvgLevMotorPower field
        /// Units: watts
        /// Comment: lev average motor power during session</summary>
        /// <returns>Returns nullable ushort representing the AvgLevMotorPower field</returns>      
        public ushort? GetAvgLevMotorPower()
        {
            return (ushort?)GetFieldValue(129, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set AvgLevMotorPower field
        /// Units: watts
        /// Comment: lev average motor power during session</summary>
        /// <param name="avgLevMotorPower_">Nullable field value to be set</param>      
        public void SetAvgLevMotorPower(ushort? avgLevMotorPower_)
        {
            SetFieldValue(129, 0, avgLevMotorPower_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the MaxLevMotorPower field
        /// Units: watts
        /// Comment: lev maximum motor power during session</summary>
        /// <returns>Returns nullable ushort representing the MaxLevMotorPower field</returns>      
        public ushort? GetMaxLevMotorPower()
        {
            return (ushort?)GetFieldValue(130, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set MaxLevMotorPower field
        /// Units: watts
        /// Comment: lev maximum motor power during session</summary>
        /// <param name="maxLevMotorPower_">Nullable field value to be set</param>      
        public void SetMaxLevMotorPower(ushort? maxLevMotorPower_)
        {
            SetFieldValue(130, 0, maxLevMotorPower_, Fit.SubfieldIndexMainField);
        }

        ///<summary>      
        /// Retrieves the LevBatteryConsumption field
        /// Units: percent
        /// Comment: lev battery consumption during session</summary>
        /// <returns>Returns nullable float representing the LevBatteryConsumption field</returns>      
        public float? GetLevBatteryConsumption()
        {
            return (float?)GetFieldValue(131, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>        
        /// Set LevBatteryConsumption field
        /// Units: percent
        /// Comment: lev battery consumption during session</summary>
        /// <param name="levBatteryConsumption_">Nullable field value to be set</param>      
        public void SetLevBatteryConsumption(float? levBatteryConsumption_)
        {
            SetFieldValue(131, 0, levBatteryConsumption_, Fit.SubfieldIndexMainField);
        }
    }
}
