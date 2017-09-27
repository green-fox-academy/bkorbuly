using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_02_Sum;
using NUnit.Framework;

namespace Test_SUM
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Test_Sum()
        {
            int summary = 12;
            List<int> sum = new List<int>()
            {
               2, 4, 3, 3,
            };
            var numbers = new SUM();

            int output = numbers.Summary(sum);

            Assert.AreEqual(output, summary);
        }
    }
}
