using System.Collections.Generic;
using UnityEngine;

public class UnitInstance
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
