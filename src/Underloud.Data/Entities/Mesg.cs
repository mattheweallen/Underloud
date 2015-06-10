using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Underloud.Data.Entities
{
    public class Mesg
    {
        public ulong Id { get; set; }
        [DefaultValue(0)]
        public byte LocalNum { get; set; } 
        [DefaultValue(0)]
        public uint SystemTimeOffset { get; set; }      
        public string Name { get; set; }
        public ushort Num { get; set; }

        public List<Field> Fields { get; set; }
    }
}
