using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGenerationScript : MonoBehaviour
{
    public List<GameObject> roomListLeft = new List<GameObject>();
    public List<GameObject> roomListRight = new List<GameObject>();
    public List<GameObject> roomListUp = new List<GameObject>();
    public List<GameObject> roomListDown = new List<GameObject>();

    public int spawnDir;
    public bool spawned;

    void Update()
    {
        Invoke("generate", 0.1f);
    }

    void generate()
    {
        int random;

        if(spawned == false)
        {
            switch(spawnDir)
            {
                    case(1):
                    random = (int)Random.Range(0, 3);
                    Instantiate(roomListRight[random], transform.position, roomListRight[random].transform.rotation);
                    break;

                    case(2):
                    random = (int)Random.Range(0, 3);
                    Instantiate(roomListLeft[random], transform.position, roomListLeft[random].transform.rotation);
                    break;

                    case(3):
                    random = (int)Random.Range(0, 3);
                    Instantiate(roomListDown[random], transform.position, roomListDown[random].transform.rotation);
                    break;

                    case(4):
                    random = (int)Random.Range(0, 3);
                    Instantiate(roomListUp[random], transform.position, roomListUp[random].transform.rotation);
                    break;
            }

            spawned = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("SpawnP") && other.GetComponent<RoomGenerationScript>().spawned == true)
        {
            Destroy(gameObject);
        }
    }
}
