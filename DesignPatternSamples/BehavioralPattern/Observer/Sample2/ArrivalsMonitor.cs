namespace DesignPatternSamples.BehavioralPattern.Observer.Sample2
{
    internal class ArrivalsMonitor : IObserver<BaggageInfo>
    {
        private string _name;
        private List<string> _flightInfos = new List<string>();
        private IDisposable _cancellation;
        private string _fmt = "{0,-20} {1,5}  {2, 3}";

        public ArrivalsMonitor(string name)
        {
            this._name = name;
        }

        public virtual void Subscribe(BaggageHandler provider)
        {
            _cancellation = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            _cancellation.Dispose();
            _flightInfos.Clear();
        }
        public void OnCompleted()
        {
            _flightInfos.Clear();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(BaggageInfo info)
        {
            bool updated = false;

            // Flight has unloaded its baggage; remove from the monitor.
            if (info.Carousel == 0)
            {
                var flightsToRemove = new List<string>();
                string flightNo = String.Format("{0,5}", info.Flight);

                foreach (var flightInfo in _flightInfos)
                {
                    if (flightInfo.Substring(21, 5).Equals(flightNo))
                    {
                        flightsToRemove.Add(flightInfo);
                        updated = true;
                    }
                }
                foreach (var flightToRemove in flightsToRemove)
                    _flightInfos.Remove(flightToRemove);

                flightsToRemove.Clear();
            }
            else
            {
                // Add flight if it does not exist in the collection.
                string flightInfo = String.Format(_fmt, info.From, info.Flight, info.Carousel);
                if (!_flightInfos.Contains(flightInfo))
                {
                    _flightInfos.Add(flightInfo);
                    updated = true;
                }
            }
            if (updated)
            {
                _flightInfos.Sort();
                Console.WriteLine("Arrivals information from {0}", this._name);
                foreach (var flightInfo in _flightInfos)
                    Console.WriteLine(flightInfo);

                Console.WriteLine();
            }
        }
    }
}
