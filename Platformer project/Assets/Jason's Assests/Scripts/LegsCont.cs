using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegsCont : MonoBehaviour {

    public bool InUse = true;
    public float X;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (InUse)
        {

            if (Input.GetKey(KeyCode.A))
            {
                X = -1;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                X = 1;
            }
            else
            {
                X = 0;
            }
        }

        GetComponent<LegsAni>().X = X;
	}
}
