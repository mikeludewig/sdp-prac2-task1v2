using NUnit.Framework;

namespace Problems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void TestA();
            [TestCase("hello", "5,1:hello")]
            [TestCase("", "0,0:")]
            [TestCase("what      ... did you say??", "27,5:what      ... did you say??")]
            [TestCase("I might actually understand this...", "35,5:I might actually understand this...")]
            [TestCase(null, null)]
            [TestCase("Hoping     this   works", "23,3:Hoping     this   works")]
        public void TestA(string input, string output)
        {
            Program Program = new Program();
            
            Assert.AreEqual(Program.Prefix(input), output);
        }
        //[Test]
        //public void Test()
        //{
        //    string t1 = Program.Prefix("hello");
        //    Assert.AreEqual("5,1:hello", t1);
            //Assert.Pass();
        //}
        // [Test]
        //public void Test2()
        //{
        //    string t2 = Program.Prefix("");
        //    Assert.AreEqual("0,0:", t2);
        //    //Assert.Pass();
        //}

         //[Test]
        //public void Test3()
        //{
        //    string t3 = Program.Prefix("what      ... did you say??");
        //    Assert.AreEqual("27,5:what      ... did you say??", t3);
            
            //Assert.Pass();
        //}
    }
}