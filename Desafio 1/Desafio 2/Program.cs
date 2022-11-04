using System;
using System.IO;
using System.Linq;

class Desafio{

    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());
        string[] valor = new string[2];
        // TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int i = 0; i < qt; i++)
        {
            valor = Console.ReadLine().Split(' ');
            string a = valor[0];
            string b = valor[1];

            if (b.Length > a.Length)
            {
                Console.WriteLine("nao encaixa");
            }
            else if (a.EndsWith(b))
            {
                Console.WriteLine("encaixa");
            }
            else
            {
                Console.WriteLine("nao encaixa");
            }
        }

    }

}