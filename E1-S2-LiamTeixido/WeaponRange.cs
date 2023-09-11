using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_Ejercicio1_LiamTeixido
{
     class WeaponRange : Weapon
    {
        public IProjectileDamage projectileDamageP { get; set; }


        public WeaponRange(string name, float damage, float velocityAttack, float price, IProjectileDamage projectileDamage) : base(name, damage, velocityAttack, price)
        {
            projectileDamageP = projectileDamage;
        }

        public override float DPS()
        {
            return (damage + projectileDamageP.DamageAditional()) * velocityAttack;
        }
    }
}
