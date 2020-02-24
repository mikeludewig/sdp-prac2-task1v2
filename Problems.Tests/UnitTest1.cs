using NUnit.Framework;

namespace Problems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string t1 = Program.Prefix("hello");
            Assert.AreEqual("5,1:hello", t1);
            //Assert.Pass();
        }

         [Test]
        public void Test2()
        {
            string t2 = Program.Prefix("");
            Assert.AreEqual("0,0:", t2);
            //Assert.Pass();
        }

         [Test]
        public void Test3()
        {
            string t3 = Program.Prefix("what      ... did you say??");
            Assert.AreEqual("27,5:what      ... did you say??", t3);
            
            //Assert.Pass();
        }
    }
}