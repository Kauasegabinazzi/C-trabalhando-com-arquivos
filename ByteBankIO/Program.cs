using ByteBankIO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var fileAdress = "contas.txt";

        using(var flowFile = new FileStream(fileAdress,FileMode.Open))
        {
            var reader = new StreamReader(flowFile);

            //var line = reader.ReadLine();

            //var text = reader.ReadToEnd();

            //int number = reader.Read();

            while (!reader.EndOfStream) 
            {
                var line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }

        Console.ReadLine();
    }
}