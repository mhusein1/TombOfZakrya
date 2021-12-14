using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : Mover
{
    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        UpdateMotor(new Vector3(x, y, 0));
    }

    protected override void Death()
    {
        GameManager.instance.ShowText("GAMEOVER", 25, Color.red, transform.position, Vector3.zero, 0.5f);
        SceneManager.LoadScene("StartMenu");


    }
}
