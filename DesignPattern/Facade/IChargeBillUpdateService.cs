using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    interface IChargeBillUpdateService
    {
        /// <summary>
        /// 充电订单通用更新
        /// </summary>
        /// <param name="chargeBillId">充电订单ID</param>
        /// <param name="properties">变更的属性</param>        
        /// <returns>影响行数</returns>
        int UpdateChargeBill(string chargeBillId, Dictionary<string, string> properties);
    }
}
