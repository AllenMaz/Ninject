using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padmate.Allen.NinjectTest
{
    public class Samurai
    {

        #region 构造函数注入
        //readonly IWeapon[] allWeapons;
        //public Samurai(IWeapon[] allWeapons)
        //{
        //    this.allWeapons = allWeapons;
        //}
        #endregion
        #region 属性注入
        //private IWeapon[] allWeapons;

        //public IWeapon[] AllWeapons
        //{
        //    get { return allWeapons; }
        //    set { allWeapons = value; }
        //}

        #endregion
        #region 方法注入
        private IWeapon[] allWeapons;

        public void Arm(IWeapon[] allWeapons)
        {
            this.allWeapons = allWeapons;
        }
        #endregion

        public void Attack(string target)
        {
            foreach (IWeapon weapon in this.allWeapons)
                Console.WriteLine(weapon.Hit(target));
        }

    }
}
