using UnityEngine;

public class GameOverState : IState<GameManagerMStateMachine>
{
    private GameManagerMStateMachine _owner;
    public void OnEnter(GameManagerMStateMachine owner)
    {
        _owner = owner;
        Debug.Log("Entering Game Over State");
        // Logic that runs when we enter the state

        _owner.gameOverPanel.gameObject.SetActive(true);
    }
    
    public void OnUpdate()
    {
        // Gameplay logic here


    }

    public void OnExit()
    {
        Debug.Log("Exiting Game Over State");
        // code that runs when we exit the state

        _owner.gameOverPanel.gameObject.SetActive(false);
    }
}
