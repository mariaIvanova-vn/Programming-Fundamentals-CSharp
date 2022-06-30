using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();
            int lastSlashIndex = filePath.LastIndexOf('\\');
            string fileInfo = filePath.Substring(lastSlashIndex + 1);
                 //name.exe
            int dotIndex = fileInfo.LastIndexOf('.');
            string fileName = fileInfo.Substring(0, dotIndex);
            string fileExtension = fileInfo.Substring(dotIndex + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
