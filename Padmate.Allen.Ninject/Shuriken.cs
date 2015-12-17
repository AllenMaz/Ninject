using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padmate.Allen.NinjectTest
{
    public class Shuriken:IWeapon
    {
        public string Hit(string target)
        {
            return "Shuriken " + target + " to death";
        }
    }
}
