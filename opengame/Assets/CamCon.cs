using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCon : MonoBehaviour {
    [SerializeField]
    GameObject player;
    private Vector3 offset;
    Vector3 targetcamPos;
	// Use this for initialization
	void Start () {
        offset = player.transform.position - transform.position;
	}
	
	// Update is called once per frame


    private void FixedUpdate()
    {
        targetcamPos = player.transform.position + offset;

        transform.position = targetcamPos;
        transform.LookAt(player.transform);
    }
}
