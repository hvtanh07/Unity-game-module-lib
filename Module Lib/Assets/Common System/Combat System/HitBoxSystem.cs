using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;

public enum DamageType
{
    Physical,
    Magical,
    True
}

public class HitBoxSystem : MonoBehaviour
{
    [SerializeField]
    protected DamageType damageType = DamageType.Physical;
    
    [SerializeField]
    protected int damage = 10;
    [SerializeField]
    protected bool scaleByPercent = false;
    protected float percent = 10f;
    public bool DestroyOnHit = false;


    protected List<Character> _hitTargets = new List<Character>();

    // Clear the list whenever the attack is reused (e.g., from an object pool)
    protected virtual void Awake()
    {
        try
        {
            GetComponent<Collider>().isTrigger = true;
        }
        catch (System.Exception)
        {
            Debug.LogError("No collider found on " + gameObject.name + ". Please add a collider.");
        }
        
        _hitTargets.Clear();
    }

    public void ResetAttack()
    {
        _hitTargets.Clear();
    }

    public void registerByDamgage(int dmg, DamageType dmgType, bool DestroyOnHit = false)
    {
        this.damageType = dmgType;
        damage = dmg;
        this.DestroyOnHit = DestroyOnHit;
    }
    public void registerByPercent(float percent, DamageType dmgType, bool DestroyOnHit = false)
    {
        scaleByPercent = true;
        this.percent = percent;
        this.damageType = dmgType;
        this.DestroyOnHit = DestroyOnHit;
    }
}
