using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobspawn : MonoBehaviour
{
    public float SpawnRate = 10f;
    public float nextSpawn = 0f;
    public GameObject MobPrefab;
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + SpawnRate;
            Instantiate(MobPrefab, transform.position, transform.rotation);
        }
    }
}
