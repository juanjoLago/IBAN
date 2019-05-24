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
        [TestCase]
        public void datosmaximos()
        {
            iban tmp = new iban(3);

            Assert.AreEqual(tmp.DatosMax, 3);
        }
        [TestCase]
        public void añado()
        {
            iban tmp = new iban(3);
            
            tmp.insertar("hola");

            Assert.AreEqual(tmp.nDatos, 1);
        }
        [TestCase]
        public void MeterEstalleno()
        {
            iban tmp = new iban(1);

            try
            {
                tmp.insertar("hola");
                tmp.insertar("prueba");
                Assert.Fail();
            }
            catch
            {


            }

        }
        [TestCase]
        public void extraer()
        {
            iban tmp = new iban(3);

            tmp.insertar("hola");
            tmp.insertar("hola");
            tmp.insertar("hola");
            tmp.borrar();

            Assert.AreEqual(tmp.nDatos, 2);
        }
        [TestCase]
        public void ListaVacia()
        {
            iban tmp = new iban(3);


            Assert.AreEqual(tmp.nDatos, 0);
        }
        [TestCase]
        public void MeterYsacar()
        {
            iban tmp = new iban(3);
            tmp.insertar("hola");
            tmp.insertar("hola");
            tmp.borrar();
            tmp.borrar();

            Assert.AreEqual(tmp.nDatos, 0);
        }
        [TestCase]
        public void sacoYnoHaynada()
        {
            iban tmp = new iban(1);
            try
            {
                tmp.borrar();
                Assert.Fail();
            }
            catch
            {
                
               
            }
        }
        [TestCase]
        public void QueBorro()
        {
            iban tmp = new iban(3);
            tmp.insertar("hola");
            
           

            Assert.AreEqual(tmp.borrar(), "hola");
        }

        [TestCase]
        public void ComprobarqueNdatosSemantenga()
        {
            iban tmp = new iban(3);
            tmp.insertar("hola");
            tmp.Siguiente();


            Assert.AreEqual(tmp.nDatos, 1);
        }
        [TestCase]
        public void queSiguiente()
        {
            iban tmp = new iban(3);
            tmp.insertar("hola");
            


            Assert.AreEqual(tmp.Siguiente(), "hola");
        }
        [TestCase]
        public void preguntoDosveces()
        {
            iban tmp = new iban(3);
            tmp.insertar("hola");

            tmp.Siguiente();

            Assert.AreEqual(tmp.Siguiente(), "hola");
        }

        [TestCase]
        public void insertodosVecesypregunto()
        {
            iban tmp = new iban(3);
            tmp.insertar("hola");
            tmp.insertar("prueba");
            

            Assert.AreEqual(tmp.Siguiente(), "prueba");
        }
        [TestCase]
        public void siguienteYNohay()
        {
            iban tmp = new iban(1);
            try
            {
                tmp.Siguiente();
                Assert.Fail();
            }
            catch
            {


            }
        }
        
        

    }
}
