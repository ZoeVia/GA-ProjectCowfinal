using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMap : MonoBehaviour {
    //Variable
    public List<GameObject> EasyMap;
    public List<GameObject> MediumMap;
    public List<GameObject> HardMap;
    public GameObject Spawner;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            int rdm = Random.Range(0, EasyMap.Count - 1);
            Debug.Log(rdm);
            Instantiate(EasyMap[rdm], Spawner.transform.position, Quaternion.identity);
        }
    }
}
