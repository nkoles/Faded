using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float gridSize = 1f;
    private GameObject player;
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    public KeyCode moveRight = KeyCode.D;
    public KeyCode moveLeft = KeyCode.A;
    private BoxCollider2D boxCollider;
    public LayerMask wall;

    private bool canMoveUp = true;
    private bool canMoveDown = true;
    private bool canMoveRight = true;
    private bool canMoveLeft = true;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<GameObject>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKeyDown(moveUp) && canMoveUp)
        {
            pos.y += gridSize;
        }
        if (Input.GetKeyDown(moveDown) && canMoveDown)
        {
            pos.y -= gridSize;
        }
        if (Input.GetKeyDown(moveRight) && canMoveRight)
        {
            pos.x += gridSize;
        }
        if (Input.GetKeyDown(moveLeft) && canMoveLeft)
        {
            pos.x -= gridSize;
        }
        transform.position = pos;
        
        checkForWalls();
    }

    void checkForWalls()
    {
        var upHit = Physics2D.Raycast(transform.position, Vector2.up, 0.75f, wall);
        var downHit = Physics2D.Raycast(transform.position, Vector2.down, 0.75f, wall);
        var rightHit = Physics2D.Raycast(transform.position, Vector2.right, 0.75f, wall);
        var leftHit = Physics2D.Raycast(transform.position, Vector2.left, 0.75f, wall);
        
        if(upHit.collider != null && upHit.collider.isTrigger == false)
            canMoveUp = false;
        else
            canMoveUp = true;
        

        if (downHit.collider != null && downHit.collider.isTrigger == false)
            canMoveDown = false;
        else
            canMoveDown = true;
        

        if (rightHit.collider != null && rightHit.collider.isTrigger == false)
            canMoveRight = false;
        else
            canMoveRight = true;
        

        if (leftHit.collider != null && leftHit.collider.isTrigger == false)
            canMoveLeft = false;
        else
            canMoveLeft = true;
        
    }
}
