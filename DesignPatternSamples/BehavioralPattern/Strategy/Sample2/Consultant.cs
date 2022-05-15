namespace DesignPattern.BehavioralPattern.Strategy.Sample2
{
    internal class Consultant : IRole
    {
        public string Description()
        {
            return "I'm a consultant";
        }

        public string Responsibilites()
        {
            return "Write a code";
        }
    }
}
