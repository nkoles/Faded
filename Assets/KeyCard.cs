using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCard : MonoBehaviour
{
    public SpriteRenderer spr;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        spr.color = Random.ColorHSV();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
