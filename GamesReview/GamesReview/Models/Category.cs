using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamesReview.Models
{
    public class Category
    {
        public virtual int CategoryID { get; set; }

        public virtual string Name { get; set; }
    }
}