using UnityEngine;

public interface IStateGM
{
    public void Enter(StateManagerGM stateManager)
    {
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
