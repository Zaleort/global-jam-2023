using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float timeSinceLastAttack = RootConstants.RootCooldown;
    // Start is called before the first frame update
    public BoxCollider2D m_Collider;
    SpriteRenderer spriteRenderer;

    private float timeWhenAllowedNextShoot = 0f;
    private float timeBetweenShooting = 1f;
    void Start()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        m_Collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        checkIfShouldShoot();

    }

    private void Ataque()
    {
        if (m_Collider.enabled)
        {
            spriteRenderer.enabled = false;
            m_Collider.enabled = false;

        }
        else
        {
            spriteRenderer.enabled = true;
            m_Collider.enabled = true;
        }
    }

    void checkIfShouldShoot()
    {
        if (timeWhenAllowedNextShoot <= Time.time)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Ataque();
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
        m_Collider.enabled = true;
        yield return new WaitForSeconds(1f);
    }
}
