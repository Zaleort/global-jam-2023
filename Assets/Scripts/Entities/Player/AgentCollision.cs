using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enemigo Destruido");
        Destroy(this.gameObject);
    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Enemigo Destruido");
        Destroy(this.gameObject);
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Enemigo Destruido");
        Destroy(this.gameObject);
    }
}
