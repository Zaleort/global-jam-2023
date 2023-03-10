using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nucleus : MonoBehaviour
{
    private int health = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Enemy enemy = col.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            health--;
            CheckIfDead();
        }
    }

    void CheckIfDead()
    {
        if (health <= 0)
        {
            SendMessageUpwards(GameControllerEvents.Death);
        }
    }
}
