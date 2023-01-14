using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DependencyInversionPrinciple.Model
{
    internal class MongoDBProduct : DbProduct
    {
        public string GetProductById(string id)
        {
            return $"MongoDB: Exibindo dados do produto {id}.";
        }
    }
}
