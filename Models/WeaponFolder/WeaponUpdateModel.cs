﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.WeaponFolder
{
    public class WeaponUpdateModel
    {
        public int WeaponId { get; set; }
        public string UpdatedName { get; set; }
        public string UpdatedType { get; set; }
        public string UpdatedRange { get; set; }
        public string UpdatedWeaponColor { get; set; }
        public string UpdatedBladeOrEnergyColor { get; set; }
        public string UpdatedDamage { get; set; }
        public int UpdatedPrice { get; set; }
    }
}
