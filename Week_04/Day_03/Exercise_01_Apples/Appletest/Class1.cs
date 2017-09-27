using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Exercise_01_Apples;


namespace Appletest
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void TestApple()
        {
            string message = "apple";
            var apple = new Apple();

            string output = apple.GetApple();

            Assert.AreEqual(output, message);
        }
    }
}
