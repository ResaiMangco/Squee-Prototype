using UnityEngine;
using System.Collections.Generic;
using System;


[CreateAssetMenu(menuName = "Additives/Traits/Trait Template")]
public class TraitSO : ScriptableObject
{
    public string id;

    public string displayName;

    [TextArea]
    public string description;
}

[CreateAssetMenu(menuName = "Additives/Statuses/Status Template")]
public class StatusSO : ScriptableObject
{
    public string id;

    public string displayName;
    public int duration;

    [TextArea]
    public string description;
}

[CreateAssetMenu(menuName = "Actions/Action Template")]
public class ActionSO : ScriptableObject
{
    public string actionName;
    public int actionPointCost;
    [TextArea]
    public string description;
}

[CreateAssetMenu(menuName = "Additives//Cover Types/Cover Type Template")]
public class CoverTypeSO : ScriptableObject
{
    public string id;
    public string displayName;
    public int protectionValue;
    [TextArea]
    public string description;
}

[CreateAssetMenu(fileName = "NewUnitTemplate", menuName = "Units/Unit Template")]
public class UnitSO : ScriptableObject
{
    public int tier;
    public string unitName;
    public int currentHealth;
    public int maximumHealth;
    public int shieldValue;
    public int rangeSkill;
    public int meleeSkill;
    public int rangeDefense;
    public int meleeDefense;
    public int speed;
    public int actionPoints;

    public List<TraitSO> traits;
    public List<StatusSO> status;

    public WeaponSO primaryWeapon;
    public WeaponSO secondaryWeapon;
    public WeaponSO meleeWeapon;

    public ArmorSO headArmor;
    public ArmorSO bodyArmor;
    public ArmorSO accessory;


    public List<ActionSO> availableActions;


}

[CreateAssetMenu(menuName = "Additives/Weapon Types/Weapon Type Template")]
public class WeaponTypeSO : ScriptableObject
{
    public string id;

    public string displayName;

    [TextArea]
    public string description;
}

[CreateAssetMenu(menuName = "Additives/Weapon Damage Types/Damage Type")]
public class DamageTypeSO : ScriptableObject
{
    public string id;

    public string displayName;

    [TextArea]
    public string description;
}


[CreateAssetMenu(menuName = "Additives/Weapon Specials/Weapon Specials Template")]
public class WeaponSpecialSO : ScriptableObject
{
    public string id;

    public string displayName;

    [TextArea]
    public string description;
}


[System.Serializable]
public struct RangeBand
{
    public string rangeName;
    public int min;
    public int max;

    [Range(-1f, 1f)]
    public float hitModifier;
}

[CreateAssetMenu(fileName = "NewWeaponTemplate", menuName = "Weapons/Weapon Template")]
public class WeaponSO : ScriptableObject
{
    public int tier;
    public string weaponName;
    public WeaponTypeSO weaponType;
    public DamageTypeSO damageType;
    public int currentMagazineSize;
    public int maximumMagazineSize;
    public int currentMagazines;
    public int maximumMagazines;
    public List<RangeBand> rangeProfile;
    public float critChance;
    public float critMultiplier;

    public List<ActionSO> availableActions;

    public int meleeEffect; // Melee effect when range?

    public List<WeaponSpecialSO> weaponSpecial;
    public int cashValue;


}


[CreateAssetMenu(menuName = "Additives/Armor Types/Armor Type Template")]
public class ArmorTypeSO : ScriptableObject
{
    public string id;
    public string displayName;
    [TextArea]
    public string description;

}

[CreateAssetMenu(fileName = "NewArmorTemplate", menuName = "Armor/Armor Template")]
public class ArmorSO : ScriptableObject
{
    public int tier;
    public string armorName;
    public int armorType;
    public int armorRating;
    public int defenseAmount;

    public int cashValue;

    
}
[CreateAssetMenu(menuName = "Armor/Head/Head Armor Template")]
public class HeadArmorSO : ArmorSO
{

}
[CreateAssetMenu(menuName = "Armor/Body/Body Armor Template")]
public class BodyArmorSO : ArmorSO
{

}

[CreateAssetMenu(menuName = "Armor/Accessory/Accessory Template")]
public class AccessorySO : ArmorSO
{

}