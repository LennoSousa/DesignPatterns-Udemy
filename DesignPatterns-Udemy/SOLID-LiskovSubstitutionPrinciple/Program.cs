using SOLID_LiskovSubstitutionPrinciple.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LiskovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CreditCard card = new CreditCard();
            
            //DebitCard card = new DebitCard();
            
            //Aqui entra o exemplo do LSP, ao criarmos uma nova classe de pagamento, podemos
            //continuar realizando as operações base da classe pai, que foram extendidas para
            //essa nova classe filha, sem quebrar a implementação já existente.
            
            /* Sempre que possíivel, pensar se podemos utilizar o LSP em algum momento da criação
               ou manutenção de uma aplicação. */
            
            NubankRewards card = new NubankRewards();

            card.Validate();
            card.CollectPayment();

            Console.ReadLine();
        }
    }
}
