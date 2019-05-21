using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades.Estacionamientos.starter;

namespace ProyectoTestUnitario
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      Estacionamiento a = new Estacionamiento(5);
      //modifica los comportamientos de la clase "Assert"
      Assert.IsNotNull(a.Autos);
    }

    [TestMethod]
    public void EspacioEstacionamientoIncorrecto()
    {
      Estacionamiento e = new Estacionamiento(101);
      Estacionamiento i = new Estacionamiento(0);

      if (e.EspacioDisponible != 101)
      {
        Assert.Fail("Espacio incorrecto {0}",e.EspacioDisponible);
      }

      Assert.AreNotEqual(i.EspacioDisponible, 1);
      if(i.EspacioDisponible != 0)
      {
        Assert.Fail("Esta mal validado el limite inferior {0}",i.EspacioDisponible);
      }
    }

    [TestMethod]
    public void AgregarAutosAEstacionamiento()
    {
      Estacionamiento e = new Estacionamiento(2);
      Auto a1 = new Auto("FFF111", ConsoleColor.Black);
      Auto a2 = new Auto("FFF222", ConsoleColor.Blue);
      Auto a3 = new Auto("FFF333", ConsoleColor.Cyan);
      try
      {
        e += a1;
        e += a2;
        e += a3;
        Assert.Fail("Error");
      }
      catch (Exception exc)
      {
        Assert.IsInstanceOfType(exc,typeof(EstacionamientoLlenoException));
      }
    }

    [TestMethod]
    public void AgregarAutoEspacioDisponible()
    {
      Estacionamiento e = new Estacionamiento(2);
      Auto a1 = new Auto("AAA111", ConsoleColor.Black);
      Auto a2 = new Auto("AAA222", ConsoleColor.Blue);

      e += a1;
      Assert.AreEqual(e.EspacioDisponible, 1);
      e += a2;
      Assert.AreEqual(e.EspacioDisponible, 0);
    }
  }
}
