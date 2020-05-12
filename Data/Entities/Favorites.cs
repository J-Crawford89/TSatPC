﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Favorites
    {
        [Key]
        public int FavoritesId { get; set; }

        [ForeignKey("FavoriteCharacter")]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }

        [ForeignKey("FavoritePlanet")]
        public int PlanetId { get; set; }
        public virtual Planet Planet { get; set; }

        [ForeignKey("FavoriteShip")]
        public int ShipId { get; set; }
        public virtual Ship Ship { get; set; }

        [ForeignKey("FavoriteWeapon")]
        public int WeaponId { get; set; }
        public virtual Weapon Weapon { get; set; }
    }
}
