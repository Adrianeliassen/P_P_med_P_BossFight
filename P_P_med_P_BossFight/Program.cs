using P_P_med_P_BossFight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_P_med_P_BossFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.Runfight();
        }
        public static void Runfight()
        {
            Console.WriteLine("Lets fight! Press any key to start fighting");
            string startFight = Console.ReadLine();
            Player hero = new Player("Hero", 100, 20, 40, false);
            Player boss = new Player("Boss", 400, 20, 10, true);

            while (!(boss.IsDead || hero.IsDead)) Fight(hero, boss);
        }
        private static void Fight(Player hero, Player boss)
        {
            hero.Fight(boss);
            if(boss.Health <= 0 )
            {
                boss.Die();
                return;
            }
            boss.Fight(hero);
            if (hero.Health <= 0) hero.Die();
        }
    }
    
}
//Random rand = new Random();
//Strength = rand.Next(0,30);
//while (Hero.Health == 0 || Boss.health == 0) {}
