namespace ComposePC
{
    public class PcBuilder
    {
        public float TotalPrice = 0.0f;
        public IScreen Screen;
        public IProcessor Processor;
        public IRamMemory RamMemory;

        public PcBuilder WithScreen(IScreen Screen) {
            this.Screen = Screen;
            this.TotalPrice += Screen.Prix;
            return this;
        }

        public PcBuilder WithProcessor(IProcessor Processor) {
            this.Processor = Processor;
            this.TotalPrice += Processor.Prix;
            return this;
        }

        public PcBuilder WithRamMemory(IRamMemory RamMemory) {
            this.RamMemory = RamMemory;
            this.TotalPrice += RamMemory.Prix;
            return this;
        }

        public Pc Build() {
            return new Pc(this);
        }
    }
}