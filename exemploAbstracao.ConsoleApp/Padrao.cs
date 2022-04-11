using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploAbstracao.ConsoleApp
{
    abstract class Padrao //quando vc cria uma classe abstrata
                          //vc cria um padrao para seus objetos
    {
        //Obrigatorio
        public abstract void taxaEmprestimo(double valor);//não se abre chaves pois o calculo vai
                                                          //ficar na pessoa fisica e juridica

        //Opcional
        public void calculoPoupanca(double valor, double taxa) //abstract o torna obrigatorio de usar e caso não tenha não é
        {
            Console.WriteLine("Ganhos obtidos pela poupança R$ " + (valor * taxa));
        }
    }
}
