using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Uchara : NetworkBehaviour{

	// Use this for initialization
	private PlayerCon pcontroller;

		void Start () {
			pcontroller=GetComponent<PlayerCon>();
		}
	
	void Update () {
		if (!isLocalPlayer) {
			return;
		}
	}
}
