using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loseCollision : MonoBehaviour
{
    [SerializeField] ParticleSystem one;
    [SerializeField] GameObject explosionPartiicle;

    void Start()
    {
        //one.SetActive(false); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            Destroy(collision.gameObject);
            // SceneManager.LoadScene("Death"); 
            //Use the top line to change the scene.
            //Time.timeScale = 0;
            Instantiate(explosionPartiicle, transform.position, transform.rotation);
            
        }
    }
}
