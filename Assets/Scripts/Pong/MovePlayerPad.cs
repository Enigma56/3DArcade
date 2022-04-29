using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerPad : MonoBehaviour
{
    public float paddleSpeed;
    // Update is called once per frame
    void Update()
    {
        movePaddles();
    }

    void movePaddles()
    {
        //float translationAxis = Input.GetAxis("Vertical");
        
        if (gameObject.tag.Equals("Paddle1"))
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(0,  paddleSpeed * Time.deltaTime, 0);
            }
            
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0, -paddleSpeed * Time.deltaTime, 0);
            }
        }
        
        if (gameObject.tag.Equals("Paddle2"))
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0,  paddleSpeed * Time.deltaTime, 0);
            }
            
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, -paddleSpeed * Time.deltaTime, 0);
            }
        }

        
    }
}