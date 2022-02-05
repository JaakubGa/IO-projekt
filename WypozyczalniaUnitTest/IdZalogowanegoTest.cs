using NUnit.Framework;

namespace WypozyczalniaUnitTest
{
    //sabina
    public class IdZalogowanegoTest
    {
        int _idZalogowanego;
        bool _metoda;
        bool metoda;
        public int IdZalogowanego
        {
            get { return _idZalogowanego; }
            set
            {
                _idZalogowanego = value;
                _metoda = true;
                var metoda = true;
            }
        }

        [Test]
        public void PobieranieUzytkownika()
        {
            //arrange
            IdZalogowanego = 1;
            //act
            var result = _idZalogowanego;
            //assert
            Assert.AreEqual(1, result);
            Assert.IsTrue(_metoda);
            Assert.IsTrue(metoda);
        }
    }
}