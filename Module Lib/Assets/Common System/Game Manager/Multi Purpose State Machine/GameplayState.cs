using UnityEngine;

public class GameplayState : IState<GameManagerMStateMachine>
{
    private GameManagerMStateMachine _owner;
    public void OnEnter(GameManagerMStateMachine owner)
    {
        _owner = owner;
        Debug.Log("Entering Gameplay State");
        // Logic that runs when we enter the state
    }
    
    public void OnUpdate()
    {
        // Gameplay logic here

        // If player die or fail some condition, transition to GameOverState
        //_owner.StateManager.ChangeState<GameOverState>();
    }

    public void OnExit()
    {
        Debug.Log("Exiting Gameplay State");
        // code that runs when we exit the state
    }
}
