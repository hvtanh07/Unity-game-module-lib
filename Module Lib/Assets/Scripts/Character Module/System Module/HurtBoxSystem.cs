using UnityEngine;

public class HurtBoxSystem : CharacterSystem
{
    protected override void Awake()
    {
        base.Awake();
    }
    public Character GetCharacter() => character;
    public void GettingHit(int damage)
    {
        character.events.OnGetHit?.Invoke(damage);
    }
}
