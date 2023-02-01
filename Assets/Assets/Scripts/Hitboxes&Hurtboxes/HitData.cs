using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitData
{
    public int damage;
    public Vector3 hitPoint;
    public Vector3 hitNormal;
    public IHurtBox hurtbox;
    public IHitDetector hitDetector;

    public bool Validate()
    {
        if(hurtbox != null)
            if(hurtbox.CheckHit(this))
                if(hurtbox.HurtResponder == null || hurtbox.CheckHit(this))
                    if(hitDetector.HitResponder == null || hitDetector.HitResponder.CheckHit(this))
                        return true;

        return false;
    }
}

public interface IHitResponder
{ 
    int Damage { get; }

    bool CheckHit(HitData data);
    void Response(HitData data);
}

public interface IHitDetector
{
    IHitResponder HitResponder { get; set; }
    void CheckHit();
}

public enum HurtboxType
{ 
    Player = 1 << 0,
    Enemy  = 1 << 1,
    Ally   = 1 << 2
}
[System.Flags]
public enum HurtboxMask
{
    None   = 0,         //0000b
    Player = 1 << 0,    //0001b
    Enemy  = 1 << 1,    //0010b
    Ally   = 1 << 2,    //0100b
}


public interface IHurtResponder
{
    bool CheckHit(HitData data);
    void Response(HitData data);
}

public interface IHurtBox
{
    bool Active { get; }

    GameObject Owner { get; }

    Transform Transform { get; }
    HurtboxType Type { get; }
    IHurtResponder HurtResponder { get; set; }
    bool CheckHit(HitData hitData);
}

