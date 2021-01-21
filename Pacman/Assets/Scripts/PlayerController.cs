using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Velocidad del jugador
    public float speed = 2.0f;

    private Vector2 direction = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        Move();
    }

    //Comprobar inputs
    void CheckInput()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = Vector2.left;

        } else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = Vector2.right;

        } else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            direction = Vector2.up;

        } else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = Vector2.down;
        }
    }

    //Movimiento del jugador
    void Move()
    {
        transform.position += (Vector3)(direction * speed) * Time.deltaTime;
    }
}
