using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wypozyczalnia_produkcja.Models;

namespace WypozyczalniaUnitTest
{
    class Test_Hubert
    {
        [Test]
        public void PobieranieUzytkownika()
        {
            //arrange
            Uzytkownik user;
            Adres adres;
            Sprzet sprzet;

            //act
            user = new Uzytkownik(2);
            var result = user.Id;

            adres = user.Adres;
            var result2 = adres.Id;

            sprzet = new Sprzet(6);
            var result3 = sprzet.Uzytkownik.Id;

            //assert
            Assert.AreEqual(2, result);
            Assert.AreEqual(user.IdAdresu, result2);
            Assert.AreEqual(sprzet.IdWlasciciela, result3);
        }
    }
}

