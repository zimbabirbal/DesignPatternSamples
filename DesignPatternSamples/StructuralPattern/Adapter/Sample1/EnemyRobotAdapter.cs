namespace DesignPatternSamples.StructuralPattern.Adapter.Sample1
{
    internal class EnemyRobotAdapter : IEnemyAttacker
    {
        private readonly EnemyRobot _enemyRobot;

        public EnemyRobotAdapter(EnemyRobot enemyRobot)
        {
            _enemyRobot = enemyRobot;
        }
        public void AssignDriver(string driver)
        {
            _enemyRobot.HumanController(driver);
        }

        public void DriveForward()
        {
            _enemyRobot.WalkForward();
        }

        public void FireWeapon()
        {
            _enemyRobot.SmashWithHands();
        }
    }
}
