namespace ComposePC
{
    public class PcBuilder
    {
        public float TotalPrice;
        public IScreen Screen;
        public IProcessor Processor;
        public IRamMemory RamMemory;

        public PcBuilder WithScreen(IScreen screen) {
            Screen = screen;
            TotalPrice += screen.Price;
            return this;
        }

        public PcBuilder WithProcessor(IProcessor processor) {
            Processor = processor;
            TotalPrice += processor.Price;
            return this;
        }

        public PcBuilder WithRamMemory(IRamMemory ramMemory) {
            RamMemory = ramMemory;
            TotalPrice += ramMemory.Price;
            return this;
        }

        public PC Build() {
            return new PC(this);
        }
    }
}