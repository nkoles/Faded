using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToArray : MonoBehaviour
{
    public CreateKeyCard cardManager;

    // Start is called before the first frame update
    void Start()
    {
        cardManager = GameObject.FindObjectOfType<CreateKeyCard>();

        cardManager.keySpawnP.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
