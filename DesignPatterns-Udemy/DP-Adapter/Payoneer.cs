using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Adapter
{
    internal class Payoneer : IPayoneerPayment
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePayment()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com Payoneer.");
        }

        public void SendPayment()
        {
            Console.WriteLine("Enviando pagamento com Payoneer");
        }
    }
}
