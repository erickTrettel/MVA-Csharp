using System;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "We want to write this for our file";
            //File.WriteAllText("G:/Erick/Erick/Meus Arquivos/Cursos/C#/MVA-Csharp/AssembliesAndNamespaces/Lesson17/WriteText.txt", text);

            WebClient client = new WebClient();

            string reply = client.DownloadString("https://msdn.microsoft.com");

            Console.WriteLine(reply);
            File.WriteAllText("G:/Erick/Erick/Meus Arquivos/Cursos/C#/MVA-Csharp/AssembliesAndNamespaces/Lesson17/WriteText.txt", reply);

            //Console.WriteLine("Hello World");
            Console.ReadLine();
        }
    }
}
