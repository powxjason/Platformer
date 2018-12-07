using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorsoCont : MonoBehaviour {

    int x;
    int y;

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("up"))
        {
            y = 1;
        }else if (Input.GetKey("down"))
        {
            y = -1;
        }
        else
        {
            y = 0;
        }

        if (Input.GetKey("left"))
        {
            x = -1;
        }
        else if (Input.GetKey("right"))
        {
            x = 1;
        }
        else
        {
            x = 0;
        }

        Direction(x, y);



    }

    public void Direction(int x, int y)
    {
        if (x == 1)
        {
            if(y == 1)
            {
                Frame(2);
            }else if (y == 0)
            {
                Frame(3);
            }
            else
            {
                Frame(4);
            }

        }else if (x == -1){

            if (y == 1)
            {
                Frame(8);
            }
            else if (y == 0)
            {
                Frame(7);
            }
            else
            {
                Frame(6);
            }

        }
        else
        {
            if (y == 1)
            {
                Frame(1);
            }
            else if (y == 0)
            {
               
            }
            else
            {
                Frame(5);
            }

        }


    }

    public void Frame(int F)
    {

    }


}
