namespace DesignPatternSamples.CreationalPattern.Singleton.Sample1
{
    /// <summary>
    /// This is good way to intialize singleton
    /// Here, instantiation is triggered by the first reference to the static member of the nested class, which only occurs in Instance. 
    /// This means the implementation is fully lazy, but has all the performance benefits
    /// </summary>
    public sealed class SingletonThreadSafeLazy
    {
        public static SingletonThreadSafeLazy Instance
        {
            get { return SingletonThreadSafeNested.instance; }
        }

        public SingletonThreadSafeLazy()
        {

        }

        private class SingletonThreadSafeNested
        {
            static SingletonThreadSafeNested()
            {
            }

            internal static readonly SingletonThreadSafeLazy instance = new SingletonThreadSafeLazy();
        }
    }
}
