using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReciver : DameReciver
{
    protected float StunTime;
    protected bool stun = false;
    public virtual void IsStuned( float time)
    {
        this.StunTime = time;
    }
    protected IEnumerator Stunning()
    {
        if(StunTime != 0)
        {
            stun = true;
            yield return new WaitForSeconds(StunTime);
            stun = false;
            StunTime = 0 ;
        }
    }    
    protected override void FixedUpdate()
    {
    base.FixedUpdate();
    this.StartCoroutine(Stunning());
    PlayerCtrl.Instance.PlayerMoving.gameObject.SetActive(!stun);
    PlayerCtrl.Instance.PlayerSatchelOutScript.gameObject.SetActive(!stun);
    PlayerCtrl.Instance.GrapplingGun.gameObject.SetActive(!stun);
    }
    protected override bool CanDead()
    {
        if( currentHp > 0) return false;
        else return true;
    }
}
