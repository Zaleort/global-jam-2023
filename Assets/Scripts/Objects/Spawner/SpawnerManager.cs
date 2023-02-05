using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public Wave wave;
    public Spawner[] spawners;
    public Enemy[] enemies;
    public int waveNumber = 1; 
    // Start is called before the first frame update

    public IEnumerator EndOfWave(int level)
    {
        if (level < waveNumber)
        {
            yield break;
        }

        waveNumber++;
        Debug.Log("End of Wave");
        Debug.Log("Wave number: " + waveNumber);
        SendMessageUpwards(GameControllerEvents.NewWave, waveNumber);

        yield return new WaitForSeconds(1);
        SetNewWaveToSpawners();
    }
    void Start()
    {
        SetNewWaveToSpawners();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void SetNewWaveToSpawners()
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

    public void StopSpawners()
    {
        for (int i = 0; i < spawners.Length; i++)
        {
            spawners[i].StopWave();
        }
    }

    Wave GetNewWave()
    {
        if (waveNumber == 1)
        {
            return new Wave(waveNumber, new Lane[] { Lane.Left, Lane.Down }, enemies, 10, 2f);
        }

        if (waveNumber == 2)
        {
            return new Wave(waveNumber, new Lane[] { Lane.Left, Lane.Down, Lane.Right }, enemies, 25, 2f);
        }

        if (waveNumber == 3)
        {
            return new Wave(waveNumber, new Lane[] { Lane.Left, Lane.Down, Lane.Right, Lane.Up }, enemies, 30, 2.25f);
        }

        if (waveNumber == 4)
        {
            return new Wave(waveNumber, new Lane[] { Lane.Left, Lane.Down, Lane.Right, Lane.Up }, enemies, 30, 2.5f);
        }

        if (waveNumber > 5)
        {
            float speed = 2 + (0.15f * waveNumber);
            int enemiesNumber = 20 + waveNumber * 2;
            return new Wave(waveNumber, new Lane[] { Lane.Left, Lane.Down, Lane.Right, Lane.Up }, enemies, enemiesNumber, speed);
        }

        return null;
    }
}
