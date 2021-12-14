using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : Collidable
{
    protected bool collected;

    protected override void OnCollider(Collider2D coll)
    {
        if (coll.name == "player")
            OnCollect();
    }

    protected virtual void OnCollect()
    {
        collected = true;
    }
}
