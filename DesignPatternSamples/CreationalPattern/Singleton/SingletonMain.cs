using DesignPatternSamples.CreationalPattern.Singleton.Sample1;

namespace DesignPatternSamples.CreationalPattern.Singleton
{
    /// <summary>
    /// Identifications:
    /// This pattern involves a single class which is responsible to create an object while making 
    /// sure that only single object gets created. This class provides a way to access its only object which can be accessed directly without need to instantiate the object of the class.
    ///
    ///Usage Examples:
    ///Typically a requirement of singletons is that they are created lazily - i.e. that the instance isn't created until it is first needed.
    ///
    ///Common Characteristics:
    ///-A single constructor, which is private and parameterless. This prevents other classes from instantiating it (which would be a violation of the pattern). Note that it also prevents subclassing - 
    ///     -if a singleton can be subclassed once, it can be subclassed twice, and if each of those subclasses can create an instance, the pattern is violated. The factory pattern can be used if you need a single instance of a base type, but the exact type isn't known until runtime.
    ///The class is sealed. This is unnecessary, strictly speaking, due to the above point, but may help the JIT to optimise things more.
    ///A static variable which holds a reference to the single created instance, if any.
    ///A public static means of getting the reference to the single created instance, creating one if necessary.
    ///referenced from Jon skeet C# in depth book.
    /// </summary>
    internal class SingletonMain
    {
        public static void Main()
        {
            Console.WriteLine("------------------Singleton Design pattern Sample1-------------------------");

            //thread not safe instance
            var notThreadSafeInstance = SingletonNotThreadSafe.Instance;
            Console.WriteLine($"Thread not safe object {nameof(notThreadSafeInstance)}");

            var threadSafeInstance = SingletonThreadSafe.Instance;
            Console.WriteLine($"Thread safe object {nameof(threadSafeInstance)}");

            var threadSafeInstanceNotLazy = SingletonThreadSafeNotLazy.Instance;
            Console.WriteLine($"Thread safe without lazy {nameof(threadSafeInstanceNotLazy)}");

            var threadSafeInstanceLazy = SingletonThreadSafeLazy.Instance;
            Console.WriteLine($"Thread safe with lazy {nameof(threadSafeInstanceLazy)}");

            //var singletonInstanceWithBuiltInNet = SingletonLazyNet4.Instance;
            //Console.WriteLine($"Singleton object using .NET built in {nameof(singletonInstanceWithBuiltInNet)}");

            //another way to test
            Parallel.Invoke(
                () => GetMessage1("Hello"),
                () => GetMessage2("Bye")
                );

            Console.ReadKey();
        }

        public static void GetMessage1(string message)
        {
            SingletonLazyNet4 singletonLazyNet4 = SingletonLazyNet4.Instance;
            singletonLazyNet4.DisplayMessage(message);
        }

        public static void GetMessage2(string message)
        {
            SingletonLazyNet4 singletonLazyNet4 = SingletonLazyNet4.Instance;
            singletonLazyNet4.DisplayMessage(message);
        }
    }
}
