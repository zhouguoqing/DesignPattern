using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        public int name { get; } = 1;

        public Program()
        {
            name = 1;
        }
        
        static void Main(string[] args)
        {
            
            List<int> a = new List<int> { 1, 3, 3 };
            
            Console.WriteLine("简单工厂模式！");
            var service = SimpleFactory.ServiceFactory.CreateService("HSF");
            service.Execute("abc");

            service = SimpleFactory.ServiceFactory.CreateService("SG");
            service.Execute("abc");

            Console.WriteLine("是否继续？");
            Console.ReadKey();

            Console.WriteLine("工厂方法模式！");
            var hsfServiceFactory = new FactoryMethod.HSFServiceFactory();
            service = hsfServiceFactory.CreateService();
            service.Execute("abc");

            var sgServiceFactory = new FactoryMethod.SGServiceFactory();
            service = hsfServiceFactory.CreateService();
            service.Execute("abc");

            Console.WriteLine("是否继续？");
            Console.ReadKey();

            Console.WriteLine("抽象工厂模式！");
            var sgFactory = new AbstractFactory.ServiceFactorySGImpl();
            service = sgFactory.CreateService();
            var serviceGroyp = sgFactory.CreateServiceGroup();
            service.Execute("abc");
            serviceGroyp.Executes("abc");

            var hsfFactory = new AbstractFactory.ServiceFactoryHSFImpl();
            service = hsfFactory.CreateService();
            serviceGroyp = hsfFactory.CreateServiceGroup();
            service.Execute("abc");
            serviceGroyp.Executes("abc");

            Console.WriteLine("是否继续？");
            Console.ReadKey();

            Console.WriteLine("构造器模式！将对象的构造过程和它的表示行为分离，抽象对象的构造过程");
            var builder = new Builder.ChargingPileBuilder();
            var manager = new Builder.ChargingPileManager(builder);
            var pile = manager.GetChargingPile("001", "qd", "直流");
            pile.Charging();

            Console.WriteLine("是否继续？");
            Console.ReadKey();
        }
    }
}
