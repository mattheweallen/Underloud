using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Underloud.Data.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
    }
}
