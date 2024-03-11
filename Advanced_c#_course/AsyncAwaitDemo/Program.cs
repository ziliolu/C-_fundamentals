/* using System;
using System.IO;
using System.Threading.Tasks; 

namespace AsyncAwaitDemo
{
    public class Program
    {
        static async void Main(string[] args)
        {
            Task<string> downloadTask = DownloadFileAsync("https://www.example.com/file.txt");
            System.Console.WriteLine("Performing other tasks while waiting");
            string content = await downloadTask;

            System.Console.WriteLine("Download completed!");
            System.Console.WriteLine(content);
        }
    }
} */
