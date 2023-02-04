using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float timeSinceLastAttack = RootConstants.RootCooldown;
    // Start is called before the first frame update
    public BoxCollider2D m_Collider;
    void Start()
    {
        m_Collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeSinceLastAttack < RootConstants.RootCooldown)
        {
            Debug.Log("UP");
            m_Collider.enabled = true;
            timeSinceLastAttack = 0f;
            return;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            m_Collider.enabled = true;
            SendMessageUpwards(GameControllerEvents.Attack, Lane.Up);
            timeSinceLastAttack = 0f;
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            SendMessageUpwards(GameControllerEvents.Attack, Lane.Down);
            timeSinceLastAttack = 0f;
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            SendMessageUpwards(GameControllerEvents.Attack, Lane.Left);
            timeSinceLastAttack = 0f;
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            SendMessageUpwards(GameControllerEvents.Attack, Lane.Right);
            timeSinceLastAttack = 0f;
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

}
