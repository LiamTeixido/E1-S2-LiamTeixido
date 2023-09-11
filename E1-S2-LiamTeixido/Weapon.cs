using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_Ejercicio1_LiamTeixido
{
    public abstract class Weapon : IWeaponDamage
    {

        public string name;
        public float damage;
        public float velocityAttack;
        public float price;


        public Weapon(string name, float damage, float velocityAttack, float price) 
        {
            this.name = name;
            this.damage = damage;
            this.price = price;
            this.velocityAttack = velocityAttack;

        }
        public abstract float DPS();

        public string Getname()
        {
            return name;
        }

        public float Getprice()
        {
            return price;
        }
    }
}
