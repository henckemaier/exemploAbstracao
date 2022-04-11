using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploAbstracao.ConsoleApp
{
    class PessoaJuridica : Padrao
    {
        //metodo obrigatorio
        public override void taxaEmprestimo(double valor) //sobreescrevendo
        {
            Console.WriteLine("Taxa de emprestimo para Pessoa Juridica R$ " + (valor * 0.2)); //20%
        }
    }
}
