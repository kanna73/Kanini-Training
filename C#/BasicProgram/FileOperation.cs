using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class FileOperation
    {
      /*  public void CreateFile()
        {
            FileInfo fi = new FileInfo("F:\\Kanini Training\\C#\\" + "Sample.txt");
            using StreamWriter stwr = fi.CreateText();
            Console.WriteLine("File has been created");
            stwr.WriteLine("hello world");  
        }
        public void DeleteFile() 
        {
            FileInfo fi = new FileInfo("F:\\Kanini Training\\C#\\" + "Sample.txt");

            fi.Delete();
        }
        public void CopyMoveFile()
        {
            FileInfo fili = new FileInfo("F:\\Kanini Training\\C#\\" + "Sample.txt");

            fili.CopyTo("F:\\Kanini Training\\C#\\temp2\\Sample.txt");

        }
        public void MoveFile()
        {
            FileInfo file = new FileInfo("F:\\Kanini Training\\C#\\" + "Sample.txt");

            file.MoveTo("F:\\Kanini Training\\C#\\temp2\\Samp.txt");

        }*/
        public void Data()
        {
            // This will create a file named sample.txt
            // at the specified location 
            StreamWriter sw = new StreamWriter("F:\\Kanini Training\\C#\\" + "demo.txt");

            // To write on the console screen
            Console.WriteLine("Enter the Text that you want to write on File");

            // To read the input from the user
            string str = Console.ReadLine();

            // To write a line in buffer
            sw.WriteLine(str);

            // To write in output stream
            sw.Flush();

            // To close the stream
            sw.Close();
        }
    }
}
