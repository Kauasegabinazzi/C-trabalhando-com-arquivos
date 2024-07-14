using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    static void useStream()
    {
        using (var entryFlow = Console.OpenStandardInput())
        using (var fs = new FileStream("consoleEnter.txt", FileMode.Create))
        {
            var buffer = new byte[1024];

            while (true)
            {
                var bytesReaders = entryFlow.Read(buffer, 0, 1024);

                fs.Write(buffer, 0, bytesReaders);
                fs.Flush();
                Console.WriteLine($"Bytes lidos: {bytesReaders}");
            }

        }
    }
}