using System;

namespace wizardNinjaSamurai
{
    public class Human
    {
        public string name;

        //The { get; set; } format creates accessor methods for the field specified
        //This is done to allow flexibility
        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }

        public Human(string person)
        {
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        public Human(string person, int str, int intel, int dex, int hp)
        {
            name = person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }
        public void attack(object obj)
        {
            Human enemy = obj as Human;
            if (enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.health -= strength * 5;
            }
        }

        public class Ninja : Human
        {
            public Ninja(string n) : base(n)
            {
                dexterity = 175;
            }
            public void Steal(object target)
            {
                Human enemey = target as Human;
                if(enemey == null)
                {
                    System.Console.WriteLine("You didnt steal from any one");
                } else
                {
                    attack(enemy);
                    health += 10;
                }
            }
            public void GetAway()
            {  
                health -= 15;
            }
        }
        public class Wizard : Human
        {
            public Wizard(string n) : base(n)
            {
                health = 50;
                intelligence = 25;
            }
            public void Heal()
            {
                health += 10;
                System.Console.WriteLine("Wizard health is at {0}", health);
            }
            public void Fireball(object target)
            {   
                Random rand = new Random();
                Human enemy = target as Human;
                if(enemy == null)
                {
                    System.Console.WriteLine("You attacked no one");
                } else 
                {
                    enemy.health -= rand.Next(20,50);
                }
            }
        }
        public class Samurai : Human
        {
            public Samurai(string n) : base(n)
            {
                health = 200;
            }
            public void DeathBlow(object target)
            {
                Human enemy = target as Human;
                if(enemy == null)
                {
                    System.Console.WriteLine("DeathBlow failed");
                }
                if(enemy.health < 50)
                {
                    enemy.health = 0;
                }
            }
        }
    }
}