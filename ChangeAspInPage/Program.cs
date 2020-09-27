using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeAspInPage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter path");
            string path= Console.ReadLine();
            string fileContent;

            foreach (var item in  Directory.GetFiles(path,"*.html"))
            {
                
               fileContent= File.ReadAllText(item,Encoding.UTF8);

                fileContent= fileContent.Replace("asp", "html");

                File.WriteAllText(item, fileContent);

            }
        }
    }
}
