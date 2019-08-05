using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float delay = 0.85f;
    public GameObject carPrefab;
    private float nextTimeToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            spawnCar();
            nextTimeToSpawn = delay + Time.time;
        }
        
    }
    void spawnCar()
    {
        Instantiate(carPrefab, transform.position, transform.rotation);
    }
}
