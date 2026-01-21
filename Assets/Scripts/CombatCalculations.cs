using UnityEngine;



public static class CombatCalculations
{
    public static int CalculateHitChance( attacker,  defender)
    {



        int modifiers = 


        int baseHitChance = 75;
        int skillDifference = attackerSkill - defenderDefense;
        int hitChance = baseHitChance + (skillDifference * 5);
        // Clamp hit chance between 5% and 95%
        hitChance = Mathf.Clamp(hitChance, 5, 95);
        return hitChance;
    }

    public static int CalculateDamage(int baseDamage, int defenderArmor)
    {
        int damageAfterArmor = baseDamage - defenderArmor;
        return Mathf.Max(damageAfterArmor, 0); // Damage cannot be negative
    }

    public static int ApplyDamage()
}
