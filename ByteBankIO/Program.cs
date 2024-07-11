using ByteBankIO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var addressFile = "contas.txt";

        //using verifica se o fluxo não é nulo

        using (var flowFile = new FileStream(addressFile, FileMode.Open))
        {
            var byteNumber = -1;


            var buffer = new byte[1024]; // 1Kb;

            byteNumber = flowFile.Read(buffer, 0, 1024);

            while (byteNumber != 0)
            {
                byteNumber = flowFile.Read(buffer, 0, 1024);
                writeBuffer(buffer);
            }

            flowFile.Close();
            Console.ReadLine();
        }
    }

    private static object CurrentAccount(int v1, int v2)
    {
        throw new NotImplementedException();
    }

    static void writeBuffer(byte[] buffer)
    {
        var utf8 = new UTF8Encoding();

        var text = utf8.GetString(buffer);
        Console.Write(text);

        //foreach (var item in buffer) 
        //{
        //    Console.Write(item);
        //    Console.Write(" ");
        //}
    }
}