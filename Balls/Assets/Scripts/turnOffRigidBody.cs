using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOffRigidBody : MonoBehaviour
{

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    
    public void turnItOff()
    {
        Destroy(gameObject.GetComponent<Rigidbody2D>());
    }
}
