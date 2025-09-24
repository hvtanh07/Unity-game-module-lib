using UnityEngine;


public class DemoCharacterSystem : CharacterSystem
{
    protected override void Awake()
    {
        base.Awake();
    }
    void OnEnable()
    {
        //character.events.On += HandleEvent; // Subscribe to the OnAlerted event

    }
    void OnDisable()
    {
        //character.events.On -= HandleEvent; // Unsubscribe from the OnAlerted event
    }

    private void HandleEvent()
    {
        //character.stats.health;
        //character.events.OnEvent?.Invoke();
    }
}
