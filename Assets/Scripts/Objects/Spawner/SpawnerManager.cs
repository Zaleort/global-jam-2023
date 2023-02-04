using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public Wave wave;
    public Spawner[] spawners;
    public int waveNumber = 1; 
    // Start is called before the first frame update

    public IEnumerator EndOfWave()
    {
        waveNumber++;
        SendMessageUpwards(GameControllerEvents.NewWave, waveNumber);

        yield return new WaitForSeconds(1);
        SetNewWaveToSpawners();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetNewWaveToSpawners()
    {
        Wave newWave = GetNewWave();
        for (int i = 0; i < spawners.Length; i++)
        {
            if (newWave.lanes.Contains(spawners[i].lane)) 
            {
                spawners[i].StartWave(newWave);
            }
        }
    }

    Wave GetNewWave()
    {
        if (waveNumber == 1)
        {
            return new Wave(new Lane[] { Lane.Left }, new Enemy[] { }, 20, 2f);
        }

        return null;
    }
}
