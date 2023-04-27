using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private float timer;
    public Animator anim;
    public PlayerMove playerScript;
    public float idleTime;

    private bool alternate = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKeyDown(playerScript.moveUp) || Input.GetKeyDown(playerScript.moveDown) || Input.GetKeyDown(playerScript.moveLeft) || Input.GetKeyDown(playerScript.moveRight))
        {
            if (alternate)
            {
                anim.SetTrigger("StepL");
                Debug.Log("Left");
            }
            else
            {
                anim.SetTrigger("StepR");
            }

            alternate = !alternate;

            timer = 0;
        }

        if (timer > idleTime)
        {
            anim.SetTrigger("GoIdle");

            timer = 0;
        }
    }
}
