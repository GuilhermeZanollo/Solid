using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._02_OCP.Bad
{
    public enum EProductType
    {
        Eletronics = 1,
        Health = 2,
        Beauty = 3,
        Fashion = 4
    }
    public class Discount
    {
        public decimal Calculate(EProductType type, decimal price) // O método vai ser usado O EProductType e o decimal price
        {
            if (type == EProductType.Eletronics)
                return price * 0.2M;

            else if (type == EProductType.Health)
                return price * 0.9M;

            else if (type == EProductType.Beauty)
                return price * 0.85M;

            else if (type == EProductType.Fashion)
                return price * 0.2M;

            return price;

        }
    }
}
