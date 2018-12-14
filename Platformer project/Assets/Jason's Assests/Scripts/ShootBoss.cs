using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBoss : MonoBehaviour {

    public bool Fighting = false;

    public AudioClip soundToPlay;
    public float bulletLife;
    public float bulletSpeed;
    public float fireSpeed;
    float timer = 0;
    public GameObject prefab;
    public GameObject Player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
         
        if (Fighting && timer > fireSpeed)
        {
            timer = 0;

            //Vector3 mousePosition = Input.mousePosition;
            //Debug.Log(mousePosition);
            //mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            //mousePosition.z = 0;
            //Debug.Log(mousePosition);
            Vector3 shootDir = Player.transform.position - transform.position;  // mousePosition - transform.position;
            shootDir.Normalize();
            shootDir *= bulletSpeed;
            //destination - start pos.
            
            GameObject bullet = (GameObject)Instantiate(prefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir.normalized * bulletSpeed;
            Destroy(bullet, bulletLife);
            //Camera.main.GetComponent<AudioSource>().PlayOneShot(soundToPlay);

        }
	}
}
