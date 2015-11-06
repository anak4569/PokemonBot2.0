﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBot2._0.DataFiles.Types
{
    class Bug : Type
    {
        public override List<Type> getWeaknesses()
        {
            List<Type> weak = new List<Type>();
            weak.Add(new Fire());
            weak.Add(new Flying());
            weak.Add(new Rock());
            return weak;
        }

        public override List<Type> getResistances()
        {
            List<Type> resist = new List<Type>();
            resist.Add(new Ground());
            resist.Add(new Fighting());
            resist.Add(new Grass());
            return resist;
        }

        public override List<Type> getImmunities()
        {
            return new List<Type>();
        }
    }
}
