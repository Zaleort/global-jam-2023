using SAP2D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
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
    void FixedUpdate()
    {
        if (Time.time > nextActionTime)
        {
            if (CheckEndOfWave())
            {
                SendMessageUpwards("EndOfWave", lane);
                return;
            }

            nextActionTime += period;
            InstantiateFromPool();
        }
    }

    public void StartWave(Wave wave)
    {
        this.wave = wave;
    }

    public void InstantiateFromPool()
    {
        int length = wave.enemyPool.Length;
        GameObject enemyToInstantiate = wave.enemyPool[Random.Range(0, length - 1)].gameObject;
        Instantiate(enemyToInstantiate, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0), Quaternion.identity);
        enemyToInstantiate.GetComponent<SAP2DAgent>().setMovementSpeed(wave.baseSpeed);
        objectToSpawn.GetComponent<SAP2DAgent>().setTarget(Target);

        wave.quantity--;
    }

    public bool CheckEndOfWave()
    {
        return wave.quantity == 0;
    }
}
