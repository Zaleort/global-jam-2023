using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float timeSinceLastAttack = RootConstants.RootCooldown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeSinceLastAttack < RootConstants.RootCooldown)
        {
            timeSinceLastAttack += Time.deltaTime;
            return;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            SendMessageUpwards(GameControllerEvents.Attack, Lane.Up);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            SendMessageUpwards(GameControllerEvents.Attack, Lane.Down);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            SendMessageUpwards(GameControllerEvents.Attack, Lane.Left);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            SendMessageUpwards(GameControllerEvents.Attack, Lane.Right);
        }

        timeSinceLastAttack = 0f;
    }


}
