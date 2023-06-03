using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flood: MyMonoBehaviour
{
    private static Flood instance;
    public static Flood Instance {get => instance;}
    public bool flooding;
    public float speed;
    protected override void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
    protected void FixedUpdate()
    {
        if(flooding)  this.FloodRunning();
    }
    protected void FloodRunning()
    {
        this.transform.Translate(Vector3.up * Time.deltaTime * speed);    
    }
}
