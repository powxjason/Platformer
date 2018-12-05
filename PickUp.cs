using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {
    public float coolDown = 2f;
    float counter;
    public GameObject[] weapons;
    public GameObject weaponsHere;
    bool caught;
    
     private void Start()
     {
        weaponsHere = weapons [Random.Range (0, weapons.Length)];
        GetComponent<SpriteRenderer>().sprite = weaponsHere.GetComponent<SpriteRenderer>().sprite;
     }

    void Update()
    {
        if (caught)
            counter += Time.deltaTime;
        if (counter >= coolDown)
        {
            caught = false;
            counter = 0;
            weaponsHere = weapons [Random.Range (0, weapons.Length)];
            GetComponent<SpriteRenderer>().sprite = weaponsHere.GetComponent<SpriteRenderer>().sprite;
        }
    }

     void OnTriggerEnter2D(Collider2D collision)
     {
        if (gameObject.tag == "Player")
        {
            gameObject.transform.Find("WeaponSlot").GetComponent<WeaponManager>().UpdateWeapon(weaponsHere);
            caught = true;
            GetComponent<SpriteRenderer>().sprite = null;
        }
     }

}
