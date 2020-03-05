using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamesReview.Models
{
    public class Product
    {
        public virtual int ProductID { get; set; }

        public virtual Category CategoryID { get; set; }

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual decimal Price { get; set; }
        public virtual string EmbedLink { get; set; }
    }
}