using Microsoft.Extensions.DependencyInjection;

namespace Hades.Gateway.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .BuildServiceProvider();

            while(true)
            {
                System.Console.ReadKey();
            }
        }
    }
}
