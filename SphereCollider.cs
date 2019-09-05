using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // When the cube collides with the sphere, it's going to stop and slow down
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Sphere Collider")
        {
            collision.gameObject.SendMessage("Apply Slow");
        }
    }
}
