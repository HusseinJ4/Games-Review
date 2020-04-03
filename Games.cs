using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamesReview.Models
{
    public class Games
    {

        public virtual int GamesId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Developer { get; set; }
        public virtual string Genre { get; set; }
        public virtual string Rating { get; set; }
        public virtual Int32 ReleaseYear { get; set; }
        public virtual string Summary { get; set; }
    }
}