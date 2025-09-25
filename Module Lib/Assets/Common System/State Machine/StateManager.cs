// StateManager.cs

using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A generic, multipurpose State Machine controller.
/// </summary>
/// <typeparam name="T">The context type (e.g., PlayerController, UIManager).</typeparam>
public class StateManager<T> : MonoBehaviour where T : MonoBehaviour
{
    // The context this state machine operates on.
    public T Owner { get; private set; }

    // Dictionary to store all available states, mapped by their type.
    private Dictionary<Type, IState<T>> _states = new Dictionary<Type, IState<T>>();
    
    // The currently active state.
    public IState<T> CurrentState { get; private set; }

    /// <summary>
    /// Initializes the StateManager with its owner/context.
    /// </summary>
    public void Initialize(T owner)
    {
        Owner = owner;
    }

    /// <summary>
    /// Adds a state to the state machine's dictionary.
    /// </summary>
    public void AddState(IState<T> state)
    {
        _states.Add(state.GetType(), state);
    }
    
    // The main update loop, called by Unity.
    private void Update()
    {
        // If there is an active state, call its update method.
        CurrentState?.OnUpdate();
    }

    /// <summary>
    /// Transitions the state machine to a new state.
    /// </summary>
    /// <typeparam name="TState">The type of the state to transition to.</typeparam>
    public void ChangeState<TState>() where TState : IState<T>
    {
        // Exit the current state, if there is one.
        CurrentState?.OnExit();
        
        // Find the new state in the dictionary.
        var newStateType = typeof(TState);
        if (_states.TryGetValue(newStateType, out IState<T> newState))
        {
            // Set the new state and call its entry method.
            CurrentState = newState;
            CurrentState.OnEnter(Owner);
        }
        else
        {
            Debug.LogError($"[StateManager] State of type {newStateType.Name} not found.");
        }
    }
}
