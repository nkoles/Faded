using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public KeyCard KeyCard;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Door Triggered");
        if(other.gameObject.CompareTag("Player") && KeyCard.hasKeyCard)
            Debug.Log("Door Opened");
    }
}
