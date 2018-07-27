using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scriptesoucoupe : MonoBehaviour {
    public Camera camera;
    public AudioSource asource;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position+new Vector3(0.06f, 0, 0);
        
        
	}
}
