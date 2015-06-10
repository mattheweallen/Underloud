using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Underloud.Data.Entities
{
    public class FieldComponent
    {
        public ulong Id { get; set; }
        public byte FieldNum { get; set; }
        public bool Accumulate { get; set; }
        public int Bits { get; set; }
        public float Scale { get; set; }
        public float Offset { get; set; }
        [DefaultValue(0)]
        public long AccumulatedValue { get; set; }
        [DefaultValue(0)]
        public long LastValue { get; set; }
    }
}
