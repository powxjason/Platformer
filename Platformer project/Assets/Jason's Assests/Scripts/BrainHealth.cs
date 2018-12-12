using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainHealth : MonoBehaviour {

    int health = 15;

    public GameObject healthBar;

	void Update () {
        healthBar.GetComponent<Transform>().localScale = new Vector3(health, 1, 1);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
