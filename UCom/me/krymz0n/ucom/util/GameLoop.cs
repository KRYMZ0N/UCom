using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCom.me.krymz0n.ucom.util {
    internal class GameLoop
    {
        public int i = 1;

        public bool isOn()
        {
            if (i == 1)
            {
                return true;
            }
            return false;
        }
    }
}
