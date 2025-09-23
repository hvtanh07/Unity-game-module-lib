using System;
using UnityEngine;

public class CharacterEvent
{
    public Action<int> OnHealthChange; // Event for health change
    public Action OnCharacterDeath; // Event for character death
    public Action<int> OnGetHit; // Event for getting hit
}
