using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateKeyCard : MonoBehaviour
{
    public List<GameObject> keySpawnP = new List<GameObject>();
    public int random;
    public GameObject card;
    bool generated;
    bool added;
    public float timer = 5;

    void Update()
    {
        timer -= Time.deltaTime;

        create();
    }

    // Start is called before the first frame update
    void create()
    {
        if(timer<=0)
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
