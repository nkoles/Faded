using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmokingMechanic : MonoBehaviour
{
    public Image cigaretteUI;
    public Image lungSmokeNeed;

    public float smokeNeed = 100f;
    public float smokeDecrease = 0.1f;
    private float smokeHeldTimer = 0f;
    
    private KeyCode smokeKey = KeyCode.E;

    private float smokeAdd;
    public float smokeAddMax = 5f;
    public float smokeCooldown = 5f;
    public float smokeMaxCooldown = 10;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        cigaretteUI.fillAmount = 1-smokeHeldTimer/12;
        


        var lungColor = lungSmokeNeed.color;
        lungColor.a = 1 - smokeNeed/100;
        lungSmokeNeed.color = lungColor;
    }
    
    private void takeSmoke ()
    {
        if (Input.GetKey(smokeKey))
        {
            
            smokeHeldTimer += Time.deltaTime;
            smokeAdd = smokeAddMax - smokeHeldTimer;
            smokeAdd = Mathf.Clamp(smokeAdd, 0f, smokeAddMax);
            smokeNeed += smokeAdd * Time.deltaTime;
        }
            
        else
        {
            
            smokeHeldTimer -= smokeCooldown * Time.deltaTime;
            
        }
        
        smokeHeldTimer = Mathf.Clamp(smokeHeldTimer, 0f, smokeMaxCooldown);
        
    }
    

    private void FixedUpdate()
    {
        takeSmoke();
        needDecrease();
        
    }

    // ReSharper disable Unity.PerformanceAnalysis
    void needDecrease()
    {
        smokeNeed -= smokeDecrease;
        smokeNeed = Mathf.Clamp(smokeNeed, 0f, 100f);
    }
}
