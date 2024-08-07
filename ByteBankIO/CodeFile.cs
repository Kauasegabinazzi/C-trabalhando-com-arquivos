﻿using ByteBankIO;
using System.Text;

//Quando compilarmos e executarmos a aplicação, o programa entenderá que a classe Program está em vários arquivos e pode ser trabalhada de uma forma única.
//Ela está separada apenas por questões de organização.

partial class Program
{
    static void dealingFileStream(string[] args)
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
                Console.WriteLine($"Bytes lidos: {byteNumber}");
                writeBuffer(buffer, byteNumber);
            }

            flowFile.Close();
            Console.ReadLine();
        }
    }

    private static object CurrentAccount(int v1, int v2)
    {
        throw new NotImplementedException();
    }

    static void writeBuffer(byte[] buffer, int readBytes)
    {
        var utf8 = new UTF8Encoding();

        var text = utf8.GetString(buffer, 0, readBytes);
        Console.Write(text);

        //foreach (var item in buffer) 
        //{
        //    Console.Write(item);
        //    Console.Write(" ");
        //}
    }
}