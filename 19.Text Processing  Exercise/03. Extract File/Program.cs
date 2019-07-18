using System;
using System.Text;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string filesPath = Console.ReadLine();
            string[] lastInfo = filesPath.Split("\\");
            string lastInfos = lastInfo[lastInfo.Length - 1];
            string[] filesInfo = lastInfos.Split(".");
            string fileName = filesInfo[0];
            string fileExtension = filesInfo[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }


    }
    }


