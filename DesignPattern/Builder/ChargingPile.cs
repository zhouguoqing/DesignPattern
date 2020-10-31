using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    class ChargingPile:ICloneable
    {
        public string Code { get; set; }

        public string CtrlAddress { get; set; }

        public string PileType { get; set; }

        public void Charging()
        {
            Console.WriteLine(string.Format("Code:{0}, CtrlAddress:{1};PileType:{2} ", Code, CtrlAddress, PileType));
        }

        public object Clone()
        {
            var newObj = this.MemberwiseClone() as ChargingPile;

            newObj.Code = this.Code;
            newObj.CtrlAddress = this.CtrlAddress;
            newObj.PileType = this.PileType;

            return newObj;
        }
    }
}
