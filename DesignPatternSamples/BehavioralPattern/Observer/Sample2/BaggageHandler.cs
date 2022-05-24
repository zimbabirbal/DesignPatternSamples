namespace DesignPatternSamples.BehavioralPattern.Observer.Sample2
{
    public class BaggageHandler : IObservable<BaggageInfo>
    {
        private List<IObserver<BaggageInfo>> _observers;
        private List<BaggageInfo> _flights;
        public BaggageHandler()
        {
            _observers = new List<IObserver<BaggageInfo>>();
            _flights = new List<BaggageInfo>();
        }
        public IDisposable Subscribe(IObserver<BaggageInfo> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }

            foreach(var item in _flights)  
                observer.OnNext(item);

            return new Unsubscriber<BaggageInfo>(_observers, observer);
        }

        public void BaggageStatus(int flightNo)
        {
            BaggageStatus(flightNo, string.Empty, 0);
        }

        public void BaggageStatus(int flightNo, string from, int carousel)
        {
            var info = new BaggageInfo(flightNo, from, carousel);

            // Carousel is assigned, so add new info object to list.
            if (carousel > 0 && !_flights.Contains(info))
            {
                _flights.Add(info);
                foreach (var observer in _observers)
                    observer.OnNext(info);
            }
            else if (carousel == 0)
            {
                // Baggage claim for flight is done
                var _flightsToRemove = new List<BaggageInfo>();
                foreach (var flight in _flights)
                {
                    if (info.Flight == flight.Flight)
                    {
                        _flightsToRemove.Add(flight);
                        foreach (var observer in _observers)
                            observer.OnNext(info);
                    }
                }
                foreach (var flightToRemove in _flightsToRemove)
                    _flights.Remove(flightToRemove);

                _flightsToRemove.Clear();
            }
        }
        public void LastBaggageClaimed()
        {
            foreach (var observer in _observers)
                observer.OnCompleted();

            _observers.Clear();
        }
    }
}
