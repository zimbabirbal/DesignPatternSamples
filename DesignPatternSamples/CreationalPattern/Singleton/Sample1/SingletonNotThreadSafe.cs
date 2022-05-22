namespace DesignPatternSamples.CreationalPattern.Singleton.Sample1
{
    /// <summary>
    /// bad code do not use
    /// Not thread safe.
    /// Two different threads could both have evaluated the test if (instance==null) and found it to be true, then both create instances, which violates the singleton pattern. 
    /// Note that in fact the instance may already have been created before the expression is evaluated
    /// </summary>
    public sealed class SingletonNotThreadSafe
    {
        private static SingletonNotThreadSafe _instance = null;

        private SingletonNotThreadSafe()
        {

        }

        public static SingletonNotThreadSafe Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SingletonNotThreadSafe();
                return _instance;
            }
        }
    }
}
