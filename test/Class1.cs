using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;



namespace test
{
    public class Class1
    {
        [Test] 
        public void Sum_2Plus5_7Returned()
        {
            
            Assert.AreEqual(7, ConsoleApplication1.Calc.Sum(2, 5));

        }


        [Test]
        public void Sum_9Plus1_10Returned()
        {
           
            Assert.AreEqual(10, ConsoleApplication1.Calc.Sum(9, 1));
        }

        [Test]
        public void Sum_4Plus5_9Returned()
        {
            
            Assert.AreEqual(9, ConsoleApplication1.Calc.Sum(4, 5));
        }


        [Test]
        public void Sub_2Sub5_3Returned()
        {
           
            Assert.AreEqual(-3, ConsoleApplication1.Calc.Sub(2, 5));
        }

        [Test]
        public void Sub_4Sub4_0Returned()
        {
           
            Assert.AreEqual(0, ConsoleApplication1.Calc.Sub(4, 4));
        }

        [Test]
        public void Sub_4Sub3_1Returned()
        {
          
            Assert.AreEqual(1, ConsoleApplication1.Calc.Sub(4, 3));
        }

        [Test]
        public void Mult_4Mult4_16Returned()
        {
           
            Assert.AreEqual(16, ConsoleApplication1.Calc.Mult(4, 4));
        }

        [Test]
        public void Mult_4Mult0_0Returned()
        {
           
            Assert.AreEqual(0, ConsoleApplication1.Calc.Mult(4, 0));
        }

        [Test]
        public void Mult_4Mult3_12Returned()
        {
           
            Assert.AreEqual(-12, ConsoleApplication1.Calc.Mult(4, -3));
        }


        [Test]
        public void Div_4Div4_1Returned()
        {
            
            Assert.AreEqual(1, ConsoleApplication1.Calc.Div(4, 4));
        }

        [Test]
        public void Div_4Div0_Returned()
        {
            
            Assert.AreEqual(0, ConsoleApplication1.Calc.Div(4, 0));
        }

        [Test]
        public void Div_4Div2_2Returned()
        {
            
            Assert.AreEqual(2, ConsoleApplication1.Calc.Div(4, 2));
        }
    }
}
