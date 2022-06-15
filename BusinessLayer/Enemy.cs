using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
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
        public Enum Behaviour { get; set; }

        [Required]
        public Enum WeakAgainst { get; set; }

        public List<Weapon> Weapons { get; set; }

        private Enemy()
        {

        }

        public Enemy(string name, string description, double health, double armor, bool isBoss, Enum behaviour, Enum weakAgainst)
        {
            Name = name;
            Description = description;
            Health = health;
            Armor = armor;
            IsBoss = isBoss;
            Behaviour = behaviour;
            WeakAgainst = weakAgainst;
        }
    }
}
