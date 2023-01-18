using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Adapter
{
    internal interface IPayoneerPayment
    {
        Token AuthToken();
        void SendPayment();
        void ReceivePayment();
    }
}
