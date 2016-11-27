using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Cars;

namespace MyNUnitTestProject
{
    [TestFixture]
    public class MyTestClass
    {
        [TestCase(4,5,9)]
        public void MyTestMethod(int n, int m, int r)
        {
            //arrange
            Car c=new Car();
            //act
            int result = c.Add(n, m);
            //assert
            Assert.AreEqual(r,result);

        }
    }
}
