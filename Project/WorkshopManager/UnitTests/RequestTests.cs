using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkshopManager;
using WorkshopManager.Models.IRequest;

namespace UnitTests
{
    [TestClass]
    public class RequestUnitTests
    {
        [TestMethod]
        public void DoKrystiana()       //Wypierdol potem cały ten test. Ten nizej mozesz zostawic.
        {
            string model = "Fiat";
            string owner = "Andrzej Miodek";
            string mark = "126p";
            string description = "Wymiana zderzaka";
            List<Part> parts = new List<Part>()
            {
                new Part("Uszczelka", 40),
                new Part("Kierownica", 400),
                new Part("Opona", 600)
            };

            //Do Krystiana : ja sobie tworze obiekt w ten sposob. Dzieki temu nie mam dostepu do metody SetId()
            IRequest request_1 = new Request(model, owner, mark, description, parts);
            //acces1.SetId(34); <- u mnie nie dziala


            //Do Krystiana : i ja wysylam do ciebie obiekt wlasnie w takiej ^ formie. U cibie zaraz
            //na starcie bedzie sie robilo cos takiego:
            IRequestWithIdAcces request_2 = (IRequestWithIdAcces)request_1;
            //dzieki temu zyskujesz dostep do dodatkowe metody: setID(int ID)
            request_2.SetId(34);    // <- u ciebie dziala

            //Jezeli potrzebujesz utworzyc obiekt od zera, a nie na podstawie otrzymanego ode mnie:
            IRequestWithIdAcces request_3 = new Request(model, owner, mark, description, parts);

            Assert.IsTrue(1 == 1);
        }

        [TestMethod]
        public void ShouldNotChangeFieldsWhenProjectedFromIRequestToIRequestWithAcces()
        {
            string model = "Fiat";
            string owner = "Andrzej Miodek";
            string mark = "126p";
            string description = "Wymiana zderzaka";
            List<Part> parts = new List<Part>()
            {
                new Part("Uszczelka", 40),
                new Part("Kierownica", 400),
                new Part("Opona", 600)
            };

            IRequest request = new Request(model, owner,mark, description, parts);

            IRequestWithIdAcces requestWithIdAcces = (IRequestWithIdAcces) request;

            Assert.IsTrue(request.Model == requestWithIdAcces.Model &&
                          request.Owner == requestWithIdAcces.Owner &&
                          request.Description == requestWithIdAcces.Description &&
                          request.ListOfParts.Except(requestWithIdAcces.ListOfParts).Count() == 0 &&        //Asserts, that
                          requestWithIdAcces.ListOfParts.Except(request.ListOfParts).Count() == 0);         //lists are the same.
                                                                                                            //In future change to Equals method
        }

        [TestMethod]
        public void SouldSetIDWhenSetID()
        {
            string model = "Fiat";
            string owner = "Andrzej Miodek";
            string mark = "126p";
            string description = "Wymiana zderzaka";
            List<Part> parts = new List<Part>()
            {
                new Part("Uszczelka", 40),
                new Part("Kierownica", 400),
                new Part("Opona", 600)
            };
            Request a = new Request(model, owner,mark, description, parts);
                int id = 34;
            a.SetId(id);

            Assert.AreEqual(id, a.ID);
        }


        [TestMethod]
        public void ShouldRetrunTrueWhenVariablesAreEquals()
        {
            string model = "Fiat";
            string owner = "Andrzej Miodek";
            string mark = "126p";
            string description = "Wymiana zderzaka";
            List<Part> parts = new List<Part>()
            {
                new Part("Uszczelka", 40),
                new Part("Kierownica", 400),
                new Part("Opona", 600)
            };
            Request a = new Request(model, owner, mark, description, parts);
            Request b = new Request(model, owner, mark, description, parts);
            Assert.IsTrue(a.Equals(b));
        }


        [TestMethod]
        public void ShouldReturnFalseWhenListIsNotEqual()
        {
            string model = "Fiat";
            string owner = "Andrzej Miodek";
            string mark = "126p";
            string description = "Wymiana zderzaka";
            List<Part> parts = new List<Part>()
            {
                new Part("Uszczelka", 40),
                new Part("Kierownica", 400),
                new Part("Opona", 600)
            };
            List<Part> parts2 = new List<Part>()
            {
                new Part("Uszczelka", 40),
                new Part("Lampa przednia", 270),
                new Part("Opona", 600)
            };
            Request a = new Request(model, owner, mark, description, parts);
            Request b = new Request(model, owner, mark, description, parts2);
            Assert.IsFalse(a.Equals(b));
        }
    }
}
