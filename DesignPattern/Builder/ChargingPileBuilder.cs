using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    class ChargingPileBuilder : AbsChargingPileBuilder
    {
        private ChargingPile pile = null;

        public ChargingPileBuilder()
        {
            pile = new ChargingPile();
        }
        public override void BuildCode(string code)
        {
            pile.Code = code;
        }

        public override void BuildCtrlAddress(string ctrlAddress)
        {
            pile.CtrlAddress = ctrlAddress;
        }

        public override void BuildPileType(string pileType)
        {
            pile.PileType = pileType;
        }

        public override ChargingPile GetChargingPile()
        {
            return pile;
        }
    }
}
