using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MyMonoBehaviour
{
    public float a = 10;
    protected static PlayerCtrl instance;
    public static PlayerCtrl Instance => instance;

    [SerializeField] protected GrapplingGun grapplingGun;
    public GrapplingGun GrapplingGun { get => grapplingGun; }

    [SerializeField] protected PlayerSatchelOutScript playerSatchelOutScript;
    public PlayerSatchelOutScript PlayerSatchelOutScript { get => playerSatchelOutScript; }


    [SerializeField] protected PlayerMoving playerMoving;
    public PlayerMoving PlayerMoving { get => playerMoving ; }
    [SerializeField] protected PlayerReciver playerReciver;
    public PlayerReciver PlayerReciver { get => playerReciver ; }

    
    protected override void LoadComponents()
    {
        base.LoadComponents();
        playerMoving = GetComponentInChildren<PlayerMoving>();
        grapplingGun = GetComponentInChildren<GrapplingGun>();
        playerSatchelOutScript =  GetComponentInChildren<PlayerSatchelOutScript>();
        playerReciver =  GetComponentInChildren<PlayerReciver>();
    }
    protected override void Awake()
    {
        base.Awake();
        if(instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
}
