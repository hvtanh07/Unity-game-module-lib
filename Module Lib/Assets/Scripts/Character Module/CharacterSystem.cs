using UnityEngine;

public class CharacterSystem : MonoBehaviour
{
    protected Character character;
    protected virtual void Awake()
    {
        character = transform.root.GetComponent<Character>();
    }
}

