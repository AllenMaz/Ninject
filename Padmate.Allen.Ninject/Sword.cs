using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padmate.Allen.NinjectTest
{
    /// <summary>
    /// 
    /// </summary>
    public class Sword:IWeapon
    {

        public string Hit(string target)
        {
            return "Sword " + target + " to death";
        } 
    }
}
