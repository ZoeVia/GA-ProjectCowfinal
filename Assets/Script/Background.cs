using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {
    public GameObject Ciel;
    public float startX;
    public float y;
    public float width;
    private GameObject instance1;
    private GameObject instance2;

	// Use this for initialization
	void Start () {
        instance1 = Instantiate(Ciel, new Vector3(startX, y, 0 ),Quaternion.identity);
        instance2 = Instantiate(Ciel, new Vector3(startX + width, y, 0),Quaternion.identity);
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Camera.main.transform.position.x > instance1.transform.position.x)
        {
            instance2.transform.position = new Vector3(instance1.transform.position.x + width, y, 0);
        }
        if (Camera.main.transform.position.x > instance2.transform.position.x)
        {
            instance1.transform.position = new Vector3(instance2.transform.position.x + width, y, 0);
        }
    }
}
