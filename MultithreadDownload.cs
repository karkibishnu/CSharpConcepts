using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public static class MultithreadDownload
    {
        public static void DownloadFiles()
        {
            Console.WriteLine("Downloading files...");

            //start downloading files asynchronously using multiple threads
            Thread thread1 = new Thread(() => DownloadFile("File1"));
            Thread thread2 = new Thread(() => DownloadFile("File2"));

            //start the threads
            thread1.Start();
            thread2.Start();

            //wait for both threads to complete
            thread1.Join();
            thread2.Join();

            Console.WriteLine("All files downloaded successfully");
        }

        static void DownloadFile(string fileName)
        {
            Console.WriteLine($"Downloading {fileName}");
            //simulate downloading by sleeping for a random amount of time
            Thread.Sleep(TimeSpan.FromSeconds(new Random().Next(3,10)));
            Console.WriteLine($"{fileName} downloaded");
        }
    }
}
