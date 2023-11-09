using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawn : MonoBehaviour
{
    public GameObject prefab;

    public float startTime;

    public float endTime;

    public float spawnRate;

    // Start is called before the first frame update
    void Start()
    {
        WaveManager.instance.addWave(this);
        InvokeRepeating("Spawn", startTime, spawnRate);
        Invoke("EndSpawner", endTime);
    }

    void Spawn(){
        Instantiate(prefab, transform.position, transform.rotation);
    }

    void EndSpawner(){
        WaveManager.instance.removeWave(this);
        CancelInvoke();
    }
}
