using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter path of the folder");
            string path= Console.ReadLine();
            var files = Directory.GetFiles(path,"*.asp");
            foreach (var item in files)
            {
               
                File.Move(item, Path.ChangeExtension(item, ".html"));
               

            }
            
            Console.WriteLine("changed successfully");
        }
    }
}
