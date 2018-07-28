using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMap : MonoBehaviour
{
    //Variable
    public List<GameObject> EasyMap;
    public List<GameObject> MediumMap;
    public List<GameObject> HardMap;
    public GameObject Spawner;

    mapCounter MapCounter;

    private int passedRoomsCount;

    private int MEDIUM = 6;

    private int HARD = 9;

    // Use this for initialization
    void Start()
    {
        MapCounter = FindObjectOfType<mapCounter>();
        passedRoomsCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            MapCounter.passedRoomsCount++;

            if (MapCounter.passedRoomsCount < MEDIUM)
            {
                int rdm = Random.Range(0, EasyMap.Count);
                Debug.Log("easy"+rdm);
                Instantiate(EasyMap[rdm], Spawner.transform.position, Quaternion.identity);
            }
            else if (MapCounter.passedRoomsCount >= MEDIUM && MapCounter.passedRoomsCount < HARD)
            {
                int rdm = Random.Range(0, MediumMap.Count);
                Debug.Log("mwdium" + rdm);
                Instantiate(MediumMap[rdm], Spawner.transform.position, Quaternion.identity);
            }
            else if (MapCounter.passedRoomsCount >= HARD)
            {
                int rdm = Random.Range(0, HardMap.Count);
                Debug.Log("hard" + rdm);
                Instantiate(HardMap[rdm], Spawner.transform.position, Quaternion.identity);
            }
        }
    }
}
