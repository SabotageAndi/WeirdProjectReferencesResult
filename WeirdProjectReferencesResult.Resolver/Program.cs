using System;

namespace WeirdProjectReferencesResult.Resolver
{
    class Program
    {
        static void Main(string[] args)
        {
            var child = new WeirdProjectReferencesResult.Child.AssemblyChild();
            Console.WriteLine(child.Name);

            Console.ReadKey();
        }
    }
}
