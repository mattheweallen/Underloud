using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Underloud.Data.Entities
{
    public class AthleteRank
    {
        public int Id { get; set; }
        public int Rank { get; set; }
        public virtual Athlete Athlete { get; set; }
        public virtual Course Course { get; set; }
    }
}
