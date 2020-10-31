using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class HSFService : AbstractService
    {
        public override void Execute(string parameters)
        {
            Console.WriteLine("HSFService Execute!");
        }
    }
}
