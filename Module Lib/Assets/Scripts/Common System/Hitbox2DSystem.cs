using UnityEngine;
using System.Collections.Generic;

public class Hitbox2DSystem : MonoBehaviour
{
    public int damage = 10;
    private List<Character> _hitTargets = new List<Character>();

    // Clear the list whenever the attack is reused (e.g., from an object pool)
    void OnEnable()
    {
        _hitTargets.Clear();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Try to get the Hurtbox component from what we hit
        HurtBoxSystem hurtbox = other.GetComponent<HurtBoxSystem>();

        // Check if we hit a valid hurtbox && additional logic (e.g., is this enemy or ally?)
        if (hurtbox != null && true)
        {
            Character hitChar = hurtbox.GetCharacter();

            // If we haven't hit this target's health controller before...
            if (!_hitTargets.Contains(hitChar))
            {
                Debug.Log("First hit on " + hitChar.name);

                // ...deal damage and add it to the list of hit targets.
                hurtbox.GettingHit(damage);
                _hitTargets.Add(hitChar);
            }
            // If it's already in the list, we do nothing.
        }
    }
}
