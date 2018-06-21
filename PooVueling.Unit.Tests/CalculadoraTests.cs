using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace PooVueling.Tests
{
	[TestClass()]
	public class CalculadoraTests
	{
		private ICalculadora mockObject;

		[TestInitialize] // s'executa abans que el metode de Test.
		public void Setup()
		{
			var mock = new Mock<ICalculadora>();
			mock.Setup(X => X.Suma(2, 2)).Returns(4);
			mock.Setup(X => X.Resta(4, 2)).Returns(2);
			mock.Setup(X => X.Division(4, 2)).Returns(2);
			mock.Setup(X => X.Multiplicacion(4, 2)).Returns(8);
			mockObject = mock.Object;
		}

		[TestMethod()]
		public void DivisionTest()
		{
			var result = mockObject.Division(4, 2);
			Assert.AreEqual(2, result);
		}

		
		[TestMethod]
		public void MultiplicacionTest()
		{
			var result = mockObject.Multiplicacion(4, 2);
			Assert.AreEqual(8, result);
		}

		
		[TestMethod]
		public void RestaTest()
		{
			var result = mockObject.Resta(4, 2);
			Assert.AreEqual(2, result);
		}

		
		[TestMethod]
		public void SumaTest()
		{
			var result = mockObject.Suma(2, 2);
			Assert.AreEqual(4, result);
		}


		
	}
}