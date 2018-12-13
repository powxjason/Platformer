using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainHealth : MonoBehaviour {

    int health = 15;

    public GameObject healthBar;

	void Update () {
        if (health >= 0)
        {
            healthBar.GetComponent<Transform>().localScale = new Vector3(health, 0.5f , 1);
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.gameObject.tag == "Bullet")
        {
            health -= 1;
            Destroy(collision.gameObject);
        }

    }
}
