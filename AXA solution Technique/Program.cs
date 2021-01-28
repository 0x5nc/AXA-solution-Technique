using System.Threading.Tasks;

namespace AXA_solution_Technique
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Not implementing Dependency Injection for simplicity purposes
            ProducerConsumer producerConsumer = new ProducerConsumer();

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
