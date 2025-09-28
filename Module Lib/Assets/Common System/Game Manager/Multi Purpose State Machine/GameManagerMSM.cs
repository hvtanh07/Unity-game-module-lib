using UnityEngine;

[RequireComponent(typeof(GameManagerMSMManager))]
public class GameManagerMSM : MonoBehaviour
{
    public static GameManagerMSM Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        // Get the StateManager component.
        StateManager = GetComponent<MStateManager<GameManagerMSM>>();

        // Initialize the StateManager with this component as the owner.
        StateManager.Initialize(this);

        // Create and add all possible player states.
        StateManager.AddState(new NewGameState());
        StateManager.AddState(new GameplayState());
        StateManager.AddState(new GameOverState());
    }
    public MStateManager<GameManagerMSM> StateManager { get; private set; }

    // Other player components that states might need to control.
    public RectTransform gameOverPanel;
    public RectTransform NewGamePanel;

    public int Score { get; private set; }
    public int Lives { get; private set; } = 3;

    private void Start()
    {
        // Set the initial state.
        StateManager.ChangeState<NewGameState>();
    }
}
