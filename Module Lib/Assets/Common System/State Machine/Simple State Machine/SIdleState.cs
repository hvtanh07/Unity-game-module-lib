using UnityEngine;

public class SIdleState : IState
{
    public void OnEnter(StateMachineController stateMachine)
    {
        // Logic for when the character *starts* idling (e.g., play idle animation)
        UnityEngine.Debug.Log("Entering Idle State");
    }

    public void OnUpdate(StateMachineController stateMachine)
    {
        // Logic for checking conditions to *change* state (e.g., if movement input is detected)
        if (UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.Space))
        {
            //stateMachine.ChangeState(new NextState()); // Change to your next state here
        }
    }

    public void OnExit(StateMachineController stateMachine)
    {
        // Logic for when the character *stops* idling (e.g., stop idle animation)
        UnityEngine.Debug.Log("Exiting Idle State");
    }
}
