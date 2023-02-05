using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
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
        SceneManager.LoadScene(2);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
