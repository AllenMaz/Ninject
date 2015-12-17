using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padmate.Allen.NinjectTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninject.IKernel kernel = new StandardKernel(new NinjectModule());

            #region 构造函数注入
            //var samurai = kernel.Get<Samurai>();
            //samurai.Attack("your enemy");

            #endregion
            #region 属性注入
            //Samurai samurai = new Samurai();
            //samurai.AllWeapons = kernel.GetAll<IWeapon>().ToArray();
            //samurai.Attack("your enemy");

            #endregion
            #region 方法注入
            //Samurai samurai = new Samurai();
            //samurai.Arm(kernel.GetAll<IWeapon>().ToArray());
            //samurai.Attack("your enemy");

            #endregion

            #region
            IEnumerable<IWeapon> weapons = kernel.GetAll<IWeapon>();
            
            //Note that if you remove the foreach below,
            //the objects will never get constructed – 
            //the individual results from GetAll() are generated as you iterate over it
            foreach (var weapon in weapons)
                Console.WriteLine(weapon.Hit("the evildoers"));
            #endregion

            //IWeapon weapon = new Sword();
            //var warrior = new Samurai(weapon);
            //warrior.Attack("the evildoers");
            while(true)
            {
                Console.ReadLine();
            }
        }
    }
}
