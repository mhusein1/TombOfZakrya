using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitbox : Collidable
{
    //Damage
    public int damage;
    public float pushForce;

    protected override void OnCollider(Collider2D coll)
    {
        if(coll.tag == "Fighter" && coll.name == "player")
        {
            Damage dmg = new Damage
            {
                damageAmount = damage,
                origin = transform.position,
                pushForce = pushForce

            };

            coll.SendMessage("RecieveDamage", dmg);
        }
    }
}
