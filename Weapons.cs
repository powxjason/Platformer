using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour {
    public enum Modes
    {
        melee, Straight
    }
    public Sprite sprite;
    public GameObject projectile;
    public float projectileSpeed;
    public float coolDown;
    public Vector3 tip;
    public Modes projectileMode;
    

    // Use this for initialization
    void Start () {
        
	}
	
	
}
