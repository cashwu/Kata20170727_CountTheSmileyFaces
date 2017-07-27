using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170727_CountTheSmileyFaces
{
    [TestClass]
    public class CountSmileysTests
    {
        [TestMethod]
        public void input_1_smiley_should_1_smileys()
        {
            var kata = new Kata();
            var actual = kata.CountSmileys(new[] { ":)" });
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void input_1_smiley_should_0_smileys()
        {
            var kata = new Kata();
            var actual = kata.CountSmileys(new[] { ":(" });
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void input_2_smiley_should_2_smileys()
        {
            var kata = new Kata();
            var actual = kata.CountSmileys(new[] { ":)", ":D" });
            Assert.AreEqual(2, actual);
        }
    }

    public class Kata
    {
        public int CountSmileys(string[] smileys)
        {
            var smileyKeys = new char[] { ':', ')', 'D' };

            var result = smileys.Count(a => a.ToCharArray().Count(b => smileyKeys.Contains(b)) == a.ToCharArray().Length );
            return result;
        }
    }
}
