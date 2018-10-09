using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCon : MonoBehaviour {

    public GameObject player;
	// Use this for initialization

	
	// Update is called once per frame


    private void FixedUpdate()
    {
        try{
        transform.position=player.transform.position;
        transform.rotation=player.transform.rotation;
        }catch{

        }
        }
}
