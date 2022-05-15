namespace DesignPattern.BehavioralPattern.Strategy.Sample2
{
    internal class PrincilpleConsultant : IRole
    {
        public string Description()
        {
            return "I'm a Principle Consultant";
        }

        public string Responsibilites()
        {
            return "Talk to clients";
        }
    }
}
