using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOverlapObjects : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == 3 && other.gameObject.GetComponent<CircleCollider2D>() == true)
        {
            Destroy(other.gameObject);
        }
    }
}
