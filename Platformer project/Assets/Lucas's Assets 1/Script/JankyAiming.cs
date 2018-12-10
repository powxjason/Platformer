using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JankyAiming : MonoBehaviour
{
    public float bulletLife;
    Vector3 AimAngle;
    public float bulletSpeed;
    public float fireSpeed;
    float timer = 0;
    public GameObject prefab;

    // Use this for initialization
    void Start()
    {
        AimAngle = new Vector3(0, 0, 0);
    }

    // change the vector2 in each if block, and it should, maybe work.
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow))
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
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
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
        if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow))
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
        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
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
        if (Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.LeftArrow))
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
        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
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
        if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.UpArrow))
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
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
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
        if (Input.GetButton("Fire1") && timer >= fireSpeed)
        {
            Debug.Log("Fire!");

            Shooting(AimAngle);


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
