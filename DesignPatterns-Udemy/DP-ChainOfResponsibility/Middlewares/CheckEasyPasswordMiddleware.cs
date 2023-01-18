using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_ChainOfResponsibility.Middlewares
{
    internal class CheckEasyPasswordMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (password.Equals("123456"))
            {
                Console.WriteLine("Atenção! Por segurança, sugerimos que altere sua senha por uma mais segura..");
                //return true;
            }

            //return true;
            return CheckNext(email, password);
        }
    }
}
