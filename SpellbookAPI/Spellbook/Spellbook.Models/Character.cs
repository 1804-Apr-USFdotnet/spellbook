﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spellbook.Models
{
    public class Character
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CharacterId {get; set;}
        public string Name { get; set; }
        public int Level {get; set;}
        //public virtual User {get; set;}
        public virtual SpellList Spellbook {get; set;}
    }
}
