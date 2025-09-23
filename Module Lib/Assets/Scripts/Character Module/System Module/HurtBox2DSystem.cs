using UnityEngine;

public class HurtBox2DSystem : CharacterSystem
{
    public void GettingHit(int damage)
    {
        character.events.OnHealthChange?.Invoke(damage);
        character.events.OnGetHit?.Invoke(damage);
    }
}
