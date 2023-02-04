using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Collider2D player;
    private int health;
    private (int x, int y) position;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Enemigo Destruido");
        if (CheckRootOrNucleusCollision(col))
        {
            Destroy(this);
        }
    }

    bool CheckRootOrNucleusCollision(Collider2D collider)
    {
        Nucleus nucleus = collider.GetComponent<Nucleus>();
        Player player = collider.GetComponent<Player>();

        if (nucleus != null || player != null)
        {
            return true;
        }

        return false;
    }
}
