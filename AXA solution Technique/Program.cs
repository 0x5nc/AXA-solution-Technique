namespace AXA_solution_Technique
{
    class Program
    {
        static void Main(string[] args)
        {
            //Not implementing Dependency Injection for simplicity purposes
            ProducerConsumer producerConsumer = new ProducerConsumer();

            //Reading the simulated large txt file input
            producerConsumer.ReadFile();

            //Printing File then Editing for the implemented lock 
            producerConsumer.PrintFile();
            producerConsumer.EditFile();
            producerConsumer.PrintFile();
            producerConsumer.EditFile();
        }
    }
}
