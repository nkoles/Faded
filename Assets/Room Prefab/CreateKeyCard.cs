using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateKeyCard : MonoBehaviour
{
    public List<GameObject> keySpawnP = new List<GameObject>();
    private int random;
    public GameObject card;
    bool generated;

    void Update()
    {
        keySpawnP.Add(GameObject.FindWithTag("keySpawn"));
        create();
    }

    // Start is called before the first frame update
    void create()
    {
        if(keySpawnP.Count>=6)
        {
            if(!generated)
            {
                random = (int)Random.Range(0, keySpawnP.Count);

                Instantiate(card, keySpawnP[random].transform);

                generated = true;
            }
        }
    }
}
