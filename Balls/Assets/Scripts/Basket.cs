using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    [SerializeField] float screenWidthUnit = 16f;

    void Update()
    {
        moveBasket();
    }

    private void moveBasket()
    {
        //for PC
        //Vector2 basketPosition = new Vector2(Mathf.Clamp
          //  (Input.mousePosition.x / Screen.width * screenWidthUnit, 0, 16), transform.position.y);
        //transform.position = basketPosition;
        
        //for Android
        Vector2 basketPosition = new Vector2(Mathf.Clamp
            (Input.acceleration.x / Screen.width * screenWidthUnit, 0, 16), transform.position.y);
        transform.position = basketPosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            Destroy(collision.gameObject);
            GetComponent<ScoreSystem>().increaseScore();
        }
    }
}
