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
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        keyCardTrigger = GetComponent<BoxCollider2D>();
        spr.color = Random.ColorHSV();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("KeyCard Triggered");
        if (other.gameObject.CompareTag("Player"))
        {
            hasKeyCard = true;
            spr.enabled = false;
        }
        
    }
    
}
