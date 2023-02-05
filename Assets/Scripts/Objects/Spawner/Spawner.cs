using SAP2D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float nextActionTime = 0.0f;
    public float period = 0.1f;
    public Transform Target;

    public Wave wave;
    public Lane lane;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime)
        {
            Debug.Log("Time");
            if (CheckEndOfWave())
            {
                Debug.Log("End of Wave");
                SendMessageUpwards("EndOfWave", wave.level);
                wave = null;
                nextActionTime += period;
                return;
            }

            nextActionTime += period;
            InstantiateFromPool();
        }
    }

    public void StartWave(Wave wave)
    {
        this.wave = wave.Clone();
    }

    public void StopWave()
    {
        this.wave = null;
    }

    public void InstantiateFromPool()
    {
        if (wave == null)
        {
            return;
        }

        int length = wave.enemyPool.Length;
        if (length == 0)
        {
            return;
        }

        GameObject enemyToInstantiate = wave.enemyPool[Random.Range(0, length - 1)].gameObject;
        Instantiate(enemyToInstantiate, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0), Quaternion.identity);
        enemyToInstantiate.GetComponent<SAP2DAgent>().setMovementSpeed(wave.baseSpeed);
        enemyToInstantiate.GetComponent<SAP2DAgent>().setTarget(Target);

        Debug.Log("Instantiated");
        wave.quantity--;
    }

    public bool CheckEndOfWave()
    {
        if (wave == null) return false;
        return wave.quantity == 0;
    }
}
