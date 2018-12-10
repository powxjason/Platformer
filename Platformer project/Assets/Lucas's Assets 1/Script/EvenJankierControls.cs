using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenJankierControls : MonoBehaviour {
    public float bulletLife;
    Vector3 AimAngle;
    public float bulletSpeed;
    public float fireSpeed;
    float timer = 0;
    public GameObject prefab;

    // Use this for initialization
    void Start ()
    {
        AimAngle = new Vector3(0, 0, 0);
	}
	
	// change the vector3 in each if block, and it should, maybe work.
	void Update ()
    {
        timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A))
        {
            //Aim Up
            Debug.Log("up");
            AimAngle = new Vector3(0, 1, 0);
            AimAngle.Normalize();
            if (Input.GetButton("Fire1") && timer >= fireSpeed)
            {
                Debug.Log("Fire!");

                Shooting(AimAngle);

            }

        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            //Aim Up and to the Right
            Debug.Log("UpRight");
            AimAngle = new Vector3(1, 1, 0);
            AimAngle.Normalize();
            if (Input.GetButton("Fire1") && timer >= fireSpeed)
            {
                Debug.Log("Fire!");

                Shooting(AimAngle);

            }

        }
        if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A))
        {
            //Aim Right
            Debug.Log("Right");
            AimAngle = new Vector3(1, 0, 0);
            AimAngle.Normalize();
            if (Input.GetButton("Fire1") && timer >= fireSpeed)
            {
                Debug.Log("Fire!");

                Shooting(AimAngle);

            }

        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            //Aim Down and to the Right
            Debug.Log("DownRight");
            AimAngle = new Vector3(1, -1, 0);
            AimAngle.Normalize();
            if (Input.GetButton("Fire1") && timer >= fireSpeed)
            {
                Debug.Log("Fire!");

                Shooting(AimAngle);

            }

        }
        if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A))
        {
            //Aim Down

            Debug.Log("Down");
            AimAngle = new Vector3(0, -1, 0);
            AimAngle.Normalize();
            if (Input.GetButton("Fire1") && timer >= fireSpeed)
            {
                Debug.Log("Fire!");

                Shooting(AimAngle);

            }
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            //Aim Down and to the left

            Debug.Log("DownLeft");
            AimAngle = new Vector3(-1, -1, 0);
            AimAngle.Normalize();
            if (Input.GetButton("Fire1") && timer >= fireSpeed)
            {
                Debug.Log("Fire!");

                Shooting(AimAngle);

            }

        }
        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W))
        {
            //Aim Left

            Debug.Log("Left");
            AimAngle = new Vector3(-1, 0, 0);
            AimAngle.Normalize();
            if (Input.GetButton("Fire1") && timer >= fireSpeed)
            {
                Debug.Log("Fire!");

                Shooting(AimAngle);

            }

        } 
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            //Aim Up and to the Left

            Debug.Log("UpLeft");
            AimAngle = new Vector3(-1, 1, 0);
            AimAngle.Normalize();
            if (Input.GetButton("Fire1") && timer >= fireSpeed)
            {
                Debug.Log("Fire!");

                Shooting(AimAngle);

            }
        }


        else
        {
            //Aim Right
            Debug.Log("Right");
            AimAngle = new Vector3(1, 0, 0);
            AimAngle.Normalize();

            if (Input.GetButton("Fire1") && timer >= fireSpeed)
            {

                Shooting(AimAngle);

            }

        }

    }
    void Shooting(Vector3 AimAngle)
    {
        Debug.Log("Fire!");

        timer = 0;
        GameObject bullet = (GameObject)Instantiate(prefab, transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().velocity = AimAngle.normalized * bulletSpeed;
        Destroy(bullet, bulletLife);
    }
}
