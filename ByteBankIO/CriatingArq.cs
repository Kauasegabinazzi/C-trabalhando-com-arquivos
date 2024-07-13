using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    static void create()
    {
        var newAdress = "exportedAccounts.csv";

        using (var fileFlow = new FileStream(newAdress, FileMode.Create))
        {
            var countToString = "2324, 2323, 777,76, Mateus Santos";

            var encoding = Encoding.UTF8;

            var bytes = Encoding.UTF8.GetBytes(countToString);

            fileFlow.Write(bytes, 0, bytes.Length);
        }
    }
    static void createFileWithWriter()
    {
        var newAdress = "exportedAccounts.csv";

        using (var fileFlow = new FileStream(newAdress, FileMode.Create))
        using (var writer = new StreamWriter(fileFlow))
        {
            writer.Write("231,21321,3213.4, Joao");
        }

    }
}

