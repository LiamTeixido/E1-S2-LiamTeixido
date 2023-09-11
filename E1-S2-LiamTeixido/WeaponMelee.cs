using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_Ejercicio1_LiamTeixido
{
    class WeaponMelee : Weapon
    {


        public WeaponMelee(string name, float damage, float velocityAttack, float price): base(name, damage, velocityAttack, price)
        {

        }

        public override float DPS()
        {
            return damage * velocityAttack;
        }
    }
}
