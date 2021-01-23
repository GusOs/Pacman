using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //Colision
    private Collider itemCollision;

    // Audio del item al colisionar
    public Sound ItemCatch;

    // Start is called before the first frame update
    void Start()
    {
        itemCollision = GetComponent<Collider>();
    }

    // Si el item colisiona con el jugador, reproduce un audio y active a false
    private void OnTriggerEnter2D(Collider2D itemCollision)
    {
        if (itemCollision.CompareTag("Player"))
        {
            AudioManager.Instance.PlaySound(ItemCatch);
            this.gameObject.SetActive(false);
        }
    }
}
