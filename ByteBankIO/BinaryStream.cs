using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    static void writerBinary()
    {
        using (var fileFlow = new FileStream("fileBinary.txt", FileMode.Create))
        using (var writer = new BinaryWriter(fileFlow))
        {
            writer.Write(432);
            writer.Write(4323);
            writer.Write(43434.6);
            writer.Write("Joao");
        }

    }

    static void readerBinary() {
        using (var fileFlow = new FileStream("fileBinary.txt", FileMode.Open))
        using (var writer = new BinaryReader(fileFlow))
        {
            var agency = writer.ReadInt32();
            var number = writer.ReadInt32();
            var balance = writer.ReadDouble();
            var holder = writer.ReadString();

            Console.WriteLine($"{agency}/{number}/{balance}/{holder}");
        }
    }
}
