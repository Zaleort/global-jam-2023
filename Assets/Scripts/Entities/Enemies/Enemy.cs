using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int health;

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (CheckRootOrNucleusCollision(col))
        {
            Debug.Log("Enemigo Destruido");
            Destroy(this.gameObject);
        }
    }

    public void OnCollisionStay2D(Collision2D col)
    {
        if (CheckRootOrNucleusCollision(col))
        {
            Debug.Log("Enemigo Destruido");
            Destroy(this.gameObject);
        }
    }

    public void OnCollisionExit2D(Collision2D col)
    {
        if (CheckRootOrNucleusCollision(col))
        {
            Debug.Log("Enemigo Destruido");
            Destroy(this.gameObject);
        }
    }

    bool CheckRootOrNucleusCollision(Collision2D collision)
    {
        Nucleus nucleus = collision.gameObject.GetComponent<Nucleus>();
        Player player = collision.gameObject.GetComponent<Player>();

        Debug.Log(collision.ToString());
        if (nucleus != null || player != null)
        {
            return true;
        }

        return false;
    }
}
