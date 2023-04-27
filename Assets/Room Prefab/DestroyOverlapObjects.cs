using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Room") && other.gameObject.GetComponent<CircleCollider2D>() == true)
        {
            Destroy(gameObject);
        }
    }
}
