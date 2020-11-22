using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    class ChargeBillQueryService: IChargeBillQueryService
    {
        /// <summary>
        /// 获取充电订单
        /// </summary>
        /// <param name="chargeBillId">充电订单ID</param>
        /// <returns>充电订单</returns>
        /// <example>HSFService.Proxy&lt;IChargeBillQueryService&gt;().GetChargeBill(chargeBillId)</example>
        public ChargeBillsEntity GetChargeBill(string chargeBillId)
        {
            return new ChargeBillsEntity();
        }

        /// <summary>
        /// 获取充电订单明细
        /// </summary>
        /// <param name="chargeBillId">充电订单ID</param>
        /// <returns>充电订单明细</returns>
        /// <example>HSFService.Proxy&lt;IChargeBillQueryService&gt;().GetChargeBillDetail(chargeBillId)</example>
        public List<ChargeBillDetailEntity> GetChargeBillDetail(string chargeBillId)
        {
            return new List<ChargeBillDetailEntity>();
        }

        /// <summary>
        /// 根据集控和终端编号获取充电订单
        /// </summary>
        /// <param name="ctrlAddr">集控地址</param>
        /// <param name="pileCanSN">终端编号</param>
        /// <returns>充电订单</returns>
        /// <example>HSFService.Proxy&lt;IChargeBillQueryService&gt;().GetChargeBillByCtrlCanAddr(ctrlAddr,pileCanSN)</example>
        public List<ChargeBillsEntity> GetChargeBillByCtrlCanAddr(string ctrlAddr, string pileCanSN)
        {
            return new List<ChargeBillsEntity>();
        }
    }
}
