using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Chips:Food
    {
        private bool isExtraBig;
        private bool isWithDipps;

        public Chips(decimal price, bool isVeg, bool isExtraBig, bool isWithDipps) : base(price, isVeg)
        {
            IsExtraBig = isExtraBig;
            IsWithDipps = isWithDipps;
        }

        public bool IsExtraBig
        {
            get { return isExtraBig; }
            set { isExtraBig = value; }
        }
        public bool IsWithDipps
        {
            get { return isWithDipps; }
            set { isWithDipps = value; }
        }
    }
}
