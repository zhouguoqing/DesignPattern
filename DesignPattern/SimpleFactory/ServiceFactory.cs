using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactory
{
    class ServiceFactory
    {
        public static AbstractService CreateService(string serviceType)
        {
            AbstractService service = null;
            switch (serviceType)
            {
                case "HSF":
                    service = new HSFService();
                    break;
                case "SG":
                    service = new SGService();
                    break;
                default:
                    break; 
            }

            return service;
        }
    }
}
