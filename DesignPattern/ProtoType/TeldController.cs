using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ProtoType
{
    class TeldController : ICloneable
    {
        public string Code { get; set; }

        public string Address { get; set; }

        public List<Builder.ChargingPile> Piles { get; set; }

        public object Clone()
        {
            var newObj = this.MemberwiseClone() as TeldController;
            newObj.Code = this.Code;
            newObj.Address = this.Address;

            if (this.Piles != null && this.Piles.Count > 0)
            {
                newObj.Piles = new List<Builder.ChargingPile>();
                foreach (var pile in this.Piles)
                {
                    newObj.Piles.Add(pile.Clone() as Builder.ChargingPile);
                }
            }

            return newObj;
        }
    }
}
