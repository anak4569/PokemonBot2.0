﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types; using PokemonBot2._0.DataFiles.Moves;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class ThundurusT : Pokemon
    {
        public ThundurusT(double health, string status)
        {
            name = "ThundurusT";
            type1 = new Flying();
            type2 = new Electric();
            
            estimatedSpeed = 309; estimatedHealth = 309; estimatedAttack = 309; estimatedDefense = 309; estimatedSpAttk = 309; estimatedSpDef = 309; move1 = new Flamethrower(); move2 = new Flamethrower(); move3 = new Flamethrower(); move4 = new Flamethrower(); Initialize(name, health, status);
        }

        public ThundurusT() : this(100, "None")
        {

        }

        protected override List<Type> GetImmunities()
        {
            List<Type> immune = new List<Type>();
            foreach (Type a in typing)
            {
                foreach (Type b in a.getImmunities())
                {
                    immune.Add(b);
                }
            }
            immune.Add(new Electric());
            return immune;
        }
    }
}
