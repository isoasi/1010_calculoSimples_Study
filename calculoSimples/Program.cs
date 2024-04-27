using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {
        double total;

        // código de uma peça 1
        // número de peças 1
        // valor unitário de cada peça 1

        string[] peca = Console.ReadLine().Split(' ');

        int codigoPeca1 = int.Parse(peca[0]);
        int quantidadePeca1 = int.Parse(peca[1]);
        double valorPeca1 = double.Parse(peca[2],CultureInfo.InvariantCulture);

        //--------------------------------------------------------------------------------------------
        
        // código de uma peça 2
        // número de peças 2
        // valor unitário de cada peça 2

        string[] pecaDois = Console.ReadLine().Split(' ');

        int codigoDois = int.Parse(pecaDois[0]);
        int quantidadePecaDois = int.Parse(pecaDois[1]);
        double valorPecaDois = double.Parse(pecaDois[2], CultureInfo.InvariantCulture);


        total = (valorPeca1 * quantidadePeca1) + (valorPecaDois * quantidadePecaDois);

        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        Console.Read();

    }

}



