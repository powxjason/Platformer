using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegsAni : MonoBehaviour {

    public float X;
    public float Y;

    GameObject Player;

    public float PlayerVelocityX;
    public float PlayerVelocityY;

    public int Direct;

    int RunModify;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {

        X = Input.GetAxisRaw("Horizontal");
        Y = Input.GetAxisRaw("Vertical");

        PlayerVelocityX = Player.GetComponent<Rigidbody2D>().velocity.x;
        PlayerVelocityY = Player.GetComponent<Rigidbody2D>().velocity.y;

        Direct = Player.GetComponent<TorsoAni>().Direct;

        if (Direct == -1)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            RunModify = -1;

        }else
        {
            GetComponent<SpriteRenderer>().flipX = false;
            RunModify = 1;
        }

        if(PlayerVelocityX >= 0.5)
        {
            GetComponent<Animator>().SetInteger("Move", 1 * RunModify);
        }else if(PlayerVelocityX > -0.5 && PlayerVelocityX < 0.5)
        {
            if(Direct == 0)
            {
                GetComponent<Animator>().SetBool("Middle", true);
                GetComponent<Animator>().SetInteger("Move", 0);
            }
            else
            {
                GetComponent<Animator>().SetBool("Middle", false);
                GetComponent<Animator>().SetInteger("Move", 0);
            }
        }
        else
        {
            GetComponent<Animator>().SetInteger("Move", -1 * RunModify);
        } 
        



    }
}
