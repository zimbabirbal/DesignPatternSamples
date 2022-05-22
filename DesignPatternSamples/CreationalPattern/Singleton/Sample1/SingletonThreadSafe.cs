namespace DesignPatternSamples.CreationalPattern.Singleton.Sample1
{
    /// <summary>
    /// Thread safe
    /// but performance suffers as a lock is acquired every time the instance is requested.
    /// </summary>
    public sealed class SingletonThreadSafe
    {
        private static SingletonThreadSafe _instance = null;

        private static readonly object _instanceLock = new object();

        public SingletonThreadSafe()
        {

        }

        public static SingletonThreadSafe Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                        _instance = new SingletonThreadSafe();
                    return _instance;
                }
            }
        }
    }
}
