using System;

namespace ComposePC
{
    public class Pc
    {
        private const float InitalPricePc = 300.0f;
        private float TotalPrice = 0.0f;
        private IScreen Screen;
        private IProcessor Processor;
        private IRamMemory RamMemory;

        public Pc(PcBuilder builder)
        {
            this.TotalPrice = builder.TotalPrice + InitalPricePc;
            this.Screen = builder.Screen;
            this.Processor = builder.Processor;
            this.RamMemory = builder.RamMemory;
        }

        public IScreen GetScreen()
        {
            return this.Screen;
        }

        public IProcessor GetProcessor()
        {
            return this.Processor;
        }

        public IRamMemory GetRamMemory()
        {
            return this.RamMemory;
        }

        public float GetInitalPricePc()
        {
            return InitalPricePc;
        }

        public float GetTotalPrice()
        {
            return this.TotalPrice;
        }
    }
}
