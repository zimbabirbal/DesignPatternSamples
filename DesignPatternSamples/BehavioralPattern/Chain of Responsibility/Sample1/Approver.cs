namespace DesignPatternSamples.BehavioralPattern.Chain_of_Responsibility.Sample1
{
    internal abstract class Approver
    {
        protected Approver approver;

        public void SetSuccessor(Approver approver)
        {
            this.approver = approver;
        }

        public abstract void ProcessRequest(Purchase purchase);
    }
}
