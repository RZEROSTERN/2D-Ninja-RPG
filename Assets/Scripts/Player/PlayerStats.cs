using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "Player Stats")]
public class PlayerStats : ScriptableObject
{
    [Header("Config")]
    public int Level;
    [Header("Health")]
    public float Health;
    public float MaxHealth;

    [Header("Mana")]
    public float Mana;
    public float MaxMana;

    [Header("XP")]
    public float CurrentExperience;
    public float NextLevelExperience;
    public float InitialNextLevelExperience;
    [Range(1f, 100f)] public float ExperienceMultiplier;

    public void ResetPlayer()
    {
        Health = MaxHealth;
        Mana = MaxMana;
        Level = 1;
        CurrentExperience = 0;
        NextLevelExperience = InitialNextLevelExperience;
    }
}
