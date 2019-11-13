using NUnit.Framework;
using pruebasTest;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        GreetingName greetingName;

        [SetUp]
        public void SetUp()
        {
            this.greetingName = new GreetingName();
        }

        [Test]
        public void GreetinNameGreet_ValidName_HelloName()
        {
            var greet = greetingName.Greet("Martin");
            Assert.AreEqual("Hello, Martin", greet);
        }

        [Test]
        public void GreetinNameGreet_Null_HelloMyFriend()
        {
            var greet = greetingName.Greet(null);
            Assert.AreEqual("Hello, My Friend", greet);
        }

        [Test]
        public void GreetinNameGreet_UpperCaseName_HelloShout()
        {
            var greet = greetingName.Greet("MARTIN");
            Assert.AreEqual("HELLO MARTIN!", greet);
        }

        [Test]
        public void GreetinNameGreet_TwoNames_HelloToBoth()
        {
            var greet = greetingName.Greet("martin,juanjo");
            Assert.AreEqual("Hello, martin and juanjo", greet);
        }



    }
}
