using AXA_solution_Technique.Interfaces;
using System;
using System.IO;
using System.Threading.Tasks;

namespace AXA_solution_Technique
{
    internal class ProducerConsumer : IProducerConsumer
    {
        private string _path;
        private StreamReader _streamReader;
        public void ReadFile()
        {
            
            Console.WriteLine("Enter the file path : ");
            _path = Console.ReadLine();
            FileStream fs = File.Open(_path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            BufferedStream bs = new BufferedStream(fs);
            _streamReader = new StreamReader(bs);

        }

        public Task PrintFile()
        {
            throw new System.NotImplementedException();
        }

        public Task EditFile()
        {
            throw new System.NotImplementedException();
        }
    }
}