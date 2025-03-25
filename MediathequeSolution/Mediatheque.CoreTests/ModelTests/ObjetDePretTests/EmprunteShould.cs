using Mediatheque.Core.Model;

namespace Mediatheque.CoreTests.ModelTests.ObjetDePretTests
{
    [TestClass()]
    public class EmprunteShould()
    {
        [TestMethod()]
        public void FillEmprunteur()
        {
            //Arrange
            var objetDePret = new ObjetDePret("Scie sauteuse" , "default" );

            //Act
            objetDePret.Emprunte("bernard");

            //Assert
            Assert.AreEqual("bernard", objetDePret.Emprunteur);
        }

        [TestMethod()]
        public void ReturnTrue_IfObjetIsAvailable()
        {
            //Arrange
            var objetDePret = new ObjetDePret("chaise" , "default");

            //Act
            var actual = objetDePret.Emprunte("albert");

            //Assert
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ReturnFalse_IfObjetIsNotAvailable()
        {
            //Arrange
            var objetDePret = new ObjetDePret("chaise", "default");
            objetDePret.Emprunte("Alain");

            //Act
            var actual = objetDePret.Emprunte("albert");

            //Assert
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
    }
}