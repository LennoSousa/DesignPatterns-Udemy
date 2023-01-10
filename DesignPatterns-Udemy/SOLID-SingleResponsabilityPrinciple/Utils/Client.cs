using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_SingleResponsabilityPrinciple.Utils
{
        internal class Client
        {

            public void CreatClient()
            {

            }

            public void ReadClient()
            {

            }

            public void UpdateClient()
            {

            }

            public void DeleteClient()
            {

            }


            /* O método de notificação do cliente, estando juntos dos demais
             métodos da classe Client, está violando o princípio do SIP. Para corrigirmos 
             isso, vamos criar uma classe de notificações (Notify), que irá receber um cliente 
             como parâmetro e enviará a notificação para o cliente que for solicitado. */

            //static void NotifyClient()
            //{

            //}

        }
}
