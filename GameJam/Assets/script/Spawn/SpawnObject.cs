using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField]
    GameObject[] objectsToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, objectsToSpawn.Length);
        GameObject instance = (GameObject)Instantiate(objectsToSpawn[rand], transform.position, Quaternion.identity);
        instance.transform.parent = transform;
    }


}
