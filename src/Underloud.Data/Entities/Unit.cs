using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Underloud.Data.Entities
{
    public class Unit
    {
        public int UnitId { get; set; }
        public string SIUnit { get; set; }
        public string IPUnit { get; set; }
        public double ConversionFactor { get; set; }
    }
}
