using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            SendMessageUpwards("attack", 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            SendMessageUpwards("attack", 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            SendMessageUpwards("attack", 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            SendMessageUpwards("attack", 0);
        }
    }


}
