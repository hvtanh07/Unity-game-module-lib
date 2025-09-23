using UnityEngine;

public class HealthSystem : CharacterSystem
{
    public int currentHealth; // Current health
    public int maxHealth; // Maximum health
    bool isDead; // Flag to check if the character is dead

    protected override void Awake()
    {
        base.Awake();
        maxHealth = character.health;
        currentHealth = maxHealth;
        isDead = false;
    }

    void OnEnable()
    {
        character.events.OnGetHit += ApplyDamage; // Subscribe to the OnAlerted event
    }
    void OnDisable()
    {
        character.events.OnGetHit -= ApplyDamage; // Unsubscribe from the OnAlerted event
    }

    // Method to apply damage
    public void ApplyDamage(int damage)
    {
        currentHealth -= damage; // Reduce current health by damage amount
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        character.events.OnCharacterDeath?.Invoke(); // Trigger the death event
        isDead = true; // Set the dead flag to true
    }

    public void ReSpawn()
    {
        currentHealth = maxHealth; // Reset current health to max health
        isDead = false; // Reset the dead flag
    }
    public void ReSpawn(int respawnHealth)
    {
        currentHealth = respawnHealth; // Reset current health to max health
        isDead = false; // Reset the dead flag
    }
}
