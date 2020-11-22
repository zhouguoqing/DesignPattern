using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    class ChargeBillSaveService: IChargeBillSaveService
    {
        /// <summary>
        /// 保存充电订单
        /// </summary>
        /// <param name="chargeBill">充电订单</param>        
        public void SaveChargeBill(ChargeBillsEntity chargeBill)
        { }

        /// <summary>
        /// 添加充电订单明细
        /// </summary>
        /// <param name="detail">充电订单明细</param>        
        public void SaveChargeBillDetail(ChargeBillDetailEntity detail)
        { }
    }
}
