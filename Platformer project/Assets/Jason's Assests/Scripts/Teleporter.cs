using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {

    public Vector3 CameraTele;
    public GameObject Camera;
    public GameObject PlayerTeleMark;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.GetComponent<Transform>().position = PlayerTeleMark.GetComponent<Transform>().position;
            Camera.GetComponent<Transform>().position = CameraTele;
        }


    }
}
