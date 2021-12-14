using _5_Aula01Parte02.Funcionarios;
using _5_Aula01Parte02;
using System;
using Humanizer;

namespace _5_Aula01Parte02
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2021, 12, 15);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);
            Console.WriteLine(mensagem);
        }
    }
}
