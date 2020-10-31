using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    class ServiceFactorySGImpl : AbstractServiceFactory
    {
        public override AbstractService CreateService()
        {
            return new SGService();
        }



        public override AbstractServiceGroup CreateServiceGroup()
        {
            return new SGServiceGroup();
        }

    }
}
