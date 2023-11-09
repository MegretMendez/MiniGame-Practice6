using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawn : MonoBehaviour
{
    public GameObject prefab;     // The GameObject to be spawned by this wave.
    public float startTime;       // The time when the wave starts spawning.
    public float endTime;         // The time when the wave stops spawning.
    public float spawnRate;       // The rate at which the objects are spawned.

    // Start is called before the first frame update
    void Start()
    {
        // This function is called before the first frame update.

        // Add this wave to the WaveManager, so it can keep track of active waves.
        WaveManager.instance.addWave(this);

        // Invoke the "Spawn" function repeatedly, starting after "startTime" seconds and repeating at "spawnRate" intervals.
        InvokeRepeating("Spawn", startTime, spawnRate);

        // Invoke the "EndSpawner" function after "endTime" seconds to end this wave spawner.
        Invoke("EndSpawner", endTime);
    }

    void Spawn()
    {
        // This function is responsible for spawning objects.

        // Instantiate the "prefab" GameObject at the position and rotation of this spawner.
        Instantiate(prefab, transform.position, transform.rotation);
    }

    void EndSpawner()
    {
        // This function is called when the wave should end.

        // Remove this wave from the WaveManager, indicating that it's no longer active.
        WaveManager.instance.removeWave(this);

        // Cancel any further invocations, stopping the "Spawn" function and preventing any more spawns.
        CancelInvoke();
    }
}
