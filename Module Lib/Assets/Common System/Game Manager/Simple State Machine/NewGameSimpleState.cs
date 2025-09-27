using UnityEngine;

public class NewGameSimpleState : IStateGM
{
    
    public void Enter()
    {
        Debug.Log("Entering New Game Simple State");
        // code that runs when we first enter the state
    }
    public void Execute()
    {
        // per-frame logic, include condition to transition to a new state
    }
    public void Exit()
    {
        // code that runs when we exit the state
    }
}
