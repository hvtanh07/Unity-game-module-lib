using UnityEngine;

public class StateManager : MonoBehaviour
{
    StateMachine stateMachine;
    public IState CurrentState { get; private set; }
    public WalkingState walkState;
    public RunningState runState;
    public IdleState idleState;


}
