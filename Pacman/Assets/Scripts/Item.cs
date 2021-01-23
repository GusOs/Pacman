using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //Colision
    private Collider itemCollision;

    // Start is called before the first frame update
    void Start()
    {
        itemCollision = GetComponent<Collider>();
    }

    private void OnTriggerEnter2D(Collider2D itemCollision)
    {
        if (itemCollision.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
        }
    }
}
