using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComposePC;

namespace ComposePC.Tests
{
    [TestClass]
    public class ComposePCTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IScreen Screen = new ScreenNineP();
            Pc pc = new PcBuilder().WithScreen(Screen).Build();
            
            Assert.AreEqual(350.0f, pc.GetTotalPrice());
        }
    }
}
