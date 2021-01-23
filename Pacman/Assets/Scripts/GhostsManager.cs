using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostsManager : MonoBehaviour
{
    //Colision
    private Collider ghostCollision;

    // Start is called before the first frame update
    void Start()
    {
        ghostCollision = GetComponent<Collider>();
    }

    // Si el fantasma colisiona con el jugador, llama a gameover
    private void OnTriggerEnter2D(Collider2D ghostCollision)
    {
        if (ghostCollision.CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }
    }
}
