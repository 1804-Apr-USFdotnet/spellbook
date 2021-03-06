﻿using AutoMapper;

namespace Spellbook.Models
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Spell, SpellDTO>();
            CreateMap<SpellList, SpellListDTO>();
            CreateMap<Character, CharacterDTO>();
        }
    }
}
