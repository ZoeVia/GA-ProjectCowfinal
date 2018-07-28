using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThisTime : MonoBehaviour {
    public float TempsPourDetruireRoom;
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, TempsPourDetruireRoom);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
