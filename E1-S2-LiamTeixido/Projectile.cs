using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_Ejercicio1_LiamTeixido
{
    class Projectile : IProjectileDamage
    {
        private float damageProjectile;

        public Projectile(float damageProjectile)
        {
            this.damageProjectile = damageProjectile;

        }
        public virtual float DamageAditional()
        {
            return damageProjectile;
        }
    }
}
