﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types; using PokemonBot2._0.DataFiles.Moves;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Chesnaught : Pokemon
    {
        public Chesnaught(double health, string status)
        {
            name = "Chesnaught";
            type1 = new Grass();
            type2 = new Fighting();
            
            estimatedSpeed = 309; estimatedHealth = 309; estimatedAttack = 309; estimatedDefense = 309; estimatedSpAttk = 309; estimatedSpDef = 309; move1 = new Flamethrower(); move2 = new Flamethrower(); move3 = new Flamethrower(); move4 = new Flamethrower(); Initialize(name, health, status);
        }

        public Chesnaught() : this(100, "None")
        {

        }
    }
}
