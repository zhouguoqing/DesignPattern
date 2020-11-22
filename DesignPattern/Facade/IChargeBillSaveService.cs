using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    interface IChargeBillSaveService
    {
        /// <summary>
        /// 保存充电订单
        /// </summary>
        /// <param name="chargeBill">充电订单</param>        
        void SaveChargeBill(ChargeBillsEntity chargeBill);

        /// <summary>
        /// 添加充电订单明细
        /// </summary>
        /// <param name="detail">充电订单明细</param>        
        void SaveChargeBillDetail(ChargeBillDetailEntity detail);
    }
}
