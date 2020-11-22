using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    class ChargeBillServiceFactory
    {
		public static IChargeBillDeleteService GetDeleteService() 
		{
			return new ChargeBillDeleteService();
		}

		public static IChargeBillUpdateService GetUpdateService()
		{
			return new ChargeBillUpdateService();
		}

		public static IChargeBillSaveService GetSaveService()
		{
			return new ChargeBillSaveService();
		}

		public static IChargeBillQueryService QueryService() 
		{
			return new ChargeBillQueryService();
		}

		public static T GetService<T>(string type) where T : class
		{
			var instance = Activator.CreateInstance(Type.GetType(type));

			return (T)instance;
		}
	}
}
