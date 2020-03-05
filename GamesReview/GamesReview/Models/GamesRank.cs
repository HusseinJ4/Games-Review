using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamesRank.Models
{
    public class GamesRank
    {
        public virtual int GamesId { get; set; }
        public virtual int Category { get; set; }
        public virtual string Name { get; set; }
        public virtual String Description { get; set; }
        public virtual GamesRank Rank{ get; set; }

        public virtual String Award{ get; set; }
    }
}