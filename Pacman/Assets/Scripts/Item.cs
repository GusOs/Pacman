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

    private void OnTriggerEnter(Collider itemCollision)
    {
        if (itemCollision.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
        }
    }
}
