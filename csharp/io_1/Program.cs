using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";

            // Copy
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg");

            // Delete
            File.Delete(path);

            // Exists
            if (File.Exists(path))
            {

            }
            var content = File.ReadAllText(path);


            var fileInfo = new FileInfo(path);

            // Copy
            fileInfo.CopyTo("...");

            // Delete
            fileInfo.Delete();

            // Exists
            if (fileInfo.Exists)
            {
                Console.WriteLine("sample1");
            }
            else
            {
                Console.WriteLine("sample2");
            }
             
        }
    }
}
