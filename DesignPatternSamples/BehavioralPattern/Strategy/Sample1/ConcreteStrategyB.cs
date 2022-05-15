namespace DesignPattern.BehavioralPattern.Strategy.Sample1
{
    internal class ConcreteStrategyB : IStrategyContext
    {
        public object DoWork(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();

            return list;
        }
    }
}
