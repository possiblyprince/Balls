using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    [SerializeField] float screenWidthUnit = 16f;
    [SerializeField] float moveSpeed = 40f;
    Rigidbody2D rig;
    float dirX;
   
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveBasket();
    }

    private void moveBasket()
    {

        //for Android ------------------------------------------
        dirX = Input.acceleration.x * moveSpeed;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, 0, screenWidthUnit), transform.position.y);
       
            //Vector2 basketPosition = new Vector2(Mathf.Clamp
              //(Input.acceleration.x / Screen.width * screenWidthUnit, 0, 16), transform.position.y);
           //transform.position = basketPosition;


        //-----------------------------------------------------------//
        //for PC
        //Vector2 basketPosition = new Vector2(Mathf.Clamp
        //  (Input.mousePosition.x / Screen.width * screenWidthUnit, 0, 16), transform.position.y);
        //transform.position = basketPosition;

    }

    private void FixedUpdate()
    {
        rig.velocity = new Vector2(dirX, 0f);
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
