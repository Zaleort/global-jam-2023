using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    SpriteRenderer spriteRenderer;

    private float timeWhenAllowedNextShoot = 0f;
    private float timeBetweenShooting = RootConstants.RootCooldown;
    public KeyCode key;
    void Start()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfShouldShoot();

    }

    private void EnableCollider()
    {
        boxCollider.enabled = true;
        spriteRenderer.enabled = true;
    }

    private void DisableCollider()
    {
        boxCollider.enabled = false;
        spriteRenderer.enabled = false;
    }

    void CheckIfShouldShoot()
    {
        if (timeWhenAllowedNextShoot <= Time.time)
        {
            DisableCollider();
            if (Input.GetKeyDown(key))
            {
                EnableCollider();
                timeWhenAllowedNextShoot = Time.time + timeBetweenShooting;
            }
        }
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

    IEnumerator Attack()
    {
        boxCollider.enabled = true;
        yield return new WaitForSeconds(1f);
    }
}
