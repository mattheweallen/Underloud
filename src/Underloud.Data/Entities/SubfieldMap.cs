using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Underloud.Data.Entities
{
    /// <summary>
    /// The SubfieldMap class tracks the reference field/value pairs which indicate a field
    /// should use the alternate subfield definition rather than the usual defn (allows Dynamic Fields)     
    /// </summary>
    public class SubfieldMap
    {
        public ulong Id { get; set; }
        public byte RefFieldNum { get; set; }
        public object RefFieldValue { get; set; }
    }
}
