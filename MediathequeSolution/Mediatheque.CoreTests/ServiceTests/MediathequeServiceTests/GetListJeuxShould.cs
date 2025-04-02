using Mediatheque.Core.Model;
using Mediatheque.Core.Service;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Mediatheque.CoreTests.ServiceTests.MediathequeServiceTests
{
    [TestClass]
    public class GetListJeuxShould
    {
        [TestMethod]
        public void PasDeJeux(){
            // Arrange
            MediathequeService mediathequeService = new MediathequeService(null);


            // Act
            string actual = mediathequeService.GetListJeux();

            // Assert
            Assert.AreEqual("pas de jeux", actual);

        }

        [TestMethod]
        public void ContientQueCD(){
           
            // Arrange
            MediathequeService mediathequeService = new MediathequeService(null);
            mediathequeService.AddObjet(new CD("Spice world", "Spice girl"));
            mediathequeService.AddObjet(new CD("Smash", "Offspring"));


            // Act
            string actual = mediathequeService.GetListJeux();

            // Assert
            Assert.AreEqual("pas de jeux", actual);

        }

        [TestMethod]
        public void ContientPlusieursJeux(){
           
            // Arrange
            MediathequeService mediathequeService = new MediathequeService(null);
            mediathequeService.AddObjet( new JeuxDeSociete(" GTA", 3, 69, "Action", TypeJeuxDeSociete.Cooperation));
            mediathequeService.AddObjet( new JeuxDeSociete(" UFC", 2, 79, "Action", TypeJeuxDeSociete.Cooperation));

            // Act
            string actual = mediathequeService.GetListJeux();

            // Assert
            Assert.AreEqual("2", actual);

        }

        [TestMethod]
        public void ContientPlusieursCDetJeux(){
           
            // Arrange
            MediathequeService mediathequeService = new MediathequeService(null);
            mediathequeService.AddObjet(new CD("Spice world", "Spice girl"));
            mediathequeService.AddObjet(new CD("Smash", "Offspring"));
            mediathequeService.AddObjet( new JeuxDeSociete(" GTA", 3, 69, "Action", TypeJeuxDeSociete.Cooperation));
            mediathequeService.AddObjet( new JeuxDeSociete(" UFC", 2, 79, "Action", TypeJeuxDeSociete.Cooperation));



            // Act
            string actual = mediathequeService.GetListJeux();

            // Assert
            Assert.AreEqual("2", actual);

        }
           
    }
}
