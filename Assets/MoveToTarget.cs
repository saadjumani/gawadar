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
		
	}
}
