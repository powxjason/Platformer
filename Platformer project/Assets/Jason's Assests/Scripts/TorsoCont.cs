using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorsoCont : MonoBehaviour {

    public int x;
    public int y;

	// Update is called once per frame
	void Update () {

        if (Input.GetKey("up"))
        {
            y = 1;
            Direction(x, y);
        }
        else if (Input.GetKey("down"))
        {
            y = -1;
            Direction(x, y);
        }
        else
        {
            y = 0;
            Direction(x, y);
        }

        if (Input.GetKey("left"))
        {
            x = -1;
            Direction(x, y);
        }
        else if (Input.GetKey("right"))
        {
            x = 1;
            Direction(x, y);
        }
        else
        {
            x = 0;
            Direction(x, y);
        }

     
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
        Debug.Log(F);
        GetComponent<TorsoAni>().Frame = F;
    }


}
