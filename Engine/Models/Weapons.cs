﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Weapons : GameItems
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public Weapons(int itemTypeID, string name, int price, int minDamage, int maxDamage)
            : base(itemTypeID, name, price)
        {
            MinimumDamage = minDamage;
            MaximumDamage = maxDamage;
        }
        public new Weapons Clone()
        {
            return new Weapons(ItemTypeID, Name, Price, MinimumDamage, MaximumDamage);
        }
    }
}
