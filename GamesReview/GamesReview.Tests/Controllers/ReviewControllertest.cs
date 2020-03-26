using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GamesReview;
using GamesReview.Controllers;

namespace GamesReview.Tests.Controllers
{   
    [TestClass]
   public class ReviewControllertest
    {
        [TestMethod]
        public void Index()
        {
            //arrange
            GamesReviewsController controller = new GamesReviewsController();           
        }

        [TestMethod]
        public void Details(int? id)
        {
            // Arrange
            GamesReviewsController controller = new GamesReviewsController();

            // Act
            ViewResult result = controller.Details(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Create()
        {
            // Arrange
            GamesReviewsController controller = new GamesReviewsController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        
        [TestMethod]
        public void Edit()
        {
            // Arrange
            GamesReviewsController controller = new GamesReviewsController();

            // Act
            ViewResult result = controller.Edit(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void Delete()
        {
            // Arrange
            GamesReviewsController controller = new GamesReviewsController();

            int? Index = null;
            // Act
            ViewResult result = controller.Delete(Index) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


    }
}
