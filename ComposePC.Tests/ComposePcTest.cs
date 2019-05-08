using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComposePC;

namespace ComposePC.Tests
{
    [TestClass]
    public class ComposePCTest
    {
        [TestMethod]
        public void should_return_the_total_computer_price_without_item()
        {
            PC pc = new PcBuilder().Build();
            
            Assert.AreEqual(300.0f, pc.GetTotalPrice());
        }
        
        [TestMethod]
        public void should_return_the_total_computer_price_with_one_item()
        {
            IScreen screen = new ScreenNineP();
            PC pc = new PcBuilder().WithScreen(screen).Build();
            
            Assert.AreEqual(350.0f, pc.GetTotalPrice());
        }
        
        [TestMethod]
        public void should_return_the_total_computer_price_with_two_items()
        {
            IScreen screen = new ScreenNineP();
            IProcessor processor = new ProcessorI5();
            
            PC pc = new PcBuilder().WithScreen(screen).WithProcessor(processor).Build();
            
            Assert.AreEqual(750.0f, pc.GetTotalPrice());
        }
        
        [TestMethod]
        public void should_return_all_PC_component()
        {
            IScreen screen = new ScreenNineP();
            IProcessor processor = new ProcessorI5();
            IRamMemory ram = new RamMemory12Go();
            
            PC pc = new PcBuilder()
                .WithScreen(screen)
                .WithProcessor(processor)
                .WithRamMemory(ram)
                .Build();
            
            Assert.AreEqual(screen.Size, pc.GetScreen().Size);
            Assert.AreEqual(processor.Type, pc.GetProcessor().Type);
            Assert.AreEqual(ram.Size, pc.GetRamMemory().Size);
        }
        
        [TestMethod]
        public void should_not_return_PC_component()
        {
            
            PC pc = new PcBuilder().Build();
            IScreen screen = pc.GetScreen();
            
            Assert.IsNull(screen);
        }
        
        [TestMethod]
        public void should_return_initial_price_of_PC()
        {
            
            PC pc = new PcBuilder().Build();
            
            Assert.AreEqual(300.0f, pc.GetInitalPrice());
        }
    }
}
