namespace DesignPatternSamples.BehavioralPattern.Observer.Sample1
{
    internal class Subject : ISubject
    {
        private string _productName;
        private int _price;
        private string _avaliability;
        private List<IObserver> _observers;

        public string ProductName { get => _productName; set => _productName = value; }
        public int Price { get => _price; set => _price = value; }
        public string Avaliability { get => _avaliability; set => _avaliability = value; }
        public List<IObserver> Observers { get => _observers; set => _observers = value; }
        public Subject(string productName, int price, string avaliability)
        {
            _productName = productName;
            _price = price;
            _avaliability = avaliability;
            _observers = new List<IObserver>();
        }

        public void SetAvaliability(string avaliability)
        {
            _avaliability = avaliability;
            NotifyObservers();
        }
        public void NotifyObservers()
        {
            foreach(var observer in _observers)
            {
                observer.Update(_avaliability);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
