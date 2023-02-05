using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    BoxCollider2D boxCollider;
    SpriteRenderer spriteRenderer;
    public KeyCode key;
    void Start()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        boxCollider = this.gameObject.GetComponent<BoxCollider2D>();
    }

    public void EnableCollider()
    {
        boxCollider.enabled = true;
        spriteRenderer.enabled = true;
    }

    public void DisableCollider()
    {
        boxCollider.enabled = false;
        spriteRenderer.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Enemigo Destruido");
        Destroy(this);

    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Enemigo Destruido");
        Destroy(this);
    }
}
