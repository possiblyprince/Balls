using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loseCollision : MonoBehaviour
{
    [SerializeField] GameObject explosionPartiicle;
    [SerializeField] float delayTime = 3f;
    [SerializeField] Canvas gameOverCanvas;
    [SerializeField] Canvas pausePlay;

    void Start()
    {
        gameOverCanvas.enabled = false; 
    }


    private void LoadNextScene()
    {
        SceneManager.LoadScene(2);
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
            GetComponent<AudioSource>().Play();
            gameOverCanvas.enabled = true;
            pausePlay.enabled = false;
        }
        

    }
}
