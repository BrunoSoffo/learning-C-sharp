using System;

namespace MeuNamespace // Substitua "MeuNamespace" pelo nome desejado para o seu namespace
{
    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};

    class Program
    {
        static void Main(string[] args)
        {
            int ids = (int)DiasSemana.Sexta; // esse comando atribuirá o indice de Sexta para a var ids

            DiasSemana dss = (DiasSemana)3;
            DiasSemana ds = DiasSemana.Domingo;

            Console.WriteLine(ids);
            Console.WriteLine(dss);
            Console.WriteLine(ds);
        }
    }

}



