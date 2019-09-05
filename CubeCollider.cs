using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // When the sphere collides with the cube, it's going to stop and slow down
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Cube Collider")
        {
            collision.gameObject.SendMessage("Apply Slow");
        }
    }

}
