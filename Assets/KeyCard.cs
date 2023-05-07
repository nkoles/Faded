using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class KeyCard : MonoBehaviour
{
    public SpriteRenderer spr;
    private BoxCollider2D keyCardTrigger;
    public GameObject keyCard;
    public bool hasKeyCard = false;
    public GameObject icon;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        keyCardTrigger = GetComponent<BoxCollider2D>();
        spr.color = Random.ColorHSV();
        icon = GameObject.FindWithTag("keyIcon");
        icon.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && other.isTrigger == false)
        {
            hasKeyCard = true;
            spr.enabled = false;


            icon.SetActive(true);
            
            Debug.Log("KeyCard Triggered");
        }
        
    }
    
}
