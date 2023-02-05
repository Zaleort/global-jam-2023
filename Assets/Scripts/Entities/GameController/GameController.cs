using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    SpawnerManager spawnerManager;
    public void Attack(Lane lane)
    {
        switch (lane)
        {
            case Lane.Up:
                //
                break;
            case Lane.Down:
                //
                break;
            case Lane.Left:
                //
                break;
            case Lane.Right:
                //
                break;

        }
    }

    public void NewWave(int waveNumber)
    {
        // Show new wave message;
    }

    public void Death()
    {
        // Game Over
        spawnerManager.StopSpawners();
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }

    // Start is called before the first frame update
    void Start()
    {
        spawnerManager = this.GetComponentInChildren<SpawnerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
