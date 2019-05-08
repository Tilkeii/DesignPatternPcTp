using System;

namespace ComposePC
{
    public class PC
    {
        private const float InitialPrice = 300.0f;
        private readonly float _totalPrice;
        private readonly IScreen _screen;
        private readonly IProcessor _processor;
        private readonly IRamMemory _ramMemory;

        public PC(PcBuilder builder)
        {
            _totalPrice = builder.TotalPrice + InitialPrice;
            _screen = builder.Screen;
            _processor = builder.Processor;
            _ramMemory = builder.RamMemory;
        }

        public IScreen GetScreen()
        {
            return _screen;
        }

        public IProcessor GetProcessor()
        {
            return _processor;
        }

        public IRamMemory GetRamMemory()
        {
            return _ramMemory;
        }

        public float GetInitalPrice()
        {
            return InitialPrice;
        }

        public float GetTotalPrice()
        {
            return _totalPrice;
        }
    }
}
