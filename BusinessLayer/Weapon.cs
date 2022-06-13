using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Weapon
    {
        [Key]
        public int ID { get; private set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public float DamageMultiplier { get; set; }

        [Required]
        public Ammo Ammo { get; set; }

        public List<Enemy> Enemies { get; set; }

        private Weapon()
        {
            
        }

        public Weapon(string name, string description, float damageMultiplier, Ammo ammo)
        {
            Name = name;
            Description = description;
            DamageMultiplier = damageMultiplier;
            Ammo = ammo;
        }
    }
}
