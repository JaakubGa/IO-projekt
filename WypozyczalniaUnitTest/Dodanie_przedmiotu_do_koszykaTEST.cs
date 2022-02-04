using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wypozyczalnia_produkcja.Pages;

//Dominik Sanak Testy jednostkowe
namespace WypozyczalniaUnitTest
{
    class Dodanie_przedmiotu_do_koszykaTEST
    {
      
        public List<int> ListaKoszyk = new List<int>();

        [Test]

        public void Dodawnie()
        {
            //arrange 

            ListaKoszyk = new List<int>();
            //act

            ListaKoszyk.Add(3);
            var result = ListaKoszyk.Last()-1;
            //assert
            Assert.AreEqual(3, result);

        }


    }


}

