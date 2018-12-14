using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullette : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.GetComponent<Health>().health -= 1;
            Destroy(gameObject);

        }


    }
}
