namespace DesignPattern.BehavioralPattern.Strategy.Sample1
{
    public class Context
    {
        private IStrategyContext _strategyContext;

        public Context()
        {

        }

        public Context(IStrategyContext strategyContext)
        {
            _strategyContext = strategyContext;
        }

        public void SetStrategyContext(IStrategyContext strategyContext)
        {
            _strategyContext = strategyContext;
        }

        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
            var result = this._strategyContext.DoWork(new List<string> { "a", "b", "c", "d", "e" });

            string resultStr = string.Empty;
            foreach (var element in result as List<string>)
            {
                resultStr += element + ",";
            }

            Console.WriteLine(resultStr);
        }
    }

}
