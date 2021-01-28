using AXA_solution_Technique.Interfaces;
using System;
using System.IO;
using System.Threading.Tasks;

namespace AXA_solution_Technique
{
    internal class ProducerConsumer : IProducerConsumer
    {
        private string _path;
        private object fileLock = new object();
        private StreamReader _streamReader;

        //Creating a StreamReader for the bufferedStream 
        public void ReadFile()
        {
            lock (fileLock)
            {
                Console.WriteLine("Enter the file path : ");
                _path = Console.ReadLine();
                OpenFile();
            }
        }

        private void OpenFile()
        {
            FileStream fs = File.Open(_path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            BufferedStream bs = new BufferedStream(fs);
            _streamReader = new StreamReader(bs);
        }

        //Printing the content
        public async Task PrintFile()
        {
            OpenFile();
            string line;
            lock (fileLock)
            {
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