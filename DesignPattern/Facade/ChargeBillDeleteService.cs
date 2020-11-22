using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    class ChargeBillDeleteService: IChargeBillDeleteService
    {
        /// <summary>
        /// 删除充电订单及明细
        /// </summary>
        /// <param name="chargeBillIds">充电订单ID集合</param>
        public void DeleteChargeBill(params string[] chargeBillIds)
        { }
    }
}
