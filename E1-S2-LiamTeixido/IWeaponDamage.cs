using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Semana2_Ejercicio1_LiamTeixido
{
    interface IWeaponDamage
    {
        //string Name { get; set; }
        //float Price { get; set; }
        
        float DPS();

        string Getname();

        float Getprice();
    }
}
