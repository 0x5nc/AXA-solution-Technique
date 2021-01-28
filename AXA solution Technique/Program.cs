using AXA_solution_Technique.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace AXA_solution_Technique
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Implementing Dependency Injection
            var serviceProvider = new ServiceCollection()
                .AddTransient<IProducerConsumer, ProducerConsumer>()
                .BuildServiceProvider();

            var producerConsumer = serviceProvider.GetService<IProducerConsumer>();

            //Reading the simulated large txt file input
            producerConsumer.ReadFile();

            //Printing File then Editing for the implemented lock 
            await producerConsumer.PrintFile();
            await producerConsumer.EditFile();
            await producerConsumer.PrintFile();
            await producerConsumer.EditFile();
        }
    }
}
