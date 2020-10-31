using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    /// <summary>
    /// 管理类
    /// </summary>    
    class ChargingPileManager
    {
        AbsChargingPileBuilder builder = null;

        public ChargingPileManager(AbsChargingPileBuilder builder)
        {
            this.builder = builder;
        }

        public ChargingPile GetChargingPile(string code, string ctlAddr, string pileType)
        {
            builder.BuildCode(code);
            builder.BuildCtrlAddress(ctlAddr);
            builder.BuildPileType(pileType);

            return builder.GetChargingPile();
        }
    }
}
