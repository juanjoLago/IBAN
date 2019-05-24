using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ejercicioIban;
namespace pruebas
{

    [TestFixture]
    public class tests
    {
        string pruebaiban = "ES6621000418401234567891";
        [TestCase]
        public void Tamañodelstring()
        {

           iban prueba = new iban();
            Assert.AreEqual(prueba.EsIBANvalido(pruebaiban), true);
        }
        
        

    }
}
