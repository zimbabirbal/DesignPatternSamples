namespace DesignPattern.BehavioralPattern.Strategy.Sample2
{
    internal class LeadConsultant : IRole
    {
        public string Description()
        {
            return "I'm a Lead consultant";
        }

        public string Responsibilites()
        {
            return "Make tech decisions";
        }
    }
}
