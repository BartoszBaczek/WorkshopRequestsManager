using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkshopManager;

namespace UnitTests
{
    [TestClass]
    public class PartTests
    {
        [TestMethod]
        public void ShouldReturnTrueWhenPartsAreEqual()
        {
            Part part = new Part("Kierownica", 24.0, 1);
            Part newPart = new Part("Kierownica", 24.0, 1);

            bool partsAreEqual = part.Equals(newPart);

            Assert.IsTrue(partsAreEqual);
        }

        [TestMethod]
        public void ShouldSetIdWhenSetId()
        {
            Part testPart = new Part("Sruba", 3.0, 1);
            testPart.SetId(90);

            Assert.IsTrue(testPart.ID == 90);
        }
    }
}
