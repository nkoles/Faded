using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private KeyCard KeyCard;
    public GameObject text;
    private bool gameWon;

    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        KeyCard = GameObject.FindObjectOfType<KeyCard>();

        if(gameWon)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Door Triggered");
        if(other.gameObject.tag == "Player" && KeyCard.hasKeyCard)
        {
            Debug.Log("Door Opened");
            gameWon = true;
        }else if(other.gameObject.tag == "Player"){
            text.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            text.SetActive(false);
        }
    }
}
