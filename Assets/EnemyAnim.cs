using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnim : MonoBehaviour
{
    // Start is called before the first frame update

    private EnemyDetection edScript;
    private Animator animator;
    private int rotationTimer;
    void Start()
    {
        edScript = gameObject.GetComponent<EnemyDetection>();
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rotationTimer = edScript.rotationTimer;
        
         if (rotationTimer >= 0 && rotationTimer < 5)
        {
            animator.SetTrigger("Right");
        }

        if (rotationTimer >= 5 && rotationTimer < 10)
        {
            animator.SetTrigger("Up");
        }

        if (rotationTimer >= 10 && rotationTimer < 15)
        {
           animator.SetTrigger("Left");
        }

        if (rotationTimer >= 15 && rotationTimer < 20)
        {
            animator.SetTrigger("Down");
        }
        
        if (rotationTimer == 20)
        {
            animator.SetTrigger("Right");
        }
    }
    
    
}
