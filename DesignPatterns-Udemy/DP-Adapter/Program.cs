using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PayPal payment = new PayPal();
            //payment.PayPalPayment();
            //payment.PayPalReceive();

            //Payoneer payment = new Payoneer();
            //payment.SendPayment();
            //payment.ReceivePayment();

            //IPayPalPayment payment = new PayoneerAdapter(new Payoneer());
            IPayPalPayment payment = new MercadoPagoAdapter(new MercadoPago());

            payment.PayPalPayment();
            payment.PayPalReceive();

            Console.ReadLine();
        }
    }
}
