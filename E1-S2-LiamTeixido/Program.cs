using Semana2_Ejercicio1_LiamTeixido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1_S2_LiamTeixido
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IWeaponDamage> inventory = new List<IWeaponDamage>();

            while (true)
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Agregar Espada");
                Console.WriteLine("2. Agregar Arco");
                Console.WriteLine("3. Agregar Pistola");
                Console.WriteLine("4. Agregar Flecha");
                Console.WriteLine("5. Agregar Bala");
                Console.WriteLine("6. Mostrar inventario");
                Console.WriteLine("7. Eliminar arma del inventario");
                Console.WriteLine("8. Terminar ");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out int op))
                {
                    switch (op)
                    {
                        case 1:
                            AddSword(inventory);
                            break;
                        case 2:
                            AddBow(inventory);
                            break;
                        case 3:
                            AddGun(inventory);
                            break;
                        case 4:
                            AddBullet(inventory);
                            break;
                        case 5:
                            AddArrow(inventory);
                            break;
                        case 6:
                            ShowInventory(inventory);
                            break;
                        case 7:
                            DeleteWeapon(inventory);
                            break;
                        case 8:
                            return;
                        default:
                            Console.WriteLine("Esta opción no existe. Por favor, intente de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Esta opción no existe. Por favor, intente de nuevo.");
                }
            }
        }
        static void AddSword(List<IWeaponDamage> inventory)
        {
            Console.Write("Nombre de la Espada: ");
            string name = Console.ReadLine();

            Console.Write("Daño de la Espada: ");
            float damage = float.Parse(Console.ReadLine());

            Console.Write("Velocidad de Ataque de la Espada: ");
            float velocityAttack = float.Parse(Console.ReadLine());

            Console.Write("Precio de la Espada: ");
            float price = float.Parse(Console.ReadLine());

            WeaponMelee sword = new WeaponMelee(name, damage, velocityAttack, price);
            inventory.Add((IWeaponDamage)sword);

            Console.WriteLine($"La Espada '{name}' fue agregada al inventario.");
        }

        static void AddBow(List<IWeaponDamage> inventory)
        {
            Console.Write("Nombre del Arco: ");
            string name = Console.ReadLine();

            Console.Write("Daño del Arco: ");
            float damage = float.Parse(Console.ReadLine());

            Console.Write("Velocidad de Ataque del Arco: ");
            float velocityAttack = float.Parse(Console.ReadLine());

            Console.Write("Precio del Arco: ");
            float price = float.Parse(Console.ReadLine());

            Console.Write("Nombre de la Flecha: ");
            string nameProjectile = Console.ReadLine();

            Console.Write("Daño de la Flecha: ");
            float damageProjectile = float.Parse(Console.ReadLine());

            IProjectileDamage arrow = new Projectile(damageProjectile);
            WeaponRange bow = new WeaponRange(name, damage, velocityAttack, price, arrow);
            inventory.Add((IWeaponDamage)bow);

            Console.WriteLine($"El Arco '{name}' con Flecha '{nameProjectile}' fue agregado al inventario.");
        }

        static void AddGun(List<IWeaponDamage> inventory)
        {
            Console.Write("Nombre de la Pistola: ");
            string name = Console.ReadLine();

            Console.Write("Daño de la Pistola: ");
            float damage = float.Parse(Console.ReadLine());

            Console.Write("Velocidad de Ataque de la Pistola: ");
            float velocityAttack = float.Parse(Console.ReadLine());

            Console.Write("Precio de la Pistola: ");
            float price = float.Parse(Console.ReadLine());

            Console.Write("Nombre de la Bala: ");
            string nameProjectile = Console.ReadLine();

            Console.Write("Daño de la Bala: ");
            float damageProjectile = float.Parse(Console.ReadLine());

            IProjectileDamage bullet = new Projectile(damageProjectile);
            WeaponRange gun = new WeaponRange(name, damage, velocityAttack, price, bullet);
            inventory.Add((IWeaponDamage)gun);

            Console.WriteLine($"La Pistola '{name}' con Bala '{nameProjectile}' fue agregada al inventario.");
        }

        static void AddArrow(List<IWeaponDamage> inventory)
        {
            Console.Write("Nombre de la Flecha: ");
            string name = Console.ReadLine();

            Console.Write("Daño de la Flecha: ");
            float damage = float.Parse(Console.ReadLine());

            Console.Write("Velocidad de Ataque de la Flecha: ");
            float velocityAttack = float.Parse(Console.ReadLine());

            Console.Write("Precio de la Flecha: ");
            float price = float.Parse(Console.ReadLine());

            Console.Write("Nombre del Arco que dispara la Flecha: ");
            string nameWeapon = Console.ReadLine();

            WeaponRange arrow = new WeaponRange(nameWeapon, damage, velocityAttack, price, new Projectile(0));
            inventory.Add((IWeaponDamage)arrow);

            Console.WriteLine($"Flecha '{name}' para el arco '{nameWeapon}' fue agregada al inventory.");
        }

        static void AddBullet(List<IWeaponDamage> inventory)
        {
            Console.Write("Nombre de la Bala: ");
            string name = Console.ReadLine();

            Console.Write("Daño de la Bala: ");
            float damage = float.Parse(Console.ReadLine());

            Console.Write("Velocidad de Ataque de la Bala: ");
            float velocityAttack = float.Parse(Console.ReadLine());

            Console.Write("Precio de la Bala: ");
            float price = float.Parse(Console.ReadLine());

            Console.Write("Nombre de la Pistola que dispara la Bala: ");
            string nameWeapon = Console.ReadLine();

            WeaponRange bullet = new WeaponRange(nameWeapon, damage, velocityAttack, price, new Projectile(0));
            inventory.Add((IWeaponDamage)bullet);

            Console.WriteLine($"La Bala '{name}' para la Pistola '{nameWeapon}' fue agregada al inventaio.");
        }

        static void ShowInventory(List<IWeaponDamage> inventory)
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("El inventario está vacío.");
            }
            else
            {
                Console.WriteLine("Inventario:");

                for (int i = 0; i < inventory.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {inventory[i].Getname()} (DPS: {inventory[i].DPS()}, Precio: {inventory[i].Getprice()})");
                }
            }
        }
        static void DeleteWeapon(List<IWeaponDamage> inventory)
        {
            ShowInventory(inventory);

            if (inventory.Count == 0)
            {
                Console.WriteLine("No hay Armas para eliminar del inventario.");
                return;
            }

            Console.Write("Seleccione el número de arma que desea eliminar: ");

            if (int.TryParse(Console.ReadLine(), out int option) && option >= 1 && option <= inventory.Count)
            {
                string nameDeleteWeapon = inventory[option - 1].Getname();
                inventory.RemoveAt(option - 1);
                Console.WriteLine($"Se ha eliminado '{nameDeleteWeapon}' del inventario.");
            }
            else
            {
                Console.WriteLine("Esta opción no existe. Por favor, intente de nuevo.");
            }
        }
    }
}
