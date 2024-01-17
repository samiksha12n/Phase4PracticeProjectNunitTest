using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppNUnit
{
    [TestFixture]
    public class SampleTestTwo
    {
        [Test]
        public void Mocking()
        {
            int x = 9;
            int y = 19;
            Mock<ICalculator> mockCalc = new Mock<ICalculator>();
            ICalculator calc = mockCalc.Object;
            Assert.That(calc, Is.Not.Null);
        }
        [Test]
        public void Stub()
        {
            int x = 9, y = 19;
            Mock<ICalculator> mockCalc = new Mock<ICalculator>();
            mockCalc.Setup(c => c.Add(It.IsAny<Int32>(), It.IsAny<Int32>())).Returns(x + y);
            ICalculator calc = mockCalc.Object;
            Assert.That(calc.Add(x, y), Is.EqualTo(x + y));
        }
        [Test]
        public void Fake()
        {
            int x = 9, y = 19;
            FakeCalculator calc = new FakeCalculator();
            Assert.That(calc.Add(x, y), Is.GreaterThan(0));
        }
    }
}
