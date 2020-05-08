﻿using Models.WeaponFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IWeaponService
    {
        void CreateWeapon(WeaponCreateModel weaponToCreate);
        IEnumerable<WeaponListModel> GetWeapons();
        WeaponDetailModel GetWeaponDetailById(int weaponId);
        void UpdateWeapon(WeaponUpdateModel weaponToUpdate);
        void DeleteWeapon(WeaponDeleteModel weaponToDelete);
    }
}