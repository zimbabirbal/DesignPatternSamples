namespace DesignPattern.BehavioralPattern.Strategy.Sample1
{
    internal class ConcreteStrategyA : IStrategyContext
    {
        public object DoWork(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }
}
