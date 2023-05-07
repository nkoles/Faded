using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOverlapObjects : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "SpawnP")
        {
            Destroy(other.gameObject);
        }
    }
}
