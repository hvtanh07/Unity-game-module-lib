using UnityEngine;

public class RunningState : MonoBehaviour
{
    public RunningState()
    {
        
    }
    public void Enter()
    {
        // code that runs when we first enter the state
    }
    public void Execute()
    {
        // Here we add logic to detect if the conditions exist to
        // transition to another state
        //TransitionTo(new IdleState());
    }
    public void Exit()
    {
        // code that runs when we exit the state
    }
}
