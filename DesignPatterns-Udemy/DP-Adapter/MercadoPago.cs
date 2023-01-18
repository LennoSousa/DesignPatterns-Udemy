using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Adapter
{
    internal class MercadoPago : IMercadoPagoPayment
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void EnviaPagamento()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com Mercado Pago.");
        }

        public void RecebePaamento()
        {
            Console.WriteLine("Recebendo pagamento com Mercado Pago.");
        }
    }
}
