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
        private object fileLock = new object();
        public void ReadFile()
        {
            lock (fileLock)
            {
                Console.WriteLine("Enter the file path : ");
                _path = Console.ReadLine();
                FileStream fs = File.Open(_path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                BufferedStream bs = new BufferedStream(fs);
                _streamReader = new StreamReader(bs);
            }
        }

        public async Task PrintFile()
        {
            lock (fileLock)
            {
                string line;

                Console.WriteLine("Printing the locked file");

                while ((line = _streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            await Task.Delay(5000);
        }

        public async Task EditFile()
        {
            lock (fileLock)
            {
                Console.WriteLine("Editing the locked file");
            }
            await Task.Delay(5000);
        }
    }
}