using UnityEngine;
using System;

[CreateAssetMenu(fileName = "HealthData", menuName = "MVP Model/Health")]
public class HealthModel : ScriptableObject
{
    public event Action HealthChanged;
    public int CurrentHealth;
    public string LabelName;

    public void Increment(int amount) { }
    public void Decrement(int amount) { }
    public void Restore() { }
}
