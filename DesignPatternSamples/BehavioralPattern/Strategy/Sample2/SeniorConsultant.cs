namespace DesignPattern.BehavioralPattern.Strategy.Sample2
{
    internal class SeniorConsultant : IRole
    {
        public string Description()
        {
            return "I'm a Senior consultant";
        }

        public string Responsibilites()
        {
            return "Review a code";
        }
    }
}
