using System;

namespace exemploAbstracao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.taxaEmprestimo(1000);
            pf.calculoPoupanca(1000, 5);

            Console.WriteLine("----------");

            PessoaJuridica pj = new PessoaJuridica();
            pj.taxaEmprestimo(1000);
            //não foi preciso chamar o calculoPoupança pois não era obrigatorio

            Console.ReadLine();
        }
    }
}
