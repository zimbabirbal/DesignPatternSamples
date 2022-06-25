namespace DesignPatternSamples.BehavioralPattern.Chain_of_Responsibility.Sample1
{
    internal class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000)
            {
                Console.WriteLine($"Go ahead and I {this.GetType().Name} approved this.");
            }
            else if (approver != null)
            {
                Console.WriteLine($"I need to bring this to the stake holder meetings.");
            }
        }
    }
}
