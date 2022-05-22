namespace DesignPatternSamples.CreationalPattern.Singleton.Sample1
{
    /// <summary>
    /// Thread safe but not lazy intialize
    /// It's not as lazy as the other implementations. In particular, if you have static members other than Instance, 
    /// the first reference to those members will involve creating the instance
    /// </summary>
    public sealed class SingletonThreadSafeNotLazy
    {
        private static readonly SingletonThreadSafeNotLazy _instance = new SingletonThreadSafeNotLazy();

        static SingletonThreadSafeNotLazy()
        {

        }
        private SingletonThreadSafeNotLazy()
        {

        }

        public static SingletonThreadSafeNotLazy Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
