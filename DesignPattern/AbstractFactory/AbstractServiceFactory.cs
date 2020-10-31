using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    abstract class AbstractServiceFactory
    {
        public abstract AbstractService CreateService();

        public abstract AbstractServiceGroup CreateServiceGroup();
    }
}
