using NUnit.Framework;
using CSharpKeyWordDisplay;
using CSharpKeyWordDisplay.VirtualDemo;

namespace CSharpKeyWordNUnitTest
{
    public class VirtualDemoTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void VirtualDemoTest1()
        {
            Cat gar = new Garfield();
            gar.Bark();
            Doraemon dor = new Doraemon();
            dor.Bark();
            Assert.Pass();
        }
    }
}