using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Underloud.Data.Entities
{
    public class PlayerRank
    {
        public int Id { get; set; }
        public int Rank { get; set; }
        public virtual Player Player { get; set; }
        public virtual Game Game { get; set; }
    }
}
