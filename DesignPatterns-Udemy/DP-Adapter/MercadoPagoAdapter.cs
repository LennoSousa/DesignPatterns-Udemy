using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Adapter
{
    internal class MercadoPagoAdapter : IPayPalPayment
    {
        private MercadoPago mercadoPago;

        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            this.mercadoPago = mercadoPago;
            Console.WriteLine("Realizando adaptação de Mercado Pago para os métodos do PayPal.");
        }

        public Token AuthToken()
        {
            return this.mercadoPago.AuthToken();
        }

        public void PayPalPayment()
        {
            this.mercadoPago.EnviaPagamento();
        }

        public void PayPalReceive()
        {
            this.mercadoPago.RecebePaamento();
        }
    }
}
