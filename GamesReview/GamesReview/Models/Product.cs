using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamesReview.Models
{
    public class Product
    {
        public virtual int ProductId { get; set; }
        public virtual string GameName { get; set; }
        public virtual DateTime PubDate { get; set; }
        public virtual string Developer { get; set; }
        public virtual int StarRating { get; set; }

    }

}



        