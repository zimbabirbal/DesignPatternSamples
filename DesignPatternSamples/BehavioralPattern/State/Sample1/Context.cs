namespace DesignPatternSamples.BehavioralPattern.State.Sample1
{
    internal class Context
    {
        private IState _state;

        public IState State { get => _state; set => _state = value; }
        public Context(IState state)
        {
            _state = state;
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}
