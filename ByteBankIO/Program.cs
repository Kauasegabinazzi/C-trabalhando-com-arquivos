using ByteBankIO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var fileAdress = "contas.txt";

        //using(var flowFile = new FileStream(fileAdress,FileMode.Open))
        //{
        //    var reader = new StreamReader(flowFile);

        //    //var line = reader.ReadLine();

        //    //var text = reader.ReadToEnd();

        //    //int number = reader.Read();

        //    while (!reader.EndOfStream) 
        //    {
        //        var line = reader.ReadLine();
        //        Console.WriteLine(line);
        //    }
        //}

        using (var fluxoDeArquivo = new FileStream(fileAdress, FileMode.Open))
        using (var leitor = new StreamReader(fluxoDeArquivo))
        {

        }

        //Usamos o ReadLine para a leitura de uma linha do arquivo e a propriedade EndOfStream para verificar se chegamos ao fim do stream:

        using (var fluxoDeArquivo = new FileStream(fileAdress, FileMode.Open))
        using (var leitor = new StreamReader(fluxoDeArquivo))
        {
            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                Console.WriteLine(linha);
            }
        }


                Console.ReadLine();
    }
}