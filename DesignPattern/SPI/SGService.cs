using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class SGService : AbstractService
    {
        public override void Execute(string parameters)
        {
            Console.WriteLine("SG Service Execute!");
        }
    }
}
