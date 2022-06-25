namespace DesignPatternSamples.BehavioralPattern.Chain_of_Responsibility.Sample2
{
    internal class ClientHandler
    {
        public void PassToClient(AbstractHandler abstractHandler)
        {
            foreach (var item in new List<string>() { "banana", "nuts", "coffee", "none" })
            {
                Console.WriteLine($"who wants this {item}?");
                var result = abstractHandler.Handle(item);

                if (result != null)
                    Console.WriteLine($"{result}");
                else
                    Console.WriteLine($"no was interested in {item}");
            }
        }
    }
}
