using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenJankierControls : MonoBehaviour {
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
        if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A))
        {
            //Aim Up
            Debug.Log("up");


        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            //Aim Up and to the Right
            Debug.Log("UpRight");


        }
        if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A))
        {
            //Aim Right
            Debug.Log("Right");


        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            //Aim Down and to the Right
            Debug.Log("DownRight");

        }
        if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A))
        {
            //Aim Down

            Debug.Log("Down");

        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            //Aim Down and to the left

            Debug.Log("DownLeft");

        }
        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W))
        {
            //Aim Left

            Debug.Log("Left");

        } 
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            //Aim Up and to the Left

            Debug.Log("UpLeft");

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
