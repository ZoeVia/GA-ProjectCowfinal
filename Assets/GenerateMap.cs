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

    private int passedRoomsCount;

    private int MEDIUM = 6;

    private int HARD = 9;

    // Use this for initialization
    void Start()
    {
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
            passedRoomsCount++;
            if (passedRoomsCount < MEDIUM)
            {
                int rdm = Random.Range(0, EasyMap.Count - 1);
                Debug.Log(rdm);
                Instantiate(EasyMap[rdm], Spawner.transform.position, Quaternion.identity);
            }
            else if (passedRoomsCount >= MEDIUM && passedRoomsCount < HARD)
            {
                int rdm = Random.Range(0, MediumMap.Count - 1);
                Debug.Log(rdm);
                Instantiate(MediumMap[rdm], Spawner.transform.position, Quaternion.identity);
            }
            else if (passedRoomsCount >= HARD)
            {
                int rdm = Random.Range(0, HardMap.Count - 1);
                Debug.Log(rdm);
                Instantiate(HardMap[rdm], Spawner.transform.position, Quaternion.identity);
            }
        }
    }
}
