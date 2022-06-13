using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Ammo
    {
        [Key]
        
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Damage { get; set; }

        [Required]
        public Enum DamageType { get; set; }

        public List<Weapon> Weapons { get; set; }

        private Ammo()
        {
            
        }

        public Ammo(string name, string description, double damage, Enum damageType)
        {
            Name = name;
            Description = description;
            Damage = damage;
            DamageType = damageType;
        }
    }
}
