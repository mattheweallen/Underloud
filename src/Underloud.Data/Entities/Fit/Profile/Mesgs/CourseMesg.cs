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
   /// Implements the Course profile message.
   /// </summary>  
   public class CourseMesg : Mesg 
   {    
      #region Fields     
      #endregion

      #region Constructors                 
      public CourseMesg() : base(Profile.mesgs[Profile.CourseIndex])               
      {                 
      }
      
      public CourseMesg(Mesg mesg) : base(mesg)
      {
      }
      #endregion // Constructors

      #region Methods    
      ///<summary>      
      /// Retrieves the Sport field</summary>
      /// <returns>Returns nullable Sport enum representing the Sport field</returns>      
      public Sport? GetSport()   
      { 
         object obj = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
         Sport? value = obj == null ? (Sport?)null : (Sport)obj;
         return value;                     
      }

      /// <summary>        
      /// Set Sport field</summary>
      /// <param name="sport_">Nullable field value to be set</param>      
      public void SetSport(Sport? sport_) 
      {  
         SetFieldValue(4, 0, sport_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the Name field</summary>
      /// <returns>Returns byte[] representing the Name field</returns>      
      public byte[] GetName()   
      {                
         return (byte[])GetFieldValue(5, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set Name field</summary>
      /// <param name="name_">field value to be set</param>      
      public void SetName(byte[] name_) 
      {  
         SetFieldValue(5, 0, name_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the Capabilities field</summary>
      /// <returns>Returns nullable uint representing the Capabilities field</returns>      
      public uint? GetCapabilities()   
      {                
         return (uint?)GetFieldValue(6, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set Capabilities field</summary>
      /// <param name="capabilities_">Nullable field value to be set</param>      
      public void SetCapabilities(uint? capabilities_) 
      {  
         SetFieldValue(6, 0, capabilities_, Fit.SubfieldIndexMainField);
      }
                        
      #endregion // Methods
   } // Class
} // namespace
