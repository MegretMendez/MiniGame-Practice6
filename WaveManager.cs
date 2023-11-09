using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WaveManager : MonoBehaviour
{
    public static WaveManager instance;   // A static reference to the WaveManager instance.
    public List<WaveSpawn> waves;         // A list to store information about different waves.
    public UnityEvent onChanged;           // A Unity Event to trigger when waves are added or removed.

    void Awake()
    {
        // This function is called when the script is loaded or initialized.

        if (instance == null)
        {
            instance = this;  // If there's no existing instance, set this as the reference.
        }
        else
        {
            Debug.LogError("Duplicated Waves Manager");  // Log an error if there's more than one instance.
        }
    }

    public void addWave(WaveSpawn wave)
    {
        // This function is used to add a new wave to the list.

        waves.Add(wave);  // Add the new wave to the list.
        onChanged.Invoke();  // Trigger the onChanged event to notify other scripts that a change has occurred.
    }

    public void removeWave(WaveSpawn wave)
    {
        // This function is used to remove a wave from the list.

        waves.Remove(wave);  // Remove the specified wave from the list.
        onChanged.Invoke();  // Trigger the onChanged event to notify other scripts of the change.
    }
}
