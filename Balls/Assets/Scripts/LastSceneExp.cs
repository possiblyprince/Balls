using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastSceneExp : MonoBehaviour
{
    [SerializeField] GameObject explosionPartiicle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            Destroy(collision.gameObject);
            Instantiate(explosionPartiicle, transform.position, transform.rotation);
        }
    }
}
