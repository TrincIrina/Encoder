using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encoder encoder = new AsciiCodesEncoder();
            Console.WriteLine($"Код работает - {encoder.Encode("Код работает")}");
            string str = Console.ReadLine();
            Console.WriteLine(encoder.Encode(str));

            Encoder encoder1 = new AtbashCodesEncoder();
            Console.WriteLine($"Hello world - {encoder1.Encode("Hello world")}");
            Console.WriteLine($"{str} - { encoder1.Encode(str)}");
        }
    }
}
