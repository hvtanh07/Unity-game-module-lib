using UnityEngine;
using System;

[Serializable]
public class StateManagerGM
{
    public IStateGM CurrentState { get; private set; }
    public int score { get; set; }
    public int lives { get; set; }
    public NewGameSimpleState newGameState;
    //public gameplayState gameplayState;
    //public gameOverState gameOverState;
    public void Initialize(IStateGM startingState)
    {
        CurrentState = startingState;
        startingState.Enter(this);
    }
    public void TransitionTo(IStateGM nextState)
    {
        CurrentState.Exit();
        CurrentState = nextState;
        nextState.Enter(this);
    }
    public void Execute()
    {
        if (CurrentState != null)
        {
            CurrentState.Execute();
        }
    }

    public StateManagerGM()
    {
        this.newGameState = new NewGameSimpleState();
        //this.gameplayState = new gameplayState();
        //this.gameOverState = new gameOverState();
    }
}
