
using SOLID_DependencyInversionPrinciple.Factory;
using SOLID_DependencyInversionPrinciple.Model;
using System;

namespace SOLID_DependencyInversionPrinciple.Payments
{
    internal class PaymentProcess
    {
        public void Pay(string id)
        {
            /* 1- A classe payments, um módulo de alto nível, nesse exemplo, acaba tendo a 
             * dependência, de um módulo de baixo nível. que é a busca do produto no banco SQL Server.*/
            //SQLServerProduct product = new SQLServerProduct();

            //2
            DbProduct product = DbProductFactory.Create();
            string productData = product.GetProductById(id);

            Console.WriteLine(productData);

            /* 2- Para aplicarmos corretamente o DIP, os objetos de alto nível, devem depender de abstrações.
             Cenário em que vamos precisar aplicar o DIP.
             - Necessidade de mudar a base de dados de SQL Server para MySQL. Com isso, todos os módulos
            de alto nível que fazem chamadas para a base de dados através da classe de acesso SQL Server,
            estarão com uma grande dependência de uma classe de baixo nível.*/


        }
    }
}
