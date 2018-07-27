using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_2 : MonoBehaviour {
    public float width;
    public Camera mainCamera;
    public GameObject instance1;
    public GameObject instance2;
    

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (mainCamera.transform.position.x > instance1.transform.position.x)
        {
            instance2.transform.SetPositionAndRotation(new Vector3(instance1.transform.position.x + width, instance2.transform.position.y, instance2.transform.position.z),Quaternion.identity);
        }
        if (mainCamera.transform.position.x > instance2.transform.position.x)
        {
            instance1.transform.SetPositionAndRotation(new Vector3(instance2.transform.position.x + width, instance1.transform.position.y, instance1.transform.position.z), Quaternion.identity);
        }
    }


}
