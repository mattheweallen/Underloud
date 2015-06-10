using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Underloud.Data.Entities
{
    /// <summary>
    /// The Subfield class represents an alternative field definition used
    /// by dynamic fields.  They can only be associated with a containing 
    /// field object.  
    /// </summary> 
    public class Subfield
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public byte Type { get; set; }
        public float Scale { get; set; }
        public float Offset { get; set; }
        public string Units { get; set; }
        public List<SubfieldMap> Maps { get; set; }
        public List<FieldComponent> Components { get; set; }
    }
}
