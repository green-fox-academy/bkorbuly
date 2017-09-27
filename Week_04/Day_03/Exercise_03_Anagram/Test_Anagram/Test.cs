using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Exercise_03_Anagram;

namespace Test_Anagram
{
    [TestFixture]
    class Test
    {
        [Test]
        public void Test_Anagram()
        {
            var anagram = new Anagram();
            bool test = true;
            string text1, text2;
            text1 = "silversss";
            text2 = "livers";

            bool output = anagram.AnagramCheck(text1, text2);
            Assert.AreEqual(output, test);
        }
    }
}
