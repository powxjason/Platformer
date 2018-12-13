using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttach : MonoBehaviour {

	public GameObject Player;

     void OnTriggerEnter2D(Collider2D collision)
     {
        if(collision.gameObject == Player)
        {
            Player.transform.parent = transform;
        }
     }
     void OnTriggerExit2D(Collider2D collision)
     {
        if(collision.gameObject == Player)
        {
            Player.transform.parent = null;
        }
     }
}
