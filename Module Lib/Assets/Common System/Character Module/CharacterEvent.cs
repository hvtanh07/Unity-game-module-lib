using System;
using UnityEngine;

public struct CharacterEvent
{
    public Action OnCharacterDeath; // Event for character death
    public Action<int> OnHealthChange; // Event for health change
    public Action<int,DamageType> OnGetHit; // Event for getting hit
    public Action<float,DamageType> OnGetHitbyPercentDamage; // Event for getting hit by percent damage
}
