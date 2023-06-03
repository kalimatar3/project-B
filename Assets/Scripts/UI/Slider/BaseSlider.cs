using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseSlider : MyMonoBehaviour
{
    [SerializeField] protected Slider Slider;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSlider();
    }
    protected virtual void FixedUpdate()
    {
    //override
    }
    protected virtual void LoadSlider()
    {
        if( Slider != null) return ;
        this.Slider = GetComponent<Slider>();
        Debug.LogWarning(transform.name + " LoadSlider",gameObject);
    }
}
