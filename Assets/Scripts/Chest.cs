using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;
    public int dollaAmount = 10;
    protected override void OnCollect()
    {
        if(!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            GameManager.instance.ShowText("+ " + dollaAmount + " dollas!", 25, Color.yellow, transform.position, Vector3.up * 25, 3.0f);
        }
    }
}
