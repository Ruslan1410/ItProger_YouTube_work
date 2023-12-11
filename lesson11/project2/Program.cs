using System;
using System.IO;

namespace project
{

    class Program
    {

        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            using (FileStream stream = new FileStream("into.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);

                stream.Write(array, 0, array.Length);
            }
        }
    }
}