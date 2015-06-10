using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Underloud.Data.Entities
{
    public class Field
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public byte Num { get; set; }
        public byte Type { get; set; }
        public float Scale { get; set; }
        public float Offset { get; set; }
        public string Units { get; set; }

        public List<object> Values { get; set; }
        public List<Subfield> Subfields { get; set; }
        public List<FieldComponent> Components { get; set; }
    }
}
