using gestionBancariaApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTests
    {
        [TestMethod]
        // unit test code [TestMethod]
        public void validarMetodoIngreso()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual;
            double saldoEsperado = 1500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarIngreso(ingreso);
            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod]
        public void validarMetodoIngresoZero()
        {
            double saldoInicial = 1000;
            double ingreso = 0;
            double saldoActual;
            double saldoEsperado = 1000;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarIngreso(ingreso);
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        public void validarMetodoReintegro()
        {
            double saldoInicial = 1000;
            double reintegro = 500;
            double saldoActual;
            double saldoEsperado = 500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarReintegro(reintegro);
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0, "El saldo de la cuenta no es correcto");    
        }
        [TestMethod]
        public void validarMetodoReintegroZero()
        {
            double saldoInicial = 1000;
            double reintegro = 1000;
            double saldoActual;
            double saldoEsperado = 0;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarReintegro(reintegro);
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.1 , "El saldo de la cuenta debería ser 0");
        }
    }
}
