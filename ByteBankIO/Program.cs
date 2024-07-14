using ByteBankIO;
using System.Net.Security;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {

        //var newAdress = "testWriters.csv";

        //using (var fileFlow = new FileStream(newAdress, FileMode.Create))
        //using (var writer = new StreamWriter(fileFlow))
        //{
        //    writer.WriteLine(true);
        //    writer.WriteLine(false);
        //    writer.WriteLine(454562342);
        //}

        //writerBinary();
        //readerBinary();

        //useStream();

        var lines = File.ReadAllLines("contas.txt");
        Console.WriteLine(lines.Length);

        //foreach (var line in lines) {
        //    Console.WriteLine(line);
        //}

        var bytesFile = File.ReadAllBytes("contas.txt");

        Console.WriteLine($"File conta.txt possui {bytesFile.Length} bytes");

        File.WriteAllText("writeWithClassFile.txt", "Testing file.writealltext");
        Console.WriteLine("finalizada");
        Console.ReadLine();

        #region first
        //var fileAdress = "contas.txt";

        //using (var flowFile = new FileStream(fileAdress, FileMode.Open))
        //{
        //    var reader = new StreamReader(flowFile);

        //    //var line = reader.ReadLine();

        //    //var text = reader.ReadToEnd();

        //    //int number = reader.Read();

        //    while (!reader.EndOfStream)
        //    {
        //        var line = reader.ReadLine();
        //        var Count = ConvertStringToContaCorrente(line);
        //        var msg = $"{Count.Titular.Nome} : Count number {Count.Numero}, ag{Count.Agencia}, balance {Count.Saldo}";
        //        Console.WriteLine(msg);
        //    }
        //}

        //using (var fluxoDeArquivo = new FileStream(fileAdress, FileMode.Open))
        //using (var leitor = new StreamReader(fluxoDeArquivo))
        //{

        //}

        //Usamos o ReadLine para a leitura de uma linha do arquivo e a propriedade EndOfStream para verificar se chegamos ao fim do stream:

        //using (var fluxoDeArquivo = new FileStream(fileAdress, FileMode.Open))
        //using (var leitor = new StreamReader(fluxoDeArquivo))
        //{
        //    while (!leitor.EndOfStream)
        //    {
        //        var linha = leitor.ReadLine();
        //        Console.WriteLine(linha);
        //    }
        //}


        Console.ReadLine();

        static ContaCorrente ConvertStringToContaCorrente(string linha)
        {
            var fields = linha.Split(',');

            var agency = fields[0];
            var number = fields[1];
            var balance = fields[2].Replace('.', ',');
            var name = fields[3];

            var agencyInt = int.Parse(agency);
            var numberInt = int.Parse(number);
            var balanceDouble = double.Parse(balance);

            var holder = new Cliente();
            holder.Nome = name;

            var result = new ContaCorrente(agencyInt, numberInt);
            result.Depositar(balanceDouble);
            result.Titular = holder;

            return result;
        }

        #endregion
    }

}