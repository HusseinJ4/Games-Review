using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GamesReview.Models
{
    public class ProductDataInitialiser : DropCreateDatabaseAlways<ProductContext>
    {

        protected override void Seed (ProductContext context)
        {
            Category cat1 = new Category();

            cat1.CategoryID =  1;
            cat1.Name = "Desktop Games";
            

        }
    }
}