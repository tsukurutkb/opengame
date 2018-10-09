using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(transform.up,1,Space.World);
		//this.transform.rotation*=Quaternion.AngleAxis(1,-this.transform.up);
		Debug.DrawRay(this.transform.position,this.transform.up);
	}
}
