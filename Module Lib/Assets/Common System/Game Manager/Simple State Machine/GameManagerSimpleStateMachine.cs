using Unity.VisualScripting;
using UnityEngine;

public class GameManagerSimpleStateMachine : MonoBehaviour
{
    public StateManagerGM stateMachine;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StateManagerGM stateManager = new StateManagerGM();
        stateManager.Initialize(new NewGameSimpleState());
    }
}
