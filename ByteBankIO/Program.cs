using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var addressFile = "contas.txt";
        var flowFile = new FileStream(addressFile, FileMode.Open);

        var buffer = new byte[1024];

        flowFile.Read(buffer, 0, 1024);

        Console.ReadLine();
    }

    private static object CurrentAccount(int v1, int v2)
    {
        throw new NotImplementedException();
    }
}