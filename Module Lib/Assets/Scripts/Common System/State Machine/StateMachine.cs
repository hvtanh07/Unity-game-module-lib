using System;
using UnityEngine;

[Serializable]
public class StateMachine : MonoBehaviour
{
    public IState CurrentState { get; private set; }
    public WalkingState walkState;
    public RunningState runState;
    public IdleState idleState;
    public void Initialize(IState startingState)
    {
        CurrentState = startingState;
        startingState.Enter();
    }
    public void TransitionTo(IState nextState)
    {
        CurrentState.Exit();
        CurrentState = nextState;
        nextState.Enter();
    }
    public void Execute()
    {
        if (CurrentState != null)
        {
            CurrentState.Execute();
        }
    }
}
