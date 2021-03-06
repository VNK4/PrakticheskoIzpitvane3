using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public enum Behaviours
    {
        passive,
        agressive,
        neutral
    }

    // ohh the misery 
    public class Enemy
    {
        [Key]
        public int ID { get; private set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Health { get; set; }

        [Required]
        public double Armor { get; set; }

        [Required]
        public bool IsBoss { get; set; }

        [Required]
        public Behaviours Behaviour { get; set; }

        [Required]
        public DamageTypes WeakAgainst { get; set; }

        public IEnumerable<Weapon> Weapons { get; set; }

        private Enemy()
        {

        }

        public Enemy(string name, string description, double health, double armor, bool isBoss, Behaviours behaviour, DamageTypes weakAgainst)
        {
            Name = name;
            Description = description;
            Health = health;
            Armor = armor;
            IsBoss = isBoss;
            Behaviour = behaviour;
            WeakAgainst = weakAgainst;
            Weapons = new HashSet<Weapon>();
        }

        public Enemy(int id, string name, string description, double health, double armor, bool isBoss, Behaviours behaviour, DamageTypes weakAgainst)
            :this(name, description, health, armor, isBoss, behaviour, weakAgainst)
        {
            this.ID = id;
        }

        public Enemy(string name, string description, double health, double armor, bool isBoss, Behaviours behaviour, DamageTypes weakAgainst, IEnumerable<Weapon> weapons)
            :this(name, description, health, armor, isBoss, behaviour, weakAgainst)
        {
            this.Weapons = weapons;
        }


    }
}
