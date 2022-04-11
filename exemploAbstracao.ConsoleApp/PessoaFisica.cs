using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploAbstracao.ConsoleApp
{
    class PessoaFisica : Padrao
    {
        //metodo obrigatorio
        public override void taxaEmprestimo(double valor) //sobreescrevendo
        {
            Console.WriteLine("Taxa de emprestimo para Pessoa Fisica R$ " + (valor * 0.1)); //10%
        }

        public void calculoPoupanca(double valor, double taxa)
        {
            Console.WriteLine("Ganhos obtidos pela poupança R$ " + (valor * taxa));
        }
    }
}
