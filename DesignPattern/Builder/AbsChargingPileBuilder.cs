using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    abstract class AbsChargingPileBuilder
    {
        public abstract void BuildCode(string code);

        public abstract void BuildPileType(string pileType);

        public abstract void BuildCtrlAddress(string ctrlAddress);

        public abstract ChargingPile GetChargingPile();
    }
}
