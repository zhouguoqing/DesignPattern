using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class SGServiceGroup : AbstractServiceGroup
    {
        public override void Executes(string parameters)
        {
            Console.WriteLine("SGServiceGroup");
        }
    }
}
