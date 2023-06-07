using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_P_med_P_BossFight
{
    public class Player
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int Strength { get; private set; }
        public int Stamina { get; private set; }
        public bool IsDead { get; private set; }
        public bool IsBoss { get; private set; }
        public int BaseStamina { get; private set; }

        public Player(string name, int health, int strength, int stamina, bool isBoss)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Stamina = stamina;
            IsBoss = isBoss;
            BaseStamina = stamina;
        }
        public void Recharge()
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(500);
            });
            t.Wait();

            Stamina = BaseStamina;
            Console.WriteLine($"{Name} is out of stamina, recharging");
        }
        public void Fight(Player player)
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(500);
            });
            t.Wait();

            int AttackDamage = Strength;
            if(IsBoss)
            {
                Random r = new Random();
                AttackDamage = r.Next(0, Strength);
            }
            if (Stamina >= 10) 
            {
                
                player.Health -= AttackDamage;
                Stamina -= 10;
                Console.WriteLine($"\n\n{Name} attacked {player.Name} for {AttackDamage}HP. {player.Name} has {player.Health}HP remaining.");
            } else {
                Recharge();
            };
            
        }

        public void Die()
        {
            Console.WriteLine($"{Name} died");
            IsDead = true;
        }
    }
}
