using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"G:\Erick\Erick\Meus Arquivos\Cursos\C#\MVA-Csharp\HandlingExceptions\Example.txt");
                Console.WriteLine(content);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the file is named correctly: Example.txt");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(@"Make sure the directory G:\Erick\Erick\Meus Arquivos\Cursos\C#\MVA-Csharp\HandlingExceptions\Example.txt exists");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Closing aplication now...");
            }
            Console.ReadLine();
        }
    }
}
