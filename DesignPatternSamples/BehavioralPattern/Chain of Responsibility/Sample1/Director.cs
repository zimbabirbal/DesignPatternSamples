namespace DesignPatternSamples.BehavioralPattern.Chain_of_Responsibility.Sample1
{
    internal class Director : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000)
            {
                Console.WriteLine($"Go ahead and purchase it, I { this.GetType().Name} approved it");
            }
            else if (approver != null)
            {
                Console.WriteLine($"I can't approve this, need higher level of permission.");
                this.approver.ProcessRequest(purchase);
            }
        }
    }
}
