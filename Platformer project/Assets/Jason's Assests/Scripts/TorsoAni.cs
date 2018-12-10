using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorsoAni : MonoBehaviour {

    public int Frame;
    

    public int Direct;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        GetComponent<Animator>().SetInteger("Frame", Frame);
      

        if(Frame == 1 || Frame == 5)
        {
            Direct = 0;
        }else if (Frame <= 5 && Frame >= 2)
        {
            Direct = 1;
        }else if (Frame > 6)
        {
            Direct = -1;
        }


	}
}
