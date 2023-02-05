using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    BoxCollider2D boxCollider;
    SpriteRenderer spriteRenderer;
    public Sprite restSprite;
    public Sprite activeSprite;
    public KeyCode key;
    void Start()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        boxCollider = this.gameObject.GetComponent<BoxCollider2D>();
    }

    public void EnableCollider()
    {
        boxCollider.enabled = true;
        spriteRenderer.sprite = activeSprite;
    }

    public void DisableCollider()
    {
        boxCollider.enabled = false;
        spriteRenderer.sprite = restSprite;
    }
}
