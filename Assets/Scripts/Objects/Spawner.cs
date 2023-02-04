using SAP2D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    private float nextActionTime = 0.0f;
    public float period = 0.1f;
    public float speed;
    public Transform Target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            Instantiate(objectToSpawn, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0), Quaternion.identity);
            objectToSpawn.GetComponent<SAP2DAgent>().setMovementSpeed(speed);
            objectToSpawn.GetComponent<SAP2DAgent>().setTarget(Target);
        }
    }
}
