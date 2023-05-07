using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDetection : MonoBehaviour
{

    public GameObject enemy;
    private float rotationTimerFloat = 0.0f;
    public int rotationTimer = 0;
    private Transform enemyTransform;
    public LayerMask player;
    public bool detected;
    private GameObject Player;
    


    // Start is called before the first frame update
    void Start()
    {
        enemyTransform = enemy.GetComponent<Transform>();
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        rotationTimerFloat += Time.deltaTime;
        rotationTimer = (int)rotationTimerFloat;
        
        rotate();
        playerDetected();
    }

    void rotate()
    {

        if (rotationTimer >= 0 && rotationTimer < 5)
        {
            var playerHitRight = Physics2D.Raycast(transform.position, Vector2.right, 5.0f, player);
            
            if (playerHitRight.collider != null && Input.GetKey(KeyCode.E))
            {
                Debug.Log("Player Detected");
                detected = true;
            }
        }

        if (rotationTimer >= 5 && rotationTimer < 10)
        {
            //enemyTransform.transform.rotation = Quaternion.Euler(0, 0, 90);
            
            var playerHitUp = Physics2D.Raycast(transform.position, Vector2.up, 5.0f, player);
            
            if (playerHitUp.collider != null && Input.GetKey(KeyCode.E))
            {
                Debug.Log("Player Detected");
                detected = true;
            }
        }

        if (rotationTimer >= 10 && rotationTimer < 15)
        {
            //enemyTransform.transform.rotation = Quaternion.Euler(0, 0, 180); 
            
            var playerHitLeft = Physics2D.Raycast(transform.position, Vector2.left, 5.0f, player);
            
            if (playerHitLeft.collider != null && Input.GetKey(KeyCode.E))
            {
                Debug.Log("Player Detected");
                detected = true;
            }
        }

        if (rotationTimer >= 15 && rotationTimer < 20)
        {
            //enemyTransform.transform.rotation = Quaternion.Euler(0, 0, 270);
            
            var playerHitDown = Physics2D.Raycast(transform.position, Vector2.down, 5.0f, player);
            
            if (playerHitDown.collider != null && Input.GetKey(KeyCode.E))
            {
                Debug.Log("Player Detected");
                detected = true;
            }
        }
        
        if (rotationTimer == 20)
        {
            //enemyTransform.transform.rotation = Quaternion.Euler(0, 0, 0);
            
            var playerHitDown = Physics2D.Raycast(transform.position, Vector2.right, 5.0f, player);
            
            if (playerHitDown.collider != null && Input.GetKey(KeyCode.E))
            {
                Debug.Log("Player Detected");
                detected = true;
            }
            
            rotationTimerFloat = 0.0f;
        }
    }

    void playerDetected()
    {
        if(detected)
        {
            Vector3 playerDir = Player.transform.position - transform.position;
            float speed = 0.5f;

            transform.Translate(playerDir*Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
