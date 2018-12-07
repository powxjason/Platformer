using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JankyAiming : MonoBehaviour {
    public float bulletLife;
    Vector2 AimAngle;
    public float bulletSpeed;
    public float fireSpeed;
    float timer = 0;
    public GameObject prefab;

    // Use this for initialization
    void Start () {
        AimAngle = new Vector2(0, 0);
	}
	
	// change the vector2 in each if block, and it should, maybe work.
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Aim Up
            Debug.Log("up");


        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Aim Right
            Debug.Log("Right");


        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //Aim Left

            Debug.Log("Left");

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Aim Down

            Debug.Log("Down");

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Aim Up and to the Right
            Debug.Log("UpRight");


        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //Aim Up and to the Left

            Debug.Log("UpLeft");

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //Aim Down and to the left

            Debug.Log("DownLeft");

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Aim Down and to the Right
            Debug.Log("DownRight");

        }
        if (Input.GetButton("Fire1") && timer > fireSpeed)
        {
            Debug.Log("Fire!");

            timer = 0;
            GameObject bullet = (GameObject)Instantiate(prefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = AimAngle * bulletSpeed;
            Destroy(bullet, bulletLife);


        }

    }
}
