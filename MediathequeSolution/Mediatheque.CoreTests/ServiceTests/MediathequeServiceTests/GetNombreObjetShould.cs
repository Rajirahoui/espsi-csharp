using Mediatheque.Core.Model;
using Mediatheque.Core.Service;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Mediatheque.CoreTests.ServiceTests.MediathequeServiceTests
{
    [TestClass]
    public class GetNombreObjetShould
    {
        private MediathequeService _mediathequeService = null!;

        [TestInitialize]
        public void Setup()
        {
            var notationServiceMock = new Mock<INotationService>().Object;
            _mediathequeService = new MediathequeService(notationServiceMock);
        }

        [TestMethod]
        public void Return0_WhenNoObject()
        {
            // Act
            int actual = _mediathequeService.GetNombreObjet();

            // Assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Return3_When3Objects()
        {
            // Arrange
            _mediathequeService.AddObjet(new CD("Spice world", "Spice girl"));
            _mediathequeService.AddObjet(new CD("Smash", "Offspring"));
            _mediathequeService.AddObjet(new JeuxDeSociete("Jeux de 54 cartes", 3, 99, "Carrefour", TypeJeuxDeSociete.Carte));

            // Act
            int actual = _mediathequeService.GetNombreObjet();

            // Assert
            Assert.AreEqual(3, actual);
        }
    }
}
