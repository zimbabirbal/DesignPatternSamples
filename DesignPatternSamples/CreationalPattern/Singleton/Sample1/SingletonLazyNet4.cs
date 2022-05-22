namespace DesignPatternSamples.CreationalPattern.Singleton.Sample1
{
    /// <summary>
    /// Best and recommend way to create Singleton using built in .Net Singleton
    /// If you're using .NET 4 (or higher), you can use the System.Lazy<T> type to make the laziness really simple. 
    /// All you need to do is pass a delegate to the constructor which calls the Singleton constructor - which is done most easily with a lambda expression.
    /// </summary>
    public sealed class SingletonLazyNet4
    {
        private static readonly Lazy<SingletonLazyNet4> _lazy = new Lazy<SingletonLazyNet4>(() =>
        new SingletonLazyNet4());

        public static SingletonLazyNet4 Instance
        {
            get
            { return _lazy.Value; }
        }

        private SingletonLazyNet4()
        {

        }
    }
}
