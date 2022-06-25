namespace DesignPatternSamples.BehavioralPattern.Chain_of_Responsibility.Sample2
{
    internal abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;
        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return _nextHandler;
        }

        public virtual object Handle(object request)
        {
            if (_nextHandler != null)
                return _nextHandler.Handle(request);

            return null;
        }
    }
}
