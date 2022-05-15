namespace DesignPattern.BehavioralPattern.PubSub.Sample1
{
    internal class EventArgument : EventArgs
    {
        private string _message;
        public string Message { get => _message; set => _message = value; }
        public EventArgument(string message)
        {
            _message = message;
        }
    }
}
