﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Underloud.Data.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public GameType GameType { get; set; }
    }
}
