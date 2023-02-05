using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Player[] players;
    private float timeWhenAllowedNextShoot = 0f;
    private float timeBetweenShooting = RootConstants.RootCooldown;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfShouldShoot();   
    }

    void CheckIfShouldShoot()
    {
        if (timeWhenAllowedNextShoot <= Time.time)
        {
            DisableColliders();
            if (Input.GetKeyDown(KeyCode.W))
            {
                EnableCollider(KeyCode.W);
                timeWhenAllowedNextShoot = Time.time + timeBetweenShooting;
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                EnableCollider(KeyCode.UpArrow);
                timeWhenAllowedNextShoot = Time.time + timeBetweenShooting;
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                EnableCollider(KeyCode.A);
                timeWhenAllowedNextShoot = Time.time + timeBetweenShooting;
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                EnableCollider(KeyCode.LeftArrow);
                timeWhenAllowedNextShoot = Time.time + timeBetweenShooting;
            }
        }
    }

    void DisableColliders()
    {
        for (int i = 0; i < players.Length; i++)
        {
            players[i].DisableCollider();
        }
    }

    void EnableCollider(KeyCode key)
    {
        for (int i = 0; i < players.Length; i++)
        {
            if (players[i].key == key)
            {
                players[i].EnableCollider();
            }
        }
    }
}
