using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class DameReciver : MyMonoBehaviour
{
    [SerializeField] protected float maxHp;
    [SerializeField] protected float currentHp;


    public float MaxHp => maxHp;
     public float CurrentHp => currentHp;

    public virtual void ReducedHp(float Dame)
    {
        currentHp -= Dame;
        if(currentHp <= 0 ) currentHp = 0;
    }
    public virtual void IncreacsedHp(float Dame)
    {
        if(currentHp > maxHp ) currentHp = maxHp;
        currentHp += Dame;
    }
    public virtual void Reborn()
    {
        currentHp = maxHp;
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.Reborn();
    }
}
