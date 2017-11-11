
namespace human 
{
    public class Human
    {
        public string _name;
        public int strength = 3;
        public int intelligence = 3;
        public int health = 100;
        public int dexterity = 3;

        public Human(string name, int str, int intell, int dex, int hlth)
        {
            _name = name;
            strength = str;
            intelligence = intell;
            dexterity = dex;
            health = hlth;
        }
        public void Attack(object target)
        {
            Human enemy = target as Human;
            int damage = strength * 5;
            if(enemy != null)
            {
                enemy.health -= damage;
            }
        }
    }
}