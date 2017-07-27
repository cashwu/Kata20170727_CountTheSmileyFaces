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

        [TestMethod]
        public void input_5_smiley_should_1_smileys()
        {
            var kata = new Kata();
            var actual = kata.CountSmileys(new[] { ";]", ":[", ";*", ":$", ";-D" });
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void input_4_smiley_should_3_smileys()
        {
            var kata = new Kata();
            var actual = kata.CountSmileys(new[] { ":)", ";(", ";}", ":-D" });
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void input_4_smiley_should_2_smileys()
        {
            var kata = new Kata();
            var actual = kata.CountSmileys(new[] { ";D", ":-(", ":-)", ";~)" });
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void input_4_smiley_should_4_smileys()
        {
            var kata = new Kata();
            var actual = kata.CountSmileys(new[] { ":D", ":~)", ";~D", ":)" });
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void input_5_smiley_should_2_smileys()
        {
            var kata = new Kata();
            var actual = kata.CountSmileys(new[] { ":)", ":(", ":D", ":O", ":;" });
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void input_5_smiley_should_0_smileys()
        {
            var kata = new Kata();
            var actual = kata.CountSmileys(new[] { ";", ")", ";*", ":$", "8-D" });
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void input_5_smiley_should_3_smileys_RandomTest()
        {
            var kata = new Kata();
            var actual = kata.CountSmileys(new[] { ")", ";-D", ";-P", ":-)", ";D" });
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void input_6_smiley_should_3_smileys_RandomTest()
        {
            var kata = new Kata();
            var actual = kata.CountSmileys(new[] { "8(", ":)", "8(", ":~(", ";~)", ";)" });
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void input_6_smiley_should_1_smileys_RandomTest()
        {
            var kata = new Kata();
            var actual = kata.CountSmileys(new[] { "8-)", ";)", ";~P", "; )", "8(", "8 )" });
            Assert.AreEqual(1, actual);
        }
    }

    public class Kata
    {
        public int CountSmileys(string[] smileys)
        {
            return smileys.Count(smiley => smiley.Trim(':', ';').Length > 0 
                                    && (smiley.Trim('-', '~').Length == smiley.Length || smiley.Trim('-', '~').Length == 0)
                                    && smiley.Trim(')', 'D').Length > 0
                                    && smiley.Trim(':', ';', '-', '~', ')', 'D').Length == 0);
        }
    }
}
