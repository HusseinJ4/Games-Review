using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamesReview.Models
{
    public class GamesReviews
    {
        public virtual int GamesReviewsId { get; set; }
        public virtual string Comments { get; set; }
        public virtual int Ranking{ get; set; }
        public virtual Product ProductId { get; set; }
    }
}