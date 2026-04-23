using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testing
{
    public class Hero
    {
        private int xp;
        private float health;

        public string Name { get; }

        public int XP
        {
            get => xp;
            set
            {
                if (value > xp)
                {
                    xp = value;
                }
            }
        }

        public int Level => 1 + xp / 1000;

        public float Health
        {
            get => health;
            set
            {
                health = value;
                if (health < 0)
                {
                    health = 0;
                }
                else if (health > MaxHealth)
                {
                    health = MaxHealth;
                }
            }
        }

        public float MaxHealth => 100 + (Level - 1) * 20;

        public void TakeDamage(float damage)
        {
            Health -= damage;
            XP += (int)damage / 20;
        }

        public Hero(string name)
        {
            Name = name;
            XP = 0;
            Health = MaxHealth;
        }
    }
/*
    class Person
{
    private string name;

    // Constructor
    public Person(string n)
    {
        name = n;
    }

    // Method
    public void SayHello()
    {
        Console.WriteLine("Hello, my name is " + name);
    }
}
*/
}