using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    class HSFServiceFactory : IServiceFactory
    {
        public AbstractService CreateService()
        {
            return new HSFService();
        }
    }
}
