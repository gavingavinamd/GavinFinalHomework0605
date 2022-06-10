using System;
using System.Collections.Generic;

namespace MapleStoryFinal0605.Models
{
    public partial class TblMonster
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Mlevel { get; set; }
        public int Atk { get; set; }
        public int Hp { get; set; }
        public string Area { get; set; } = null!;
    }
}
