using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour {

    public GameObject target;
    Vector3 position;       //[x,yz]
    // Use this for initialization
    void Start () {
        position = target.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		//When script is attached to an object, it must do the following things
        //Make sure that the object is pointing towards the target
        //Move the object towards the target at a constant speed.
        //When object touches the target, stop the object from moving.
	}
}
