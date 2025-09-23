using System;
using UnityEngine;

public struct CharacterEvent
{
    public Action OnCharacterDeath; // Event for character death
    public Action<int> OnGetHit; // Event for getting hit
}
