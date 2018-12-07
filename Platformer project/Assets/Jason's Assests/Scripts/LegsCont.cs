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

            if (Input.GetButton("a"))
            {
                X = -1;
            }
            else if (Input.GetButton("d"))
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
