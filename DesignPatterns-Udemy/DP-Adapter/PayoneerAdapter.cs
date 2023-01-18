using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Adapter
{
    internal class PayoneerAdapter : IPayPalPayment
    {
        private Payoneer payoneer;

        public PayoneerAdapter(Payoneer payoneer)
        {
            this.payoneer = payoneer;
            Console.WriteLine("Realizando adaptação de Payoneer para os métodos do PayPal.");
        }

        public Token AuthToken()
        {
            return this.payoneer.AuthToken();
        }

        public void PayPalPayment()
        {
            this.payoneer.SendPayment();
        }

        public void PayPalReceive()
        {
            this.payoneer.ReceivePayment();
        }
    }
}
