using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using learn_English;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() 
        {
            Word w = new Word("ball*");
            Assert.IsFalse(w.Validation);
        }


        [TestMethod]
        public void TestMethod2()
        {
            Sentence s = new Sentence("“I like to eat pizza");
            Assert.IsTrue(s.Validation);
        }


        [TestMethod]
        public void TestMethod3()
        {
            Word w = new Word("sunflower*");
            Assert.IsInstanceOfType(w, typeof(EnglishConstruct));
        }


        [TestMethod]
        public void TestMethod4()
        {
            Word w = new Word("sunflower*");
            Assert.AreEqual(9, w.NumOfChars);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Sentence s = new Sentence("");
            Assert.AreNotEqual(s.Content,"");

        }

    }
}
