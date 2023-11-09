using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WaveManager : MonoBehaviour
{
    public static WaveManager instance;
    public List<WaveSpawn> waves;
    public UnityEvent onChanged;
   
    void Awake()
    {
        if(instance == null){
            instance = this;
        }
        else{
            Debug.LogError("Duplicated Waves Manager");
        }
        
    }

    public void addWave(WaveSpawn wave){
        waves.Add(wave);
        onChanged.Invoke();
        
    }

    public void removeWave(WaveSpawn wave){
        waves.Remove(wave);
        onChanged.Invoke();
    }

}
