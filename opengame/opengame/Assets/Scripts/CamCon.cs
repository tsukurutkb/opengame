using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCon : MonoBehaviour {

    public GameObject player;
    private float offset;
    Vector3 targetcamPos;
    Vector3 cameravec;
	// Use this for initialization
	void Start () {

        offset = (player.transform.position - transform.position).magnitude;
	}
	
	// Update is called once per frame


    private void FixedUpdate()
    {
        transform.position=player.transform.position;
        transform.rotation=player.transform.rotation;

        }
}
