using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    public class ChargeBillFacadeService
    {
        /// <summary>
        /// 获取充电订单
        /// </summary>
        /// <param name="chargeBillId">充电订单ID</param>
        /// <returns>充电订单</returns>
        public ChargeBillsEntity GetChargeBill(string chargeBillId)
        {
            var typeInfo = ConfigurationManager.AppSettings["ChargeBillQueryServiceType"];
            var queryService = ChargeBillServiceFactory.GetService<IChargeBillQueryService>(typeInfo);

            return queryService.GetChargeBill(chargeBillId);
        }

        /// <summary>
        /// 保存充电订单
        /// </summary>
        /// <param name="chargeBill">充电订单</param>     
        public void SaveChargeBill(ChargeBillsEntity chargeBill, List<ChargeBillDetailEntity> details)
        {
            var typeInfo = ConfigurationManager.AppSettings["ChargeBillSaveServiceType"];
            var saveService = ChargeBillServiceFactory.GetService<IChargeBillSaveService>(typeInfo);

            saveService.SaveChargeBill(chargeBill);
            details.ForEach(i => saveService.SaveChargeBillDetail(i));
        }
    }
}
