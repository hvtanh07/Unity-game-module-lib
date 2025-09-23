using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public CharacterEvent events;

    [Header("Character Stats")]
    public int health;
    public float moveSpeed;
}
