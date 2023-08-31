using System;

namespace MeuNamespace // Substitua "MeuNamespace" pelo nome desejado para o seu namespace
{
    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};

    class Program
    {
        static void Main(string[] args)
        {
            // Conversão de tipo de dado de forma implicita

            int n1 = 2;
            float n2 = n1;

            Console.WriteLine(n2);

            // Conversão manual

            double num1 = 10.5;
            int num2 = (int)num1;

            Console.WriteLine(num2);


            int valorEnum = (int)DiasSemana.Domingo; // Conversão de enum para int

            Console.WriteLine(valorEnum);
        }
    }
}

