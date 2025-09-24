using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Hitbox3DSystem : HitBoxSystem
{
    protected override void Awake()
    {
        base.Awake();
    }
    private void OnTriggerEnter(Collider other)
    {
        // Try to get the Hurtbox component from what we hit
        HurtBoxSystem hurtbox = other.GetComponent<HurtBoxSystem>();

        // Check if we hit a valid hurtbox && additional logic (e.g., is this enemy or ally?)
        if (hurtbox == null || false) return;

        Character hitChar = hurtbox.GetCharacter();

        // If we haven't hit this target's health controller before...
        if (_hitTargets.Contains(hitChar)) return;

        Debug.Log("First hit on " + hitChar.name);

        // ...deal damage and add it to the list of hit targets.
        if (scaleByPercent)
        {
            hurtbox.GettingHitbyPercent(percent, damageType);
        }
        else
        {
            hurtbox.GettingHit(damage, damageType);
        }
        _hitTargets.Add(hitChar);

        if (DestroyOnHit)
        {
            //Add logic to spawn VFX or SFX here
            Destroy(gameObject);
        }
    }
}
