using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padmate.Allen.NinjectTest
{
    public class NinjectModule : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IWeapon>().To<Sword>();
            Bind<IWeapon>().To<Shuriken>();
        }
    }

}
