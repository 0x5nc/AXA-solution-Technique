using AXA_solution_Technique.Interfaces;
using System;
using System.IO;

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

        public void PrintFile()
        {
            string line;

            Console.WriteLine("Printing the locked file");

            while ((line = _streamReader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        public void EditFile()
        {
            throw new System.NotImplementedException();
        }
    }
}