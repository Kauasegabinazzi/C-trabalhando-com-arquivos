﻿using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var addressFile = "contas.txt";
        var byteNumber = -1;
        var flowFile = new FileStream(addressFile, FileMode.Open);

        var buffer = new byte[1024]; // 1Kb;

        byteNumber = flowFile.Read(buffer, 0, 1024);

        while (byteNumber != 0) {
            byteNumber = flowFile.Read(buffer, 0, 1024);
            writeBuffer(buffer);
        }

        Console.ReadLine();

    }

    private static object CurrentAccount(int v1, int v2)
    {
        throw new NotImplementedException();
    }

    static void writeBuffer(byte[] buffer)
    {
        foreach (var item in buffer) 
        {
            Console.Write(item);
            Console.Write(" ");
        }
    }
}