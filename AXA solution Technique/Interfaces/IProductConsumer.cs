using System.Threading.Tasks;

namespace AXA_solution_Technique.Interfaces
{
    public interface IProducerConsumer
    {
        void ReadFile();
        Task PrintFile();
        Task EditFile();
    }
}
