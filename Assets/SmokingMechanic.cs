using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokingMechanic : MonoBehaviour
{
    
    public float smokeNeed = 100f;
    public float smokeDecrease = 0.1f;
    private float smokeHeldTimer = 0f;
    
    private KeyCode smokeKey = KeyCode.E;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void takeSmoke ()
    {
        if(Input.GetKeyDown(smokeKey))
        {
            StartCoroutine(smokeHeld)
        }
        
        
        Debug.Log(smokeHeldTimer);
    }

    private void smokeHeld()
    {
        
    }

    private void FixedUpdate()
    {
        needDecrease();
        takeSmoke();
    }

    // ReSharper disable Unity.PerformanceAnalysis
    void needDecrease()
    {
        smokeNeed -= smokeDecrease;
        smokeNeed = Mathf.Clamp(smokeNeed, 0f, 100f);
    }
}
