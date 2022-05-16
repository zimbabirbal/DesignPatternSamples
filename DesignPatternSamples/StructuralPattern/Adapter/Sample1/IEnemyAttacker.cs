namespace DesignPatternSamples.StructuralPattern.Adapter.Sample1
{
    internal interface IEnemyAttacker
    {
        public void FireWeapon();
        public void DriveForward();
        public void AssignDriver(string driver);
    }
}
