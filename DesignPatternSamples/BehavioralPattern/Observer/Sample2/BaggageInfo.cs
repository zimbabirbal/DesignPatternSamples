namespace DesignPatternSamples.BehavioralPattern.Observer.Sample2
{
    public class BaggageInfo
    {
        private readonly int _flight;
        private readonly string _from;
        private readonly int _carousel;

        public string From => _from;
        public int Flight => _flight;
        public int Carousel => _carousel;
        internal BaggageInfo(int flight, string from, int carousel)
        {
            _flight = flight;
            _from = from;
            _carousel = carousel;
        }
    }
}
