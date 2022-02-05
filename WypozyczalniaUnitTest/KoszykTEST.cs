using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wypozyczalnia_produkcja.Params;

//Dominik Sanak Testy jednostkowe
namespace WypozyczalniaUnitTest
{
    class KoszykTEST
    {

        public List<int> ListaKoszyk;

        [Test]

        public void Dodawnie()
        {

            //arrange 

            ListaKoszyk = new List<int>();
            //act

            ListaKoszyk.Add(3);
            var result = ListaKoszyk.Last();
            //assert
            Assert.AreEqual(3, result);



        }

        [Test]
        public void Odejmowanie()
        {
            //arrange 

            ListaKoszyk = new List<int>();
            //act
            ListaKoszyk.Add(1);
            ListaKoszyk.Add(2);
            ListaKoszyk.Add(3);

            ListaKoszyk.Remove(3);
            var result = ListaKoszyk.Last();
            //assert
            Assert.AreEqual(3, result);


        }
        [Test]
        public void Zliczanie_przedmiotow()
        {
            //arrange 

            ListaKoszyk = new List<int>();
            //act
            ListaKoszyk.Add(1);
            ListaKoszyk.Add(2);
            ListaKoszyk.Add(3);

            var result = ListaKoszyk.Count();
            //assert
            Assert.AreEqual(2, result);


        }






    }


}

