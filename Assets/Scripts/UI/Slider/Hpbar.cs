using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hpbar : BaseSlider
{
    [SerializeField] float ShowedMaxHp,ShowedCurrentHp;
    protected void LoadHp()
    {
        this.ShowedCurrentHp = PlayerCtrl.Instance.PlayerReciver.CurrentHp;
        this.ShowedMaxHp = PlayerCtrl.Instance.PlayerReciver.MaxHp;
    }
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        this.LoadHp();
        float HpPercent = ShowedCurrentHp/ShowedMaxHp;
        this.Slider.value = HpPercent;
    }
}
